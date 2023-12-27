
namespace Metodo_de_las_secantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIntervaloMenor = new System.Windows.Forms.TextBox();
            this.txtIntervaloMayor = new System.Windows.Forms.TextBox();
            this.txtPorcentajeError = new System.Windows.Forms.TextBox();
            this.txtx5 = new System.Windows.Forms.TextBox();
            this.txtx4 = new System.Windows.Forms.TextBox();
            this.txtx6 = new System.Windows.Forms.TextBox();
            this.txtNumDecimales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtx3 = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.txtx = new System.Windows.Forms.TextBox();
            this.txtConstante = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiarSalida = new System.Windows.Forms.Button();
            this.btnLimpiarTodo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIntervaloMenor
            // 
            this.txtIntervaloMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervaloMenor.Location = new System.Drawing.Point(216, 17);
            this.txtIntervaloMenor.Name = "txtIntervaloMenor";
            this.txtIntervaloMenor.Size = new System.Drawing.Size(100, 26);
            this.txtIntervaloMenor.TabIndex = 1;
            this.txtIntervaloMenor.Text = "-6";
            this.txtIntervaloMenor.Click += new System.EventHandler(this.txtIntervaloMenor_Click);
            this.txtIntervaloMenor.Enter += new System.EventHandler(this.txtIntervaloMenor_Enter);
            // 
            // txtIntervaloMayor
            // 
            this.txtIntervaloMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervaloMayor.Location = new System.Drawing.Point(216, 49);
            this.txtIntervaloMayor.Name = "txtIntervaloMayor";
            this.txtIntervaloMayor.Size = new System.Drawing.Size(100, 26);
            this.txtIntervaloMayor.TabIndex = 2;
            this.txtIntervaloMayor.Text = "3";
            this.txtIntervaloMayor.Click += new System.EventHandler(this.txtIntervaloMayor_Click);
            this.txtIntervaloMayor.Enter += new System.EventHandler(this.txtIntervaloMayor_Enter);
            // 
            // txtPorcentajeError
            // 
            this.txtPorcentajeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeError.Location = new System.Drawing.Point(216, 113);
            this.txtPorcentajeError.Name = "txtPorcentajeError";
            this.txtPorcentajeError.Size = new System.Drawing.Size(100, 26);
            this.txtPorcentajeError.TabIndex = 4;
            this.txtPorcentajeError.Text = "5";
            this.txtPorcentajeError.Click += new System.EventHandler(this.txtPorcentajeError_Click);
            this.txtPorcentajeError.Enter += new System.EventHandler(this.txtPorcentajeError_Enter);
            // 
            // txtx5
            // 
            this.txtx5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx5.Location = new System.Drawing.Point(215, 49);
            this.txtx5.Name = "txtx5";
            this.txtx5.Size = new System.Drawing.Size(100, 26);
            this.txtx5.TabIndex = 7;
            this.txtx5.Text = "0";
            this.txtx5.Click += new System.EventHandler(this.txtx5_Click);
            this.txtx5.Enter += new System.EventHandler(this.txtx5_Enter);
            // 
            // txtx4
            // 
            this.txtx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx4.Location = new System.Drawing.Point(215, 81);
            this.txtx4.Name = "txtx4";
            this.txtx4.Size = new System.Drawing.Size(100, 26);
            this.txtx4.TabIndex = 8;
            this.txtx4.Text = "0";
            this.txtx4.Click += new System.EventHandler(this.txtx4_Click);
            this.txtx4.Enter += new System.EventHandler(this.txtx4_Enter);
            // 
            // txtx6
            // 
            this.txtx6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx6.Location = new System.Drawing.Point(215, 17);
            this.txtx6.Name = "txtx6";
            this.txtx6.Size = new System.Drawing.Size(100, 26);
            this.txtx6.TabIndex = 6;
            this.txtx6.Text = "0";
            this.txtx6.Click += new System.EventHandler(this.txtx6_Click);
            this.txtx6.Enter += new System.EventHandler(this.txtx6_Enter);
            // 
            // txtNumDecimales
            // 
            this.txtNumDecimales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDecimales.Location = new System.Drawing.Point(216, 81);
            this.txtNumDecimales.Name = "txtNumDecimales";
            this.txtNumDecimales.Size = new System.Drawing.Size(100, 26);
            this.txtNumDecimales.TabIndex = 3;
            this.txtNumDecimales.Text = "5";
            this.txtNumDecimales.Click += new System.EventHandler(this.txtNumDecimales_Click);
            this.txtNumDecimales.Enter += new System.EventHandler(this.txtNumDecimales_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intervalo Menor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Intervalo Mayor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero de Decimales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Porcentaje de Error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "X6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "X5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "X4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "X3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "X2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Constante";
            // 
            // txtx3
            // 
            this.txtx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx3.Location = new System.Drawing.Point(215, 113);
            this.txtx3.Name = "txtx3";
            this.txtx3.Size = new System.Drawing.Size(100, 26);
            this.txtx3.TabIndex = 9;
            this.txtx3.Text = "0";
            this.txtx3.Click += new System.EventHandler(this.txtx3_Click);
            this.txtx3.Enter += new System.EventHandler(this.txtx3_Enter);
            // 
            // txtx2
            // 
            this.txtx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx2.Location = new System.Drawing.Point(215, 145);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(100, 26);
            this.txtx2.TabIndex = 10;
            this.txtx2.Text = "-1";
            this.txtx2.Click += new System.EventHandler(this.txtx2_Click);
            this.txtx2.Enter += new System.EventHandler(this.txtx2_Enter);
            // 
            // txtx
            // 
            this.txtx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtx.Location = new System.Drawing.Point(215, 177);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(100, 26);
            this.txtx.TabIndex = 11;
            this.txtx.Text = "1.8";
            this.txtx.Click += new System.EventHandler(this.txtx_Click);
            this.txtx.Enter += new System.EventHandler(this.txtx_Enter);
            // 
            // txtConstante
            // 
            this.txtConstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConstante.Location = new System.Drawing.Point(215, 209);
            this.txtConstante.Name = "txtConstante";
            this.txtConstante.Size = new System.Drawing.Size(100, 26);
            this.txtConstante.TabIndex = 12;
            this.txtConstante.Text = "2.5";
            this.txtConstante.Click += new System.EventHandler(this.txtConstante_Click);
            this.txtConstante.Enter += new System.EventHandler(this.txtConstante_Enter);
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(6, 16);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSalida.Size = new System.Drawing.Size(318, 377);
            this.txtSalida.TabIndex = 22;
            this.txtSalida.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(141, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 29);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiarSalida
            // 
            this.btnLimpiarSalida.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarSalida.Location = new System.Drawing.Point(270, 19);
            this.btnLimpiarSalida.Name = "btnLimpiarSalida";
            this.btnLimpiarSalida.Size = new System.Drawing.Size(119, 29);
            this.btnLimpiarSalida.TabIndex = 15;
            this.btnLimpiarSalida.Text = "Limpiar Salida";
            this.btnLimpiarSalida.UseVisualStyleBackColor = false;
            this.btnLimpiarSalida.Click += new System.EventHandler(this.btnLimpiarSalida_Click);
            // 
            // btnLimpiarTodo
            // 
            this.btnLimpiarTodo.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTodo.Location = new System.Drawing.Point(441, 19);
            this.btnLimpiarTodo.Name = "btnLimpiarTodo";
            this.btnLimpiarTodo.Size = new System.Drawing.Size(108, 29);
            this.btnLimpiarTodo.TabIndex = 16;
            this.btnLimpiarTodo.Text = "Limpiar Todo";
            this.btnLimpiarTodo.UseVisualStyleBackColor = false;
            this.btnLimpiarTodo.Click += new System.EventHandler(this.btnLimpiarTodo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtx6);
            this.groupBox1.Controls.Add(this.txtx5);
            this.groupBox1.Controls.Add(this.txtx4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtConstante);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtx);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtx2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtx3);
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores de la Función";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIntervaloMenor);
            this.groupBox2.Controls.Add(this.txtIntervaloMayor);
            this.groupBox2.Controls.Add(this.txtPorcentajeError);
            this.groupBox2.Controls.Add(this.txtNumDecimales);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 155);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.btnCalcular);
            this.groupBox3.Controls.Add(this.btnLimpiarSalida);
            this.groupBox3.Controls.Add(this.btnLimpiarTodo);
            this.groupBox3.Location = new System.Drawing.Point(12, 527);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 59);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controles";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.txtSalida);
            this.groupBox4.Location = new System.Drawing.Point(368, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 405);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Salida";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 98);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(717, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntervaloMenor;
        private System.Windows.Forms.TextBox txtIntervaloMayor;
        private System.Windows.Forms.TextBox txtPorcentajeError;
        private System.Windows.Forms.TextBox txtx5;
        private System.Windows.Forms.TextBox txtx4;
        private System.Windows.Forms.TextBox txtx6;
        private System.Windows.Forms.TextBox txtNumDecimales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtx3;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.TextBox txtConstante;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiarSalida;
        private System.Windows.Forms.Button btnLimpiarTodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

