namespace dado
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
            this.btnDado1 = new System.Windows.Forms.Button();
            this.btnDado2 = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDado1
            // 
            this.btnDado1.Location = new System.Drawing.Point(61, 76);
            this.btnDado1.Name = "btnDado1";
            this.btnDado1.Size = new System.Drawing.Size(75, 23);
            this.btnDado1.TabIndex = 0;
            this.btnDado1.Text = "Simular";
            this.btnDado1.UseVisualStyleBackColor = true;
            this.btnDado1.Click += new System.EventHandler(this.btnDado1_Click);
            // 
            // btnDado2
            // 
            this.btnDado2.Location = new System.Drawing.Point(170, 76);
            this.btnDado2.Name = "btnDado2";
            this.btnDado2.Size = new System.Drawing.Size(75, 23);
            this.btnDado2.TabIndex = 1;
            this.btnDado2.Text = "Simular";
            this.btnDado2.UseVisualStyleBackColor = true;
            this.btnDado2.Click += new System.EventHandler(this.btnDado2_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(39, 121);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(400, 196);
            this.lbResults.TabIndex = 2;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tirar dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnDado2);
            this.Controls.Add(this.btnDado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDado1;
        private System.Windows.Forms.Button btnDado2;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label label1;
    }
}

