namespace PedidosApp_Juan_Camilo_Ardila
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.lblPeso = new System.Windows.Forms.Label();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(91, 106);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(199, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(91, 132);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(199, 21);
            this.cmbProducto.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(32, 109);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Nombre:";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(32, 135);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto:";
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(378, 109);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(64, 17);
            this.chkUrgente.TabIndex = 4;
            this.chkUrgente.Text = "Urgente";
            this.chkUrgente.UseVisualStyleBackColor = true;
            this.chkUrgente.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(92, 159);
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(199, 20);
            this.nudPeso.TabIndex = 5;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(32, 161);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(92, 185);
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(199, 20);
            this.nudDistancia.TabIndex = 7;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(32, 187);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(54, 13);
            this.lblDistancia.TabIndex = 8;
            this.lblDistancia.Text = "Distancia:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(132, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 41);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(31, 312);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "PEDIDOS APP";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.nudDistancia);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}

