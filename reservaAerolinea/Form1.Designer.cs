namespace reservaAerolinea
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
            this.btnSmoking = new System.Windows.Forms.Button();
            this.btnNonsmoking = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSeats = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSmoking
            // 
            this.btnSmoking.Location = new System.Drawing.Point(26, 52);
            this.btnSmoking.Name = "btnSmoking";
            this.btnSmoking.Size = new System.Drawing.Size(98, 25);
            this.btnSmoking.TabIndex = 1;
            this.btnSmoking.Text = "1- Smoking";
            this.btnSmoking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmoking.UseVisualStyleBackColor = true;
            this.btnSmoking.Click += new System.EventHandler(this.btnSmoking_Click);
            // 
            // btnNonsmoking
            // 
            this.btnNonsmoking.Location = new System.Drawing.Point(26, 83);
            this.btnNonsmoking.Name = "btnNonsmoking";
            this.btnNonsmoking.Size = new System.Drawing.Size(116, 26);
            this.btnNonsmoking.TabIndex = 2;
            this.btnNonsmoking.Text = "2- Nonsmoking";
            this.btnNonsmoking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNonsmoking.UseVisualStyleBackColor = true;
            this.btnNonsmoking.Click += new System.EventHandler(this.btnNonsmoking_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seating Preference";
            // 
            // lbSeats
            // 
            this.lbSeats.FormattingEnabled = true;
            this.lbSeats.ItemHeight = 16;
            this.lbSeats.Location = new System.Drawing.Point(26, 136);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(369, 132);
            this.lbSeats.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSeats);
            this.Controls.Add(this.btnNonsmoking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSmoking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmoking;
        private System.Windows.Forms.Button btnNonsmoking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSeats;
    }
}

