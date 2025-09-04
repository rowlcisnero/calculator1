namespace Calculadora
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnBA = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnSen = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnMmas = new System.Windows.Forms.Button();
            this.btnMmenos = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 26);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(491, 48);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.TabStop = false;
            this.txtDisplay.Text = "0\r\n";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.WordWrap = false;
            this.txtDisplay.Click += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.Color.MediumBlue;
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(12, 102);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(65, 69);
            this.btnsuma.TabIndex = 2;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = false;
            this.btnsuma.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.MediumBlue;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(438, 324);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(65, 144);
            this.btnIgual.TabIndex = 33;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.Color.MediumBlue;
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(83, 102);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(65, 69);
            this.btnresta.TabIndex = 34;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.MediumBlue;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(154, 102);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(65, 69);
            this.btnMultiplicacion.TabIndex = 35;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.MediumBlue;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(225, 102);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(65, 69);
            this.btnDivision.TabIndex = 36;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btnBA
            // 
            this.btnBA.BackColor = System.Drawing.Color.MediumBlue;
            this.btnBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBA.Location = new System.Drawing.Point(367, 174);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(65, 144);
            this.btnBA.TabIndex = 37;
            this.btnBA.Text = "BA";
            this.btnBA.UseVisualStyleBackColor = false;
            this.btnBA.Click += new System.EventHandler(this.btnBA_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(367, 324);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(65, 144);
            this.btnCE.TabIndex = 38;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(296, 324);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(65, 144);
            this.btnLog.TabIndex = 39;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.MediumBlue;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(296, 102);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(65, 69);
            this.btnExp.TabIndex = 40;
            this.btnExp.Text = "^";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(367, 102);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(65, 69);
            this.btnPorcentaje.TabIndex = 41;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = false;
            this.btnPorcentaje.Click += new System.EventHandler(this.btnPorcentaje_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(438, 102);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(65, 69);
            this.btnPi.TabIndex = 42;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnSen
            // 
            this.btnSen.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSen.Location = new System.Drawing.Point(438, 174);
            this.btnSen.Name = "btnSen";
            this.btnSen.Size = new System.Drawing.Size(65, 69);
            this.btnSen.TabIndex = 43;
            this.btnSen.Text = "sen";
            this.btnSen.UseVisualStyleBackColor = false;
            this.btnSen.Click += new System.EventHandler(this.btnSen_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(438, 249);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(65, 69);
            this.btnCos.TabIndex = 44;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.MediumBlue;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(296, 177);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(65, 69);
            this.btnRaiz.TabIndex = 45;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadrado.Location = new System.Drawing.Point(296, 252);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(65, 69);
            this.btnCuadrado.TabIndex = 46;
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // btnMmas
            // 
            this.btnMmas.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMmas.Location = new System.Drawing.Point(12, 177);
            this.btnMmas.Name = "btnMmas";
            this.btnMmas.Size = new System.Drawing.Size(65, 69);
            this.btnMmas.TabIndex = 47;
            this.btnMmas.Text = "M+";
            this.btnMmas.UseVisualStyleBackColor = false;
            this.btnMmas.Click += new System.EventHandler(this.btnMmas_Click);
            // 
            // btnMmenos
            // 
            this.btnMmenos.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMmenos.Location = new System.Drawing.Point(12, 252);
            this.btnMmenos.Name = "btnMmenos";
            this.btnMmenos.Size = new System.Drawing.Size(65, 69);
            this.btnMmenos.TabIndex = 48;
            this.btnMmenos.Text = "M-";
            this.btnMmenos.UseVisualStyleBackColor = false;
            this.btnMmenos.Click += new System.EventHandler(this.btnMmenos_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(12, 324);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(65, 69);
            this.btnMC.TabIndex = 49;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(12, 395);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(65, 69);
            this.btnMR.TabIndex = 50;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(154, 177);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 69);
            this.btn2.TabIndex = 52;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(225, 177);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 69);
            this.btn3.TabIndex = 53;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(83, 252);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 69);
            this.btn4.TabIndex = 54;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(154, 252);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 69);
            this.btn5.TabIndex = 55;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(225, 252);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 69);
            this.btn6.TabIndex = 56;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(225, 327);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 69);
            this.btn9.TabIndex = 57;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(154, 327);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 69);
            this.btn8.TabIndex = 58;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(83, 327);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 69);
            this.btn7.TabIndex = 59;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(83, 399);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(136, 69);
            this.btn0.TabIndex = 60;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(225, 399);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(65, 69);
            this.btnPunto.TabIndex = 61;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(83, 177);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 69);
            this.btn1.TabIndex = 62;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 479);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.btnMmenos);
            this.Controls.Add(this.btnMmas);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSen);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnSen;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnMmas;
        private System.Windows.Forms.Button btnMmenos;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btn1;
    }
}

