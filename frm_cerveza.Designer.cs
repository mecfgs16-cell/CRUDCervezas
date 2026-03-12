namespace CRUDCervezas
{
    partial class frm_cerveza
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
            lbl_Nombre = new Label();
            lbl_Estilo = new Label();
            lbl_Acohol = new Label();
            lbl_precio = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btn_Cancelar = new Button();
            btn_Aceptar = new Button();
            SuspendLayout();
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(31, 50);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(64, 20);
            lbl_Nombre.TabIndex = 0;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Estilo
            // 
            lbl_Estilo.AutoSize = true;
            lbl_Estilo.Location = new Point(31, 99);
            lbl_Estilo.Name = "lbl_Estilo";
            lbl_Estilo.Size = new Size(45, 20);
            lbl_Estilo.TabIndex = 1;
            lbl_Estilo.Text = "Estilo";
            // 
            // lbl_Acohol
            // 
            lbl_Acohol.AutoSize = true;
            lbl_Acohol.Location = new Point(31, 156);
            lbl_Acohol.Name = "lbl_Acohol";
            lbl_Acohol.Size = new Size(60, 20);
            lbl_Acohol.TabIndex = 2;
            lbl_Acohol.Text = "Alcohol";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(31, 199);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(50, 20);
            lbl_precio.TabIndex = 3;
            lbl_precio.Text = "Precio";
            lbl_precio.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 199);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(31, 272);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(94, 29);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(155, 272);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(94, 29);
            btn_Aceptar.TabIndex = 9;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // frm_cerveza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 381);
            Controls.Add(btn_Aceptar);
            Controls.Add(btn_Cancelar);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_Acohol);
            Controls.Add(lbl_Estilo);
            Controls.Add(lbl_Nombre);
            Name = "frm_cerveza";
            Text = "frm_cerveza";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_Estilo;
        private Label lbl_Acohol;
        private Label lbl_precio;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btn_Cancelar;
        private Button btn_Aceptar;
    }
}