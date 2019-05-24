namespace Stemcomputer
{
    partial class uKandidaten
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
            this.labelNummerKandidaat = new System.Windows.Forms.Label();
            this.buttonKandidaat = new System.Windows.Forms.Button();
            this.LabelKandidaatNaam = new System.Windows.Forms.Label();
            this.LabelKandidaatAchterNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNummerKandidaat
            // 
            this.labelNummerKandidaat.AutoSize = true;
            this.labelNummerKandidaat.BackColor = System.Drawing.Color.Black;
            this.labelNummerKandidaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNummerKandidaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNummerKandidaat.ForeColor = System.Drawing.Color.Transparent;
            this.labelNummerKandidaat.Location = new System.Drawing.Point(18, 12);
            this.labelNummerKandidaat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNummerKandidaat.Name = "labelNummerKandidaat";
            this.labelNummerKandidaat.Size = new System.Drawing.Size(23, 15);
            this.labelNummerKandidaat.TabIndex = 52;
            this.labelNummerKandidaat.Text = "00";
            // 
            // buttonKandidaat
            // 
            this.buttonKandidaat.Location = new System.Drawing.Point(18, 158);
            this.buttonKandidaat.Name = "buttonKandidaat";
            this.buttonKandidaat.Size = new System.Drawing.Size(112, 49);
            this.buttonKandidaat.TabIndex = 51;
            this.buttonKandidaat.Text = "Kies Kandidaat";
            this.buttonKandidaat.UseVisualStyleBackColor = true;
            this.buttonKandidaat.Click += new System.EventHandler(this.ButtonKandidaat_Click);
            // 
            // LabelKandidaatNaam
            // 
            this.LabelKandidaatNaam.AutoSize = true;
            this.LabelKandidaatNaam.Location = new System.Drawing.Point(73, 53);
            this.LabelKandidaatNaam.Name = "LabelKandidaatNaam";
            this.LabelKandidaatNaam.Size = new System.Drawing.Size(35, 13);
            this.LabelKandidaatNaam.TabIndex = 53;
            this.LabelKandidaatNaam.Text = "label1";
            // 
            // LabelKandidaatAchterNaam
            // 
            this.LabelKandidaatAchterNaam.AutoSize = true;
            this.LabelKandidaatAchterNaam.Location = new System.Drawing.Point(73, 94);
            this.LabelKandidaatAchterNaam.Name = "LabelKandidaatAchterNaam";
            this.LabelKandidaatAchterNaam.Size = new System.Drawing.Size(35, 13);
            this.LabelKandidaatAchterNaam.TabIndex = 54;
            this.LabelKandidaatAchterNaam.Text = "label2";
            // 
            // uKandidaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LabelKandidaatAchterNaam);
            this.Controls.Add(this.LabelKandidaatNaam);
            this.Controls.Add(this.labelNummerKandidaat);
            this.Controls.Add(this.buttonKandidaat);
            this.Name = "uKandidaten";
            this.Size = new System.Drawing.Size(304, 379);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKandidaat;
        public System.Windows.Forms.Label labelNummerKandidaat;
        public System.Windows.Forms.Label LabelKandidaatNaam;
        public System.Windows.Forms.Label LabelKandidaatAchterNaam;
    }
}
