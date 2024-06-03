

using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;

using System.Windows.Forms;

namespace TALA.BuildersXls
{
    
    class ReporteSemanal
    {

        public void CreateNominas(string type ,DataTable tableEmployeesRuld, DataTable tableEmployeesCte, DataTable tableDateDestajo , DataTable tableDatePiso, DataTable tableAttendance, DataTable tableTree)
        {
            HSSFWorkbook workbook = CreateWorkbook();
            ISheet sheetRuld = workbook.CreateSheet("Empleados "+type+" DESTAJO");
            ISheet sheetCTE = workbook.CreateSheet("Empleados " + type + " PISO");
            //ISheet sheetCALI = workbook.CreateSheet("Empleados " + type + " PISO");

            ICellStyle headerStyle = CreateHeaderStyle(workbook);
            ICellStyle rdlStyle = CreateRDLStyle(workbook);
            ICellStyle cteStyle = CreateCTEStyle(workbook);

            PrintRULD(sheetRuld, headerStyle, rdlStyle, cteStyle, tableEmployeesRuld, tableDateDestajo, tableAttendance, tableTree);
            PrintCTE(sheetCTE, headerStyle, rdlStyle, cteStyle, tableEmployeesCte, tableDatePiso, tableAttendance, tableTree);

            SaveAndOpenWorkbook(workbook);

        }


        private void PrintRULD (ISheet sheetRuld, ICellStyle headerStyle, ICellStyle rdlStyle, ICellStyle cteStyle, DataTable tableEmployees, DataTable tableDate, DataTable tableAttendance, DataTable tableTree)
        {
            
            CreateHeaders(sheetRuld, tableEmployees, tableDate, headerStyle);

            FillEmployeeData(sheetRuld, tableEmployees, tableDate, tableAttendance, tableTree, rdlStyle, cteStyle);

            AdjustColumnWidth(sheetRuld, tableDate);

            
        }
        private void PrintCTE(ISheet sheetCTE, ICellStyle headerStyle, ICellStyle rdlStyle, ICellStyle cteStyle, DataTable tableEmployees, DataTable tableDate, DataTable tableAttendance, DataTable tableTree)
        {
                    

            CreateHeaders(sheetCTE, tableEmployees, tableDate, headerStyle);

            FillEmployeeData(sheetCTE, tableEmployees, tableDate, tableAttendance, tableTree, rdlStyle, cteStyle);

            AdjustColumnWidth(sheetCTE, tableDate);
            
        }

        private HSSFWorkbook CreateWorkbook()
        {
            return new HSSFWorkbook();
        }

        private ICellStyle CreateHeaderStyle(HSSFWorkbook workbook)
        {
            ICellStyle headerStyle = workbook.CreateCellStyle();
            headerStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.LightBlue.Index;
            headerStyle.FillPattern = FillPattern.SolidForeground;
            IFont headerFont = workbook.CreateFont();
            
            headerStyle.SetFont(headerFont);
            return headerStyle;
        }

        private ICellStyle CreateRDLStyle(HSSFWorkbook workbook)
        {
            ICellStyle rdlStyle = workbook.CreateCellStyle();
            rdlStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Green.Index;
            rdlStyle.FillPattern = FillPattern.SolidForeground;
            IFont rdlFont = workbook.CreateFont();
            rdlFont.Color = NPOI.HSSF.Util.HSSFColor.White.Index;
            rdlStyle.SetFont(rdlFont);
            return rdlStyle;
        }

        private ICellStyle CreateCTEStyle(HSSFWorkbook workbook)
        {
            ICellStyle cteStyle = workbook.CreateCellStyle();
            cteStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.BlueGrey.Index;
            cteStyle.FillPattern = FillPattern.SolidForeground;
            IFont cteFont = workbook.CreateFont();
            cteFont.Color = NPOI.HSSF.Util.HSSFColor.White.Index;
            cteStyle.SetFont(cteFont);
            return cteStyle;
        }

