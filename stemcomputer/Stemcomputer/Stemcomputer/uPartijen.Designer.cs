namespace Stemcomputer
{
    partial class uPartijen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPartij = new System.Windows.Forms.Button();
            this.pictureBoxPartijen = new System.Windows.Forms.PictureBox();
            this.labelNummer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPartijen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPartij
            // 
            this.buttonPartij.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonPartij.Location = new System.Drawing.Point(243, 96);
            this.buttonPartij.Name = "buttonPartij";
            this.buttonPartij.Size = new System.Drawing.Size(112, 49);
            this.buttonPartij.TabIndex = 48;
            this.buttonPartij.Text = "Kies Partij";
            this.buttonPartij.UseVisualStyleBackColor = false;
            this.buttonPartij.Click += new System.EventHandler(this.ButtonPartij_Click_1);
            // 
            // pictureBoxPartijen
            // 
            this.pictureBoxPartijen.Location = new System.Drawing.Point(18, 30);
            this.pictureBoxPartijen.Name = "pictureBoxPartijen";
            this.pictureBoxPartijen.Size = new System.Drawing.Size(351, 337);
            this.pictureBoxPartijen.TabIndex = 47;
            this.pictureBoxPartijen.TabStop = false;
            // 
            // labelNummer
            // 
            this.labelNummer.AutoSize = true;
            this.labelNummer.BackColor = System.Drawing.Color.Black;
            this.labelNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNummer.ForeColor = System.Drawing.Color.Transparent;
            this.labelNummer.Location = new System.Drawing.Point(18, 12);
            this.labelNummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNummer.Name = "labelNummer";
            this.labelNummer.Size = new System.Drawing.Size(31, 15);
            this.labelNummer.TabIndex = 49;
            this.labelNummer.Text = "A00";
            // 
            // uPartijen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNummer);
            this.Controls.Add(this.buttonPartij);
            this.Controls.Add(this.pictureBoxPartijen);
            this.Name = "uPartijen";
            this.Size = new System.Drawing.Size(391, 379);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPartijen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPartij;
        private System.Windows.Forms.PictureBox pictureBoxPartijen;
        public System.Windows.Forms.Label labelNummer;
    }
}
