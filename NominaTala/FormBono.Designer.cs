namespace NominaTala
{
    partial class FormBono
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
            this.groupBono = new System.Windows.Forms.GroupBox();
            this.btnBono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBono = new System.Windows.Forms.TextBox();
            this.groupBono.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBono
            // 
            this.groupBono.Controls.Add(this.btnBono);
            this.groupBono.Controls.Add(this.label1);
            this.groupBono.Controls.Add(this.textBono);
            this.groupBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBono.Location = new System.Drawing.Point(9, 10);
            this.groupBono.Margin = new System.Windows.Forms.Padding(2);
            this.groupBono.Name = "groupBono";
            this.groupBono.Padding = new System.Windows.Forms.Padding(2);
            this.groupBono.Size = new System.Drawing.Size(200, 93);
            this.groupBono.TabIndex = 1;
            this.groupBono.TabStop = false;
            this.groupBono.Text = "Especifique el Bono";
            // 
            // btnBono
            // 
            this.btnBono.Location = new System.Drawing.Point(29, 52);
            this.btnBono.Margin = new System.Windows.Forms.Padding(2);
            this.btnBono.Name = "btnBono";
            this.btnBono.Size = new System.Drawing.Size(146, 36);
            this.btnBono.TabIndex = 2;
            this.btnBono.Text = "Agregar Bono";
            this.btnBono.UseVisualStyleBackColor = true;
            this.btnBono.Click += new System.EventHandler(this.btnBono_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "$";
            // 
            // textBono
            // 
            this.textBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBono.Location = new System.Drawing.Point(40, 25);
            this.textBono.Margin = new System.Windows.Forms.Padding(2);
            this.textBono.MaxLength = 6;
            this.textBono.Name = "textBono";
            this.textBono.Size = new System.Drawing.Size(127, 23);
            this.textBono.TabIndex = 0;
            // 
            // FormBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 112);
            this.Controls.Add(this.groupBono);
            this.Name = "FormBono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bono";
            this.Load += new System.EventHandler(this.FormBono_Load);
            this.groupBono.ResumeLayout(false);
            this.groupBono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBono;
        private System.Windows.Forms.Button btnBono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBono;
    }
}