        private void CreateHeaders(ISheet sheet, DataTable tableEmployees, DataTable tableDate, ICellStyle headerStyle)
        {
            IRow headerRow = sheet.CreateRow(0);
            int positionColumn = 0;
            for (int i = 0; i < tableEmployees.Columns.Count; i++)
            {
                
                headerRow.CreateCell(i).SetCellValue(tableEmployees.Columns[i].ColumnName.ToUpper());
                headerRow.GetCell(i).CellStyle = headerStyle;
                positionColumn++;
            }

            for (int i = 0; i < tableDate.Rows.Count; i++)
            {                
                string formattedDate = DateTime.Parse(tableDate.Rows[i][0].ToString()).ToString();
                headerRow.CreateCell(positionColumn).SetCellValue(formattedDate.ToUpper());
                headerRow.GetCell(positionColumn).CellStyle = headerStyle;
                positionColumn++;
            }

            
            string[] additionalHeaders = { "Pago dias", "Pago bono", "TOTAL A PAGAR PISO", "DIAS MENOS DESTAJO", "ARBOLES TALADOS", "TOTAL A PAGAR DESTAJO" };
            foreach (string header in additionalHeaders)
            {
                headerRow.CreateCell(positionColumn).SetCellValue(header);
                headerRow.GetCell(positionColumn).CellStyle = headerStyle;
                positionColumn++;
            }
        }

        private void FillEmployeeData(ISheet sheet, DataTable tableEmployees, DataTable tableDate, DataTable tableAttendance, DataTable tableTree, ICellStyle rdlStyle, ICellStyle cteStyle)
        {
            int rowIndex = 1;
            int positionColumn = 5;
            int faltas = 0;
            int asistencias = 0;

            
            
            foreach (DataRow row in tableEmployees.Rows)
            {
                IRow excelRow = sheet.CreateRow(rowIndex);

                // Agregar los valores de cada columna a las celdas correspondientes
                for (int i = 0; i < tableEmployees.Columns.Count; i++)
                {
                    ICell cell = excelRow.CreateCell(i);
                    cell.SetCellValue(row[i].ToString());

                    // Aplicar estilos condicionales basados en el contenido de la columna "Razón Social"
                    if (i == 2) // La columna "Razón Social" está en la posición 2 (0-indexed)
                    {
                        string razonSocial = row[i].ToString();
                        if (razonSocial == "RUDL")
                        {
                            cell.CellStyle = rdlStyle;
                        }
                        else if (razonSocial == "CTE")
                        {
                            cell.CellStyle = cteStyle;
                        }
                    }
                }

                rowIndex++;
            }

            //Llenamos los campos de la asistencia
            rowIndex = 1;
            positionColumn = 5;
            faltas = 0;
            asistencias = 0;
            for (int row = 0; row < tableEmployees.Rows.Count; row++)
            {
                IRow excelRow = sheet.GetRow(rowIndex);
                positionColumn = 5;
                for (int column = 0; column < tableDate.Rows.Count; column++)
                {
                    ICell cell = excelRow.CreateCell(positionColumn);


                    int asistencia = FindValue(tableAttendance, "id", "fecha", tableEmployees.Rows[row][0].ToString(), tableDate.Rows[column][0].ToString());

                    if (asistencia == 0)
                    {
                        faltas++;
                        cell.SetCellValue("falta");
                    }
                    else
                    {
                        asistencias++;
                        cell.SetCellValue("Asistió");
                    }
                    positionColumn++;
                }
                //Llenamos las filas de los dias restantes
                ICell cellPago = excelRow.CreateCell(positionColumn);
                ICell cellBono = excelRow.CreateCell(positionColumn + 1);
                ICell cellPagoTotalPiso = excelRow.CreateCell(positionColumn + 2);
                ICell cellArbolesMenos = excelRow.CreateCell(positionColumn + 3);
                //ICell cellArbolesMenos = excelRow.CreateCell(positionColumn + 3);
                string typeEmployed = tableEmployees.Rows[row][1].ToString();


                if (typeEmployed == "DESTAJO")
                {
                    float salario = float.Parse(tableEmployees.Rows[row][3].ToString());
                    float pagoSemanal = salario * faltas;
                    cellArbolesMenos.SetCellValue((pagoSemanal));
                }
                if (typeEmployed == "PISO")
                {
                    
                    float salario = float.Parse(tableEmployees.Rows[row][3].ToString());
                    float bono = float.Parse(tableEmployees.Rows[row][4].ToString());
                    float pagoPorBono = bono / 6;
                    float pagoPorDia = salario / 6;
                    float pagoSemanal = (pagoPorDia * asistencias);
                    float pagoSemanalBono = (pagoPorBono * asistencias);

                    cellPago.SetCellValue((pagoSemanal));
                    cellBono.SetCellValue((pagoSemanalBono));
                    cellPagoTotalPiso.SetCellValue((pagoSemanal + pagoSemanalBono));
                }

                asistencias = 0;
                //pagoSemanal = 0.0f;
                rowIndex++;
                faltas = 0;


            }
            rowIndex = 1;

            //Llenamos los arboles podados por empleado
            for (int i = 0; i < tableEmployees.Rows.Count; i++)
            {

                IRow excelRow = sheet.GetRow(rowIndex);
                ICell cell = excelRow.CreateCell(positionColumn + 4);
                int totalArboles = FindValue(tableTree, "id", tableEmployees.Rows[i][0].ToString());
                //MessageBox.Show(totalArboles.ToString() +" " + tableEmployees.Rows[i][0].ToString());
                //MessageBox.Show(tableTree.Rows.Count.ToString());
                cell.SetCellValue(totalArboles);

                //total a pagar por empleado
                ICell cellFaltasDestajo = excelRow.GetCell(positionColumn + 3);
                if (!String.IsNullOrEmpty(cellFaltasDestajo.ToString())) // Asegúrate de que la celda no esté vacía
                {
                    ICell cellPagoDestajo = excelRow.CreateCell(positionColumn + 5);
                    int faltasDestajo = int.Parse(cellFaltasDestajo.ToString());
                    cellPagoDestajo.SetCellValue(((totalArboles * 275) - faltasDestajo));
                }


                rowIndex++;
            }
        }

