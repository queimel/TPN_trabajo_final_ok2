namespace FormPagoAdelantado
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
            this.tb_montoApagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_porcDesc = new System.Windows.Forms.TextBox();
            this.cb_dias = new System.Windows.Forms.ComboBox();
            this.tb_numMeses = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_pagoAdelantado = new System.Windows.Forms.TextBox();
            this.b_consultar = new System.Windows.Forms.Button();
            this.b_restaurar = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto a Pagar";
            // 
            // tb_montoApagar
            // 
            this.tb_montoApagar.Location = new System.Drawing.Point(201, 39);
            this.tb_montoApagar.Name = "tb_montoApagar";
            this.tb_montoApagar.Size = new System.Drawing.Size(210, 20);
            this.tb_montoApagar.TabIndex = 2;
            this.tb_montoApagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Días";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "% descuento";
            // 
            // tb_porcDesc
            // 
            this.tb_porcDesc.Location = new System.Drawing.Point(201, 91);
            this.tb_porcDesc.Name = "tb_porcDesc";
            this.tb_porcDesc.Size = new System.Drawing.Size(99, 20);
            this.tb_porcDesc.TabIndex = 5;
            this.tb_porcDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb_dias
            // 
            this.cb_dias.FormattingEnabled = true;
            this.cb_dias.Items.AddRange(new object[] {
            "",
            "30",
            "60",
            "90",
            "120",
            "180",
            "270"});
            this.cb_dias.Location = new System.Drawing.Point(201, 132);
            this.cb_dias.Name = "cb_dias";
            this.cb_dias.Size = new System.Drawing.Size(120, 21);
            this.cb_dias.TabIndex = 6;
            // 
            // tb_numMeses
            // 
            this.tb_numMeses.Location = new System.Drawing.Point(201, 182);
            this.tb_numMeses.Name = "tb_numMeses";
            this.tb_numMeses.Size = new System.Drawing.Size(99, 20);
            this.tb_numMeses.TabIndex = 8;
            this.tb_numMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_numMeses.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de meses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pago Adelantado";
            // 
            // tb_pagoAdelantado
            // 
            this.tb_pagoAdelantado.Enabled = false;
            this.tb_pagoAdelantado.Location = new System.Drawing.Point(201, 247);
            this.tb_pagoAdelantado.Name = "tb_pagoAdelantado";
            this.tb_pagoAdelantado.Size = new System.Drawing.Size(210, 20);
            this.tb_pagoAdelantado.TabIndex = 11;
            this.tb_pagoAdelantado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_consultar
            // 
            this.b_consultar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_consultar.Location = new System.Drawing.Point(23, 315);
            this.b_consultar.Name = "b_consultar";
            this.b_consultar.Size = new System.Drawing.Size(125, 43);
            this.b_consultar.TabIndex = 12;
            this.b_consultar.Text = "Consultar";
            this.b_consultar.UseVisualStyleBackColor = true;
            this.b_consultar.Click += new System.EventHandler(this.b_consultar_Click);
            // 
            // b_restaurar
            // 
            this.b_restaurar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_restaurar.Location = new System.Drawing.Point(175, 315);
            this.b_restaurar.Name = "b_restaurar";
            this.b_restaurar.Size = new System.Drawing.Size(125, 43);
            this.b_restaurar.TabIndex = 13;
            this.b_restaurar.Text = "Restaurar";
            this.b_restaurar.UseVisualStyleBackColor = true;
            this.b_restaurar.Click += new System.EventHandler(this.b_restaurar_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cerrar.Location = new System.Drawing.Point(330, 315);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(125, 43);
            this.b_cerrar.TabIndex = 14;
            this.b_cerrar.Text = "Cerrar";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Red;
            this.l_mensajes.Location = new System.Drawing.Point(12, 403);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(181, 23);
            this.l_mensajes.TabIndex = 15;
            this.l_mensajes.Text = "Zona de Mensajes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(526, 465);
            this.Controls.Add(this.l_mensajes);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_restaurar);
            this.Controls.Add(this.b_consultar);
            this.Controls.Add(this.tb_pagoAdelantado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_numMeses);
            this.Controls.Add(this.cb_dias);
            this.Controls.Add(this.tb_porcDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_montoApagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consulta de Adelanto de Pago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_montoApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_porcDesc;
        private System.Windows.Forms.ComboBox cb_dias;
        private System.Windows.Forms.TextBox tb_numMeses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_pagoAdelantado;
        private System.Windows.Forms.Button b_consultar;
        private System.Windows.Forms.Button b_restaurar;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Label l_mensajes;
    }
}

