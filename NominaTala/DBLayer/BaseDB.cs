using System;
using System.Data.SQLite;
using System.Data;


namespace DBLayer
{
    public abstract class BaseDB
    {
        private SQLiteConnection connection;
        public string sQuery = "";
        public string error = "";
        public string createTable = "";

                
        public BaseDB()
        {
            // Especifica la ruta completa de la base de datos
            string folderPath = @"C:\TALA";
            string dbPath = System.IO.Path.Combine(folderPath, "TALA.db");

            // Crea el directorio si no existe
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            // Inicializa la conexión con la base de datos
            connection = new SQLiteConnection($"Data Source={dbPath}");
            OncreateTable();
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

       
        public virtual bool OncreateTable()
        {
            try
            {               
                using (SQLiteCommand cmd = new SQLiteCommand(createTable, connection))
                {

                    OpenConnection();
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public virtual bool Write()
        {
            try
            {
                OpenConnection();                
                SQLiteCommand command = new SQLiteCommand(sQuery, connection);
                command.ExecuteNonQuery();
                CloseConnection();

                Console.WriteLine("Datos insertados correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public virtual bool Update()
        {
            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sQuery, connection);
                command.ExecuteNonQuery();
                CloseConnection();

                Console.WriteLine("Datos actualizados correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los datos: " + ex.Message);
                return false;
            }
        }

        public virtual bool Delete()
        {
            try
            {
                OpenConnection();
                SQLiteCommand command = new SQLiteCommand(sQuery, connection);
                command.ExecuteNonQuery();
                CloseConnection();

                Console.WriteLine("Datos actualizados correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los datos: " + ex.Message);
                return false;
            }
        }


        public virtual DataSet GetList()
        {
            
            // Crear una conexión
            using (SQLiteConnection connection = new SQLiteConnection(this.connection))

            {
                // Abrir la conexión
                OpenConnection();

                // Crear un comando SQL
                using (SQLiteCommand command = new SQLiteCommand(sQuery, connection))
                {
                    // Crear un adaptador de datos SQLite
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        // Crear un DataSet para almacenar los resultados
                        DataSet dataSet = new DataSet();

                        // Llenar el DataSet con los datos obtenidos por el adaptador
                        adapter.Fill(dataSet);

                        // Cerrar la conexión
                        CloseConnection();

                        // Retornar el DataSet
                        return dataSet;
                    }
                }
            }
        }        
    }      
}