        private void AdjustColumnWidth(ISheet sheet, DataTable tableDate)
        {
            for (int i = 0; i < tableDate.Rows.Count + 12; i++)
            {
                sheet.AutoSizeColumn(i);
            }
        }

        private void SaveAndOpenWorkbook(HSSFWorkbook workbook)
        {
            try
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\datos_excel.xls";
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    workbook.Write(fileStream);
                }

                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Para poder visualizar el nuevo documento cierre el anterior");
            }
            
        }
        public void printListAttendance(DataTable tableEmployes, DataTable tableDate, DataTable tableAttendance, string type)
        {

            // Crear un nuevo libro de Excel
            HSSFWorkbook workbook = new HSSFWorkbook();

            // Crear una hoja en el libro de Excel
            ISheet sheet = workbook.CreateSheet("Empleados " + type );

            // Establecer el estilo para los encabezados (como en el ejemplo anterior)
            ICellStyle headerStyle = workbook.CreateCellStyle();
            headerStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.LightBlue.Index;
            headerStyle.FillPattern = FillPattern.SolidForeground;
            IFont headerFont = workbook.CreateFont();            
            headerStyle.SetFont(headerFont);

            // Establecer estilos para los datos
            ICellStyle rdlStyle = workbook.CreateCellStyle();
            rdlStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Green.Index;
            rdlStyle.FillPattern = FillPattern.SolidForeground;
            IFont rdlFont = workbook.CreateFont();
            rdlFont.Color = NPOI.HSSF.Util.HSSFColor.White.Index;
            rdlStyle.SetFont(rdlFont);

            ICellStyle cteStyle = workbook.CreateCellStyle();
            cteStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.BlueGrey.Index;
            cteStyle.FillPattern = FillPattern.SolidForeground;
            IFont cteFont = workbook.CreateFont();
            cteFont.Color = NPOI.HSSF.Util.HSSFColor.White.Index;
            cteStyle.SetFont(cteFont);

            // Obtener los nombres de las columnas de la tabla y agregarlos como encabezados
            IRow headerRow = sheet.CreateRow(0);
            int positionColumn = 0;
            for (int i = 0; i < tableEmployes.Columns.Count; i++)
            {
                headerRow.CreateCell(i).SetCellValue(tableEmployes.Columns[i].ColumnName.ToUpper());
                headerRow.GetCell(i).CellStyle = headerStyle;
                positionColumn++;
            }

            //Insertamos los encabezados de las fechas 
            for (int i = 0; i < tableDate.Rows.Count; i++)
            {
                // Convertir el valor de fecha a un formato específico
                string formattedDate =  DateTime.Parse(tableDate.Rows[i][0].ToString()).ToString();
                // Insertar el encabezado con el valor de fecha formateado
                headerRow.CreateCell(positionColumn).SetCellValue(formattedDate.ToUpper());
                headerRow.GetCell(positionColumn).CellStyle = headerStyle;
                positionColumn++;
            }



            // Agregar los datos de la tabla al libro de Excel
            int rowIndex = 1; // Comenzar desde la segunda fila después de las cabeceras
            foreach (DataRow row in tableEmployes.Rows)
            {
                IRow excelRow = sheet.CreateRow(rowIndex);

                // Agregar los valores de cada columna a las celdas correspondientes
                for (int i = 0; i < tableEmployes.Columns.Count; i++)
                {
                    ICell cell = excelRow.CreateCell(i);
                    cell.SetCellValue(row[i].ToString());

                }

                rowIndex++;
            }

            //Llenamos los campos de la asistencia
            rowIndex = 1;
            positionColumn = 2;
            for (int row = 0; row < tableEmployes.Rows.Count; row++)
            {
                IRow excelRow = sheet.GetRow(rowIndex);
                positionColumn = 2;
                for (int column = 0; column < tableDate.Rows.Count; column++)
                {
                    ICell cell = excelRow.CreateCell(positionColumn);


                    int asistencia = FindValue(tableAttendance, "id", "fecha", tableEmployes.Rows[row][0].ToString(), tableDate.Rows[column][0].ToString());

                    if (asistencia == 0)
                    {

                        cell.SetCellValue("falta");
                    }
                    else
                    {

                        cell.SetCellValue("Asistió");
                    }
                    positionColumn++;
                }
                rowIndex++;
                
            }




                // Ajustar el ancho de las columnas al contenido
                for (int i = 0; i < tableDate.Rows.Count + 12; i++)
                {
                    sheet.AutoSizeColumn(i);
                }

                // Guardar el libro de Excel en un archivo
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Asistencia " + type+ " "+ DateTime.Now.ToString("YYYY-MM-dd") +".xls";

                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    workbook.Write(fileStream);
                }

                // Abrir el archivo de Excel y mostrarlo al usuario
                Process.Start(filePath);

            
        }


        

        public int FindValue(DataTable dataTable, string columnName1, string columnName2, string value1, string value2)
        {
            // Iterar sobre las filas del DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Obtener los valores de las columnas especificadas
                string columnValue1 = row[columnName1].ToString();
                string columnValue2 = row[columnName2].ToString();

                // Comparar los valores con los valores buscados
                if (columnValue1 == value1 && columnValue2 == value2)
                {
                    // Si se encuentra el valor buscado, se devuelve el valor de la columna "Asistencia" como entero
                    return Convert.ToInt32(row["Asistencia"]);
                }
            }

            // Si no se encuentra el valor buscado, se devuelve 0
            return 0;
        }
        public int FindValue(DataTable dataTable, string columnName1, string value1)
        {
            
            // Iterar sobre las filas del DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Obtener los valores de las columnas especificadas
                string columnValue1 = row[columnName1].ToString();
                

                // Comparar los valores con los valores buscados
                if (columnValue1 == value1)
                {
                    // Si se encuentra el valor buscado, se devuelve el valor de la columna "Asistencia" como entero
                    return Convert.ToInt32(row["Total"]);
                }
            }

            // Si no se encuentra el valor buscado, se devuelve 0
            return 0;
        }


    }
    
}

