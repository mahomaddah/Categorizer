namespace Categorizer
{
    partial class Sonuc
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
            this.labelSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBoxSonuc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.BackColor = System.Drawing.Color.SpringGreen;
            this.labelSonuc.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelSonuc.ForeColor = System.Drawing.Color.Khaki;
            this.labelSonuc.Location = new System.Drawing.Point(283, 47);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(115, 34);
            this.labelSonuc.TabIndex = 34;
            this.labelSonuc.Text = "AnBnC ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(42, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Geri Dön...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBoxSonuc
            // 
            this.checkedListBoxSonuc.BackColor = System.Drawing.Color.DarkGray;
            this.checkedListBoxSonuc.Font = new System.Drawing.Font("Microsoft Tai Le", 20.5F);
            this.checkedListBoxSonuc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkedListBoxSonuc.FormattingEnabled = true;
            this.checkedListBoxSonuc.Items.AddRange(new object[] {
            "Akut öksürük nedenleri",
            "kut öksürük nedenleri",
            "Kronik öksürük nedenleri",
            "Nonprodüktif öksürük nedenleri",
            "Prodüktif öksürük nedenleri"});
            this.checkedListBoxSonuc.Location = new System.Drawing.Point(286, 87);
            this.checkedListBoxSonuc.Name = "checkedListBoxSonuc";
            this.checkedListBoxSonuc.Size = new System.Drawing.Size(1082, 596);
            this.checkedListBoxSonuc.TabIndex = 32;
            // 
            // Sonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Categorizer.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1410, 731);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxSonuc);
            this.Name = "Sonuc";
            this.Text = "Sonuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBoxSonuc;
    }
}