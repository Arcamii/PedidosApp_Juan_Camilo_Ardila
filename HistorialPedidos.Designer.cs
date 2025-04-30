namespace PedidosApp_Juan_Camilo_Ardila
{
    partial class HistorialPedidos
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
            this.dgvHistorialPedidos = new System.Windows.Forms.DataGridView();
            this.lblFiltroHistorial = new System.Windows.Forms.Label();
            this.cmbFiltroHistorial = new System.Windows.Forms.ComboBox();
            this.lblHistorialTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialPedidos
            // 
            this.dgvHistorialPedidos.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvHistorialPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialPedidos.Location = new System.Drawing.Point(23, 102);
            this.dgvHistorialPedidos.Name = "dgvHistorialPedidos";
            this.dgvHistorialPedidos.Size = new System.Drawing.Size(756, 318);
            this.dgvHistorialPedidos.TabIndex = 0;
            // 
            // lblFiltroHistorial
            // 
            this.lblFiltroHistorial.AutoSize = true;
            this.lblFiltroHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroHistorial.Location = new System.Drawing.Point(20, 69);
            this.lblFiltroHistorial.Name = "lblFiltroHistorial";
            this.lblFiltroHistorial.Size = new System.Drawing.Size(87, 18);
            this.lblFiltroHistorial.TabIndex = 1;
            this.lblFiltroHistorial.Text = "Filtrar por:";
            // 
            // cmbFiltroHistorial
            // 
            this.cmbFiltroHistorial.FormattingEnabled = true;
            this.cmbFiltroHistorial.Location = new System.Drawing.Point(113, 70);
            this.cmbFiltroHistorial.Name = "cmbFiltroHistorial";
            this.cmbFiltroHistorial.Size = new System.Drawing.Size(164, 21);
            this.cmbFiltroHistorial.TabIndex = 2;
            // 
            // lblHistorialTitulo
            // 
            this.lblHistorialTitulo.AutoSize = true;
            this.lblHistorialTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialTitulo.Location = new System.Drawing.Point(282, 27);
            this.lblHistorialTitulo.Name = "lblHistorialTitulo";
            this.lblHistorialTitulo.Size = new System.Drawing.Size(196, 24);
            this.lblHistorialTitulo.TabIndex = 3;
            this.lblHistorialTitulo.Text = "Historial de pedidos";
            // 
            // HistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHistorialTitulo);
            this.Controls.Add(this.cmbFiltroHistorial);
            this.Controls.Add(this.lblFiltroHistorial);
            this.Controls.Add(this.dgvHistorialPedidos);
            this.Name = "HistorialPedidos";
            this.Text = "HistorialPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialPedidos;
        private System.Windows.Forms.Label lblFiltroHistorial;
        private System.Windows.Forms.ComboBox cmbFiltroHistorial;
        private System.Windows.Forms.Label lblHistorialTitulo;
    }
}