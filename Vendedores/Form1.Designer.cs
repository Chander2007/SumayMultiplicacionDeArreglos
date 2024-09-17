namespace Vendedores
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
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnAgregarReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVendedor = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbReporte = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(270, 99);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(158, 28);
            this.btnAgregarVenta.TabIndex = 0;
            this.btnAgregarVenta.Text = "Agregar venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnAgregarReporte
            // 
            this.btnAgregarReporte.Location = new System.Drawing.Point(134, 146);
            this.btnAgregarReporte.Name = "btnAgregarReporte";
            this.btnAgregarReporte.Size = new System.Drawing.Size(150, 23);
            this.btnAgregarReporte.TabIndex = 1;
            this.btnAgregarReporte.Text = "Mostrar reporte";
            this.btnAgregarReporte.UseVisualStyleBackColor = true;
            this.btnAgregarReporte.Click += new System.EventHandler(this.btnAgregarReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendedor número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de producto:";
            // 
            // tbVendedor
            // 
            this.tbVendedor.Location = new System.Drawing.Point(159, 41);
            this.tbVendedor.Name = "tbVendedor";
            this.tbVendedor.Size = new System.Drawing.Size(100, 22);
            this.tbVendedor.TabIndex = 4;
            this.tbVendedor.TextChanged += new System.EventHandler(this.tbVendedor_TextChanged);
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(159, 73);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(100, 22);
            this.tbProducto.TabIndex = 5;
            this.tbProducto.TextChanged += new System.EventHandler(this.tbProducto_TextChanged);
            // 
            // tbVenta
            // 
            this.tbVenta.Location = new System.Drawing.Point(159, 102);
            this.tbVenta.Name = "tbVenta";
            this.tbVenta.Size = new System.Drawing.Size(100, 22);
            this.tbVenta.TabIndex = 6;
            this.tbVenta.TextChanged += new System.EventHandler(this.tbVenta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Venta:";
            // 
            // lbReporte
            // 
            this.lbReporte.FormattingEnabled = true;
            this.lbReporte.ItemHeight = 16;
            this.lbReporte.Location = new System.Drawing.Point(41, 197);
            this.lbReporte.Name = "lbReporte";
            this.lbReporte.Size = new System.Drawing.Size(387, 164);
            this.lbReporte.TabIndex = 8;
            this.lbReporte.SelectedIndexChanged += new System.EventHandler(this.lbReporte_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "1-4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "1-5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbReporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbVenta);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.tbVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarReporte);
            this.Controls.Add(this.btnAgregarVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnAgregarReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVendedor;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.TextBox tbVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

