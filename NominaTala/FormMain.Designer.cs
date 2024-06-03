namespace NominaTala
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPiso = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateAsistencia = new System.Windows.Forms.DateTimePicker();
            this.comboAsistencia = new System.Windows.Forms.ComboBox();
            this.btnCobros = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnParques = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gridDestajo = new System.Windows.Forms.DataGridView();
            this.groupDestajo = new System.Windows.Forms.GroupBox();
            this.groupPiso = new System.Windows.Forms.GroupBox();
            this.btnBorrarAsistencia = new System.Windows.Forms.Button();
            this.btnCrearAsistencia = new System.Windows.Forms.Button();
            this.btnNadieAsistio = new System.Windows.Forms.Button();
            this.btnTodosAsistieron = new System.Windows.Forms.Button();
            this.btnGuardarPios = new System.Windows.Forms.Button();
            this.btnBonoDestajo = new System.Windows.Forms.Button();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarArboles = new System.Windows.Forms.Button();
            this.txtArboles = new System.Windows.Forms.TextBox();
            this.comboParques = new System.Windows.Forms.ComboBox();
            this.contentPiso = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bonoExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bonoRestanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentDestajo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pagarBonoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridPiso)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDestajo)).BeginInit();
            this.groupDestajo.SuspendLayout();
            this.groupPiso.SuspendLayout();
            this.contentPiso.SuspendLayout();
            this.contentDestajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPiso
            // 
            this.gridPiso.AllowUserToAddRows = false;
            this.gridPiso.AllowUserToDeleteRows = false;
            this.gridPiso.AllowUserToResizeRows = false;
            this.gridPiso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPiso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridPiso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPiso.ContextMenuStrip = this.contentPiso;
            this.gridPiso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridPiso.GridColor = System.Drawing.SystemColors.Window;
            this.gridPiso.Location = new System.Drawing.Point(212, 49);
            this.gridPiso.Margin = new System.Windows.Forms.Padding(2);
            this.gridPiso.Name = "gridPiso";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPiso.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPiso.RowTemplate.Height = 24;
            this.gridPiso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPiso.Size = new System.Drawing.Size(1046, 394);
            this.gridPiso.TabIndex = 25;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(510, 15);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 27);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(224, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 27);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dateAsistencia
            // 
            this.dateAsistencia.Location = new System.Drawing.Point(304, 19);
            this.dateAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.dateAsistencia.Name = "dateAsistencia";
            this.dateAsistencia.Size = new System.Drawing.Size(203, 20);
            this.dateAsistencia.TabIndex = 21;
            this.dateAsistencia.ValueChanged += new System.EventHandler(this.dateAsistencia_ValueChanged);
            // 
            // comboAsistencia
            // 
            this.comboAsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAsistencia.FormattingEnabled = true;
            this.comboAsistencia.Items.AddRange(new object[] {
            "DESTAJO",
            "PISO"});
            this.comboAsistencia.Location = new System.Drawing.Point(39, 10);
            this.comboAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.comboAsistencia.Name = "comboAsistencia";
            this.comboAsistencia.Size = new System.Drawing.Size(131, 28);
            this.comboAsistencia.TabIndex = 15;
            this.comboAsistencia.SelectedIndexChanged += new System.EventHandler(this.comboAsistencia_SelectedIndexChanged);
            // 
            // btnCobros
            // 
            this.btnCobros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCobros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(195)))), ((int)(((byte)(194)))));
            this.btnCobros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCobros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobros.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobros.Location = new System.Drawing.Point(3, 172);
            this.btnCobros.Name = "btnCobros";
            this.btnCobros.Size = new System.Drawing.Size(203, 37);
            this.btnCobros.TabIndex = 5;
            this.btnCobros.Text = "PAGOS";
            this.btnCobros.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(195)))), ((int)(((byte)(194)))));
            this.btnAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsistencia.Location = new System.Drawing.Point(3, 135);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(203, 37);
            this.btnAsistencia.TabIndex = 4;
            this.btnAsistencia.Text = "CREAR NOMINA";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnParques
            // 
            this.btnParques.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(195)))), ((int)(((byte)(194)))));
            this.btnParques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnParques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnParques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParques.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParques.ForeColor = System.Drawing.SystemColors.Window;
            this.btnParques.Location = new System.Drawing.Point(3, 93);
            this.btnParques.Name = "btnParques";
            this.btnParques.Size = new System.Drawing.Size(203, 37);
            this.btnParques.TabIndex = 3;
            this.btnParques.Text = "PARQUES";
            this.btnParques.UseVisualStyleBackColor = true;
            this.btnParques.Click += new System.EventHandler(this.btnParques_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(195)))), ((int)(((byte)(194)))));
            this.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleado.Location = new System.Drawing.Point(3, 48);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(203, 37);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(166)))));
            this.panel3.Controls.Add(this.comboAsistencia);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 45);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE TALA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(195)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnCobros);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnParques);
            this.panel1.Controls.Add(this.btnEmpleado);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 442);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 179);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // gridDestajo
            // 
            this.gridDestajo.AllowUserToAddRows = false;
            this.gridDestajo.AllowUserToDeleteRows = false;
            this.gridDestajo.AllowUserToResizeColumns = false;
            this.gridDestajo.AllowUserToResizeRows = false;
            this.gridDestajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDestajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridDestajo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDestajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDestajo.ContextMenuStrip = this.contentDestajo;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDestajo.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDestajo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDestajo.GridColor = System.Drawing.SystemColors.Window;
            this.gridDestajo.Location = new System.Drawing.Point(212, 50);
            this.gridDestajo.Margin = new System.Windows.Forms.Padding(2);
            this.gridDestajo.Name = "gridDestajo";
            this.gridDestajo.ReadOnly = true;
            this.gridDestajo.RowTemplate.Height = 24;
            this.gridDestajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDestajo.Size = new System.Drawing.Size(1046, 393);
            this.gridDestajo.TabIndex = 28;
            this.gridDestajo.Visible = false;
            // 
            // groupDestajo
            // 
            this.groupDestajo.Controls.Add(this.groupPiso);
            this.groupDestajo.Controls.Add(this.btnBonoDestajo);
            this.groupDestajo.Controls.Add(this.comboEmpleado);
            this.groupDestajo.Controls.Add(this.txtNombre);
            this.groupDestajo.Controls.Add(this.btnAgregarArboles);
            this.groupDestajo.Controls.Add(this.txtArboles);
            this.groupDestajo.Controls.Add(this.comboParques);
            this.groupDestajo.Location = new System.Drawing.Point(584, 0);
            this.groupDestajo.Margin = new System.Windows.Forms.Padding(2);
            this.groupDestajo.Name = "groupDestajo";
            this.groupDestajo.Padding = new System.Windows.Forms.Padding(2);
            this.groupDestajo.Size = new System.Drawing.Size(668, 46);
            this.groupDestajo.TabIndex = 29;
            this.groupDestajo.TabStop = false;
            this.groupDestajo.Visible = false;
            // 
            // groupPiso
            // 
            this.groupPiso.Controls.Add(this.btnBorrarAsistencia);
            this.groupPiso.Controls.Add(this.btnCrearAsistencia);
            this.groupPiso.Controls.Add(this.btnNadieAsistio);
            this.groupPiso.Controls.Add(this.btnTodosAsistieron);
            this.groupPiso.Controls.Add(this.btnGuardarPios);
            this.groupPiso.Location = new System.Drawing.Point(0, 3);
            this.groupPiso.Margin = new System.Windows.Forms.Padding(2);
            this.groupPiso.Name = "groupPiso";
            this.groupPiso.Padding = new System.Windows.Forms.Padding(2);
            this.groupPiso.Size = new System.Drawing.Size(666, 43);
            this.groupPiso.TabIndex = 30;
            this.groupPiso.TabStop = false;
            this.groupPiso.Text = "Piso";
            // 
            // btnBorrarAsistencia
            // 
            this.btnBorrarAsistencia.Location = new System.Drawing.Point(64, 11);
            this.btnBorrarAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrarAsistencia.Name = "btnBorrarAsistencia";
            this.btnBorrarAsistencia.Size = new System.Drawing.Size(104, 27);
            this.btnBorrarAsistencia.TabIndex = 4;
            this.btnBorrarAsistencia.Text = "Eliminar Dia";
            this.btnBorrarAsistencia.UseVisualStyleBackColor = true;
            this.btnBorrarAsistencia.Click += new System.EventHandler(this.btnBorrarAsistencia_Click);
            // 
            // btnCrearAsistencia
            // 
            this.btnCrearAsistencia.Location = new System.Drawing.Point(398, 11);
            this.btnCrearAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearAsistencia.Name = "btnCrearAsistencia";
            this.btnCrearAsistencia.Size = new System.Drawing.Size(112, 27);
            this.btnCrearAsistencia.TabIndex = 3;
            this.btnCrearAsistencia.Text = "Crear Asistencia";
            this.btnCrearAsistencia.UseVisualStyleBackColor = true;
            this.btnCrearAsistencia.Click += new System.EventHandler(this.btnCrearAsistencia_Click);
            // 
            // btnNadieAsistio
            // 
            this.btnNadieAsistio.Location = new System.Drawing.Point(172, 11);
            this.btnNadieAsistio.Margin = new System.Windows.Forms.Padding(2);
            this.btnNadieAsistio.Name = "btnNadieAsistio";
            this.btnNadieAsistio.Size = new System.Drawing.Size(104, 27);
            this.btnNadieAsistio.TabIndex = 2;
            this.btnNadieAsistio.Text = "Nadie Asistio";
            this.btnNadieAsistio.UseVisualStyleBackColor = true;
            this.btnNadieAsistio.Click += new System.EventHandler(this.btnNadieAsistio_Click);
            // 
            // btnTodosAsistieron
            // 
            this.btnTodosAsistieron.Location = new System.Drawing.Point(280, 11);
            this.btnTodosAsistieron.Margin = new System.Windows.Forms.Padding(2);
            this.btnTodosAsistieron.Name = "btnTodosAsistieron";
            this.btnTodosAsistieron.Size = new System.Drawing.Size(112, 27);
            this.btnTodosAsistieron.TabIndex = 1;
            this.btnTodosAsistieron.Text = "Todos Asistieron";
            this.btnTodosAsistieron.UseVisualStyleBackColor = true;
            this.btnTodosAsistieron.Click += new System.EventHandler(this.btnTodosAsistieron_Click);
            // 
            // btnGuardarPios
            // 
            this.btnGuardarPios.Location = new System.Drawing.Point(514, 11);
            this.btnGuardarPios.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarPios.Name = "btnGuardarPios";
            this.btnGuardarPios.Size = new System.Drawing.Size(140, 28);
            this.btnGuardarPios.TabIndex = 0;
            this.btnGuardarPios.Text = "GUARDAR ASISTENCIA";
            this.btnGuardarPios.UseVisualStyleBackColor = true;
            this.btnGuardarPios.Click += new System.EventHandler(this.btnGuardarPios_Click);
            // 
            // btnBonoDestajo
            // 
            this.btnBonoDestajo.Location = new System.Drawing.Point(671, 14);
            this.btnBonoDestajo.Name = "btnBonoDestajo";
            this.btnBonoDestajo.Size = new System.Drawing.Size(75, 23);
            this.btnBonoDestajo.TabIndex = 21;
            this.btnBonoDestajo.Text = "Bono Dia";
            this.btnBonoDestajo.UseVisualStyleBackColor = true;
            this.btnBonoDestajo.Visible = false;
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(16, 15);
            this.comboEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(171, 25);
            this.comboEmpleado.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(45, 15);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 23);
            this.txtNombre.TabIndex = 17;
            // 
            // btnAgregarArboles
            // 
            this.btnAgregarArboles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArboles.Location = new System.Drawing.Point(472, 14);
            this.btnAgregarArboles.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArboles.Name = "btnAgregarArboles";
            this.btnAgregarArboles.Size = new System.Drawing.Size(170, 29);
            this.btnAgregarArboles.TabIndex = 16;
            this.btnAgregarArboles.Text = "Agregar Arboles";
            this.btnAgregarArboles.UseVisualStyleBackColor = true;
            this.btnAgregarArboles.Click += new System.EventHandler(this.btnAgregarArboles_Click);
            // 
            // txtArboles
            // 
            this.txtArboles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArboles.Location = new System.Drawing.Point(199, 15);
            this.txtArboles.Margin = new System.Windows.Forms.Padding(2);
            this.txtArboles.Name = "txtArboles";
            this.txtArboles.Size = new System.Drawing.Size(110, 23);
            this.txtArboles.TabIndex = 15;
            // 
            // comboParques
            // 
            this.comboParques.FormattingEnabled = true;
            this.comboParques.Location = new System.Drawing.Point(313, 18);
            this.comboParques.Margin = new System.Windows.Forms.Padding(2);
            this.comboParques.Name = "comboParques";
            this.comboParques.Size = new System.Drawing.Size(156, 21);
            this.comboParques.TabIndex = 14;
            // 
            // contentPiso
            // 
            this.contentPiso.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contentPiso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bonoExtraToolStripMenuItem,
            this.bonoRestanteToolStripMenuItem});
            this.contentPiso.Name = "contentPiso";
            this.contentPiso.Size = new System.Drawing.Size(151, 48);
            // 
            // bonoExtraToolStripMenuItem
            // 
            this.bonoExtraToolStripMenuItem.Name = "bonoExtraToolStripMenuItem";
            this.bonoExtraToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bonoExtraToolStripMenuItem.Text = "Bono Extra";
            this.bonoExtraToolStripMenuItem.Click += new System.EventHandler(this.bonoExtraToolStripMenuItem_Click);
            // 
            // bonoRestanteToolStripMenuItem
            // 
            this.bonoRestanteToolStripMenuItem.Name = "bonoRestanteToolStripMenuItem";
            this.bonoRestanteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bonoRestanteToolStripMenuItem.Text = "Bono Restante";
            this.bonoRestanteToolStripMenuItem.Click += new System.EventHandler(this.bonoRestanteToolStripMenuItem_Click);
            // 
            // contentDestajo
            // 
            this.contentDestajo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contentDestajo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagarBonoDiaToolStripMenuItem,
            this.eliminarRegistroToolStripMenuItem});
            this.contentDestajo.Name = "contentDestajo";
            this.contentDestajo.Size = new System.Drawing.Size(164, 70);
            // 
            // pagarBonoDiaToolStripMenuItem
            // 
            this.pagarBonoDiaToolStripMenuItem.Name = "pagarBonoDiaToolStripMenuItem";
            this.pagarBonoDiaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pagarBonoDiaToolStripMenuItem.Text = "Pagar Bono Dia";
            this.pagarBonoDiaToolStripMenuItem.Click += new System.EventHandler(this.pagarBonoDiaToolStripMenuItem_Click);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 442);
            this.Controls.Add(this.groupDestajo);
            this.Controls.Add(this.gridDestajo);
            this.Controls.Add(this.gridPiso);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dateAsistencia);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPiso)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDestajo)).EndInit();
            this.groupDestajo.ResumeLayout(false);
            this.groupDestajo.PerformLayout();
            this.groupPiso.ResumeLayout(false);
            this.contentPiso.ResumeLayout(false);
            this.contentDestajo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPiso;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateAsistencia;
        private System.Windows.Forms.ComboBox comboAsistencia;
        private System.Windows.Forms.Button btnCobros;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnParques;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView gridDestajo;
        private System.Windows.Forms.GroupBox groupDestajo;
        private System.Windows.Forms.GroupBox groupPiso;
        private System.Windows.Forms.Button btnBorrarAsistencia;
        private System.Windows.Forms.Button btnCrearAsistencia;
        private System.Windows.Forms.Button btnNadieAsistio;
        private System.Windows.Forms.Button btnTodosAsistieron;
        private System.Windows.Forms.Button btnGuardarPios;
        private System.Windows.Forms.Button btnBonoDestajo;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarArboles;
        private System.Windows.Forms.TextBox txtArboles;
        private System.Windows.Forms.ComboBox comboParques;
        private System.Windows.Forms.ContextMenuStrip contentPiso;
        private System.Windows.Forms.ToolStripMenuItem bonoExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonoRestanteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contentDestajo;
        private System.Windows.Forms.ToolStripMenuItem pagarBonoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
    }
}

