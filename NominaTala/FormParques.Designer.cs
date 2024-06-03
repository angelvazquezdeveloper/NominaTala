namespace NominaTala
{
    partial class FormParques
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.gridParques = new System.Windows.Forms.DataGridView();
            this.btnCancelarParque = new System.Windows.Forms.Button();
            this.btnAddParque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtParque = new System.Windows.Forms.TextBox();
            this.contextParques = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mdificarParqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParques)).BeginInit();
            this.contextParques.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.gridParques);
            this.groupBox1.Controls.Add(this.btnCancelarParque);
            this.groupBox1.Controls.Add(this.btnAddParque);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtParque);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(501, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARQUES";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(400, 66);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 29);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // gridParques
            // 
            this.gridParques.AllowUserToAddRows = false;
            this.gridParques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridParques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridParques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridParques.ContextMenuStrip = this.contextParques;
            this.gridParques.Location = new System.Drawing.Point(4, 100);
            this.gridParques.Margin = new System.Windows.Forms.Padding(2);
            this.gridParques.MultiSelect = false;
            this.gridParques.Name = "gridParques";
            this.gridParques.ReadOnly = true;
            this.gridParques.RowTemplate.Height = 24;
            this.gridParques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParques.Size = new System.Drawing.Size(479, 138);
            this.gridParques.TabIndex = 7;
            // 
            // btnCancelarParque
            // 
            this.btnCancelarParque.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarParque.Location = new System.Drawing.Point(317, 66);
            this.btnCancelarParque.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarParque.Name = "btnCancelarParque";
            this.btnCancelarParque.Size = new System.Drawing.Size(68, 29);
            this.btnCancelarParque.TabIndex = 6;
            this.btnCancelarParque.Text = "Cancelar";
            this.btnCancelarParque.UseVisualStyleBackColor = true;
            // 
            // btnAddParque
            // 
            this.btnAddParque.Location = new System.Drawing.Point(400, 66);
            this.btnAddParque.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddParque.Name = "btnAddParque";
            this.btnAddParque.Size = new System.Drawing.Size(76, 29);
            this.btnAddParque.TabIndex = 5;
            this.btnAddParque.Text = "Agregar";
            this.btnAddParque.UseVisualStyleBackColor = true;
            this.btnAddParque.Click += new System.EventHandler(this.btnAddParque_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DIRECCION DEL PARQUE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE DEL PARQUE";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(262, 32);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(215, 20);
            this.txtDomicilio.TabIndex = 1;
            // 
            // txtParque
            // 
            this.txtParque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParque.Location = new System.Drawing.Point(14, 32);
            this.txtParque.Margin = new System.Windows.Forms.Padding(2);
            this.txtParque.Name = "txtParque";
            this.txtParque.Size = new System.Drawing.Size(222, 20);
            this.txtParque.TabIndex = 0;
            // 
            // contextParques
            // 
            this.contextParques.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextParques.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.mdificarParqueToolStripMenuItem});
            this.contextParques.Name = "contextParques";
            this.contextParques.Size = new System.Drawing.Size(159, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // mdificarParqueToolStripMenuItem
            // 
            this.mdificarParqueToolStripMenuItem.Name = "mdificarParqueToolStripMenuItem";
            this.mdificarParqueToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mdificarParqueToolStripMenuItem.Text = "Mdificar Parque";
            this.mdificarParqueToolStripMenuItem.Click += new System.EventHandler(this.mdificarParqueToolStripMenuItem_Click);
            // 
            // FormParques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormParques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParques";
            this.Load += new System.EventHandler(this.FormParques_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParques)).EndInit();
            this.contextParques.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView gridParques;
        private System.Windows.Forms.Button btnCancelarParque;
        private System.Windows.Forms.Button btnAddParque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtParque;
        private System.Windows.Forms.ContextMenuStrip contextParques;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mdificarParqueToolStripMenuItem;
    }
}