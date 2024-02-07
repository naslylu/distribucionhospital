namespace distribucionhospital
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Emergencia = new System.Windows.Forms.TextBox();
            this.txt_Cirugia = new System.Windows.Forms.TextBox();
            this.txt_Suministros = new System.Windows.Forms.TextBox();
            this.txt_Administracion = new System.Windows.Forms.TextBox();
            this.txt_Laboratorio = new System.Windows.Forms.TextBox();
            this.txt_Imagenes = new System.Windows.Forms.TextBox();
            this.txt_Presupuesto = new System.Windows.Forms.TextBox();
            this.btn_Distribuir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISTRIBUCION HOSPITAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEPARTAMENTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Emergencia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cirugias";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Suministros";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Administracion";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Laboratorio";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Imagenes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Presupuesto";
            // 
            // txt_Emergencia
            // 
            this.txt_Emergencia.Location = new System.Drawing.Point(215, 151);
            this.txt_Emergencia.Name = "txt_Emergencia";
            this.txt_Emergencia.Size = new System.Drawing.Size(100, 20);
            this.txt_Emergencia.TabIndex = 9;
            // 
            // txt_Cirugia
            // 
            this.txt_Cirugia.Location = new System.Drawing.Point(215, 180);
            this.txt_Cirugia.Name = "txt_Cirugia";
            this.txt_Cirugia.Size = new System.Drawing.Size(100, 20);
            this.txt_Cirugia.TabIndex = 10;
            // 
            // txt_Suministros
            // 
            this.txt_Suministros.Location = new System.Drawing.Point(215, 210);
            this.txt_Suministros.Name = "txt_Suministros";
            this.txt_Suministros.Size = new System.Drawing.Size(100, 20);
            this.txt_Suministros.TabIndex = 11;
            // 
            // txt_Administracion
            // 
            this.txt_Administracion.Location = new System.Drawing.Point(215, 237);
            this.txt_Administracion.Name = "txt_Administracion";
            this.txt_Administracion.Size = new System.Drawing.Size(100, 20);
            this.txt_Administracion.TabIndex = 12;
            // 
            // txt_Laboratorio
            // 
            this.txt_Laboratorio.Location = new System.Drawing.Point(215, 268);
            this.txt_Laboratorio.Name = "txt_Laboratorio";
            this.txt_Laboratorio.Size = new System.Drawing.Size(100, 20);
            this.txt_Laboratorio.TabIndex = 13;
            // 
            // txt_Imagenes
            // 
            this.txt_Imagenes.Location = new System.Drawing.Point(215, 303);
            this.txt_Imagenes.Name = "txt_Imagenes";
            this.txt_Imagenes.Size = new System.Drawing.Size(100, 20);
            this.txt_Imagenes.TabIndex = 14;
            // 
            // txt_Presupuesto
            // 
            this.txt_Presupuesto.Location = new System.Drawing.Point(453, 121);
            this.txt_Presupuesto.Name = "txt_Presupuesto";
            this.txt_Presupuesto.Size = new System.Drawing.Size(100, 20);
            this.txt_Presupuesto.TabIndex = 15;
            // 
            // btn_Distribuir
            // 
            this.btn_Distribuir.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Distribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Distribuir.Location = new System.Drawing.Point(462, 187);
            this.btn_Distribuir.Name = "btn_Distribuir";
            this.btn_Distribuir.Size = new System.Drawing.Size(91, 23);
            this.btn_Distribuir.TabIndex = 16;
            this.btn_Distribuir.Text = "Distribuir";
            this.btn_Distribuir.UseVisualStyleBackColor = false;
            this.btn_Distribuir.Click += new System.EventHandler(this.btn_Distribuir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(462, 244);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(91, 23);
            this.btn_Limpiar.TabIndex = 17;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(462, 306);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(91, 23);
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Distribuir);
            this.Controls.Add(this.txt_Presupuesto);
            this.Controls.Add(this.txt_Imagenes);
            this.Controls.Add(this.txt_Laboratorio);
            this.Controls.Add(this.txt_Administracion);
            this.Controls.Add(this.txt_Suministros);
            this.Controls.Add(this.txt_Cirugia);
            this.Controls.Add(this.txt_Emergencia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Emergencia;
        private System.Windows.Forms.TextBox txt_Cirugia;
        private System.Windows.Forms.TextBox txt_Suministros;
        private System.Windows.Forms.TextBox txt_Administracion;
        private System.Windows.Forms.TextBox txt_Laboratorio;
        private System.Windows.Forms.TextBox txt_Imagenes;
        private System.Windows.Forms.TextBox txt_Presupuesto;
        private System.Windows.Forms.Button btn_Distribuir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
    }
}

