namespace MiCalculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.txtOpPrimer = new System.Windows.Forms.TextBox();
            this.botonOperar = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opcionDecimal = new System.Windows.Forms.RadioButton();
            this.opcionBinario = new System.Windows.Forms.RadioButton();
            this.cajaOperacion = new System.Windows.Forms.ComboBox();
            this.elegirResultado = new System.Windows.Forms.GroupBox();
            this.resultMostrar = new System.Windows.Forms.Label();
            this.elegirResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado:";
            // 
            // txtOpseg
            // 
            this.txtOpseg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtOpseg.Location = new System.Drawing.Point(752, 366);
            this.txtOpseg.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.Size = new System.Drawing.Size(256, 23);
            this.txtOpseg.TabIndex = 3;
            this.txtOpseg.TextChanged += new System.EventHandler(this.txtOpseg_TextChanged);
            // 
            // txtOpPrimer
            // 
            this.txtOpPrimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtOpPrimer.Location = new System.Drawing.Point(104, 366);
            this.txtOpPrimer.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpPrimer.Name = "txtOpPrimer";
            this.txtOpPrimer.Size = new System.Drawing.Size(255, 23);
            this.txtOpPrimer.TabIndex = 2;
            this.txtOpPrimer.TextChanged += new System.EventHandler(this.txtOpPrimer_TextChanged);
            // 
            // botonOperar
            // 
            this.botonOperar.Location = new System.Drawing.Point(461, 446);
            this.botonOperar.Margin = new System.Windows.Forms.Padding(4);
            this.botonOperar.Name = "botonOperar";
            this.botonOperar.Size = new System.Drawing.Size(155, 50);
            this.botonOperar.TabIndex = 7;
            this.botonOperar.Text = "Operar";
            this.botonOperar.UseVisualStyleBackColor = true;
            this.botonOperar.Click += new System.EventHandler(this.botonOperar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Location = new System.Drawing.Point(783, 446);
            this.botonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(155, 50);
            this.botonCerrar.TabIndex = 8;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(129, 446);
            this.botonLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(160, 50);
            this.botonLimpiar.TabIndex = 6;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(748, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Segundo operador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Primer operador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Operacion";
            // 
            // opcionDecimal
            // 
            this.opcionDecimal.AutoSize = true;
            this.opcionDecimal.Location = new System.Drawing.Point(20, 23);
            this.opcionDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.opcionDecimal.Name = "opcionDecimal";
            this.opcionDecimal.Size = new System.Drawing.Size(76, 21);
            this.opcionDecimal.TabIndex = 4;
            this.opcionDecimal.Text = "Decimal";
            this.opcionDecimal.UseVisualStyleBackColor = true;
            this.opcionDecimal.CheckedChanged += new System.EventHandler(this.opcionDecimal_CheckedChanged);
            // 
            // opcionBinario
            // 
            this.opcionBinario.AutoSize = true;
            this.opcionBinario.Location = new System.Drawing.Point(139, 23);
            this.opcionBinario.Margin = new System.Windows.Forms.Padding(4);
            this.opcionBinario.Name = "opcionBinario";
            this.opcionBinario.Size = new System.Drawing.Size(70, 21);
            this.opcionBinario.TabIndex = 5;
            this.opcionBinario.Text = "Binario";
            this.opcionBinario.UseVisualStyleBackColor = true;
            this.opcionBinario.CheckedChanged += new System.EventHandler(this.opcionBinario_CheckedChanged);
            // 
            // cajaOperacion
            // 
            this.cajaOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cajaOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cajaOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaOperacion.FormattingEnabled = true;
            this.cajaOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cajaOperacion.Location = new System.Drawing.Point(441, 364);
            this.cajaOperacion.Margin = new System.Windows.Forms.Padding(4);
            this.cajaOperacion.Name = "cajaOperacion";
            this.cajaOperacion.Size = new System.Drawing.Size(213, 24);
            this.cajaOperacion.TabIndex = 1;
            // 
            // elegirResultado
            // 
            this.elegirResultado.Controls.Add(this.opcionBinario);
            this.elegirResultado.Controls.Add(this.opcionDecimal);
            this.elegirResultado.Location = new System.Drawing.Point(413, 237);
            this.elegirResultado.Margin = new System.Windows.Forms.Padding(4);
            this.elegirResultado.Name = "elegirResultado";
            this.elegirResultado.Padding = new System.Windows.Forms.Padding(4);
            this.elegirResultado.Size = new System.Drawing.Size(267, 65);
            this.elegirResultado.TabIndex = 14;
            this.elegirResultado.TabStop = false;
            this.elegirResultado.Text = "Representar el resultado en: ";
            // 
            // resultMostrar
            // 
            this.resultMostrar.AutoSize = true;
            this.resultMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultMostrar.Location = new System.Drawing.Point(321, 86);
            this.resultMostrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultMostrar.Name = "resultMostrar";
            this.resultMostrar.Size = new System.Drawing.Size(23, 31);
            this.resultMostrar.TabIndex = 10;
            this.resultMostrar.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.resultMostrar);
            this.Controls.Add(this.elegirResultado);
            this.Controls.Add(this.cajaOperacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonOperar);
            this.Controls.Add(this.txtOpPrimer);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Ignacio Fadon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.elegirResultado.ResumeLayout(false);
            this.elegirResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.TextBox txtOpPrimer;
        private System.Windows.Forms.Button botonOperar;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton opcionDecimal;
        private System.Windows.Forms.RadioButton opcionBinario;
        private System.Windows.Forms.ComboBox cajaOperacion;
        private System.Windows.Forms.GroupBox elegirResultado;
        private System.Windows.Forms.Label resultMostrar;
    }
}

