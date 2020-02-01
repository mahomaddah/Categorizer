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
            this.kumeKomutLbl = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.checkedListBoxSonuc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // kumeKomutLbl
            // 
            this.kumeKomutLbl.AutoSize = true;
            this.kumeKomutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F);
            this.kumeKomutLbl.Location = new System.Drawing.Point(223, 22);
            this.kumeKomutLbl.Name = "kumeKomutLbl";
            this.kumeKomutLbl.Size = new System.Drawing.Size(120, 32);
            this.kumeKomutLbl.TabIndex = 16;
            this.kumeKomutLbl.Text = "AnBnC :";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(24, 650);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(182, 23);
            this.backbtn.TabIndex = 15;
            this.backbtn.Text = "Geri Dön ...";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // checkedListBoxSonuc
            // 
            this.checkedListBoxSonuc.Font = new System.Drawing.Font("Microsoft Tai Le", 20.5F);
            this.checkedListBoxSonuc.FormattingEnabled = true;
            this.checkedListBoxSonuc.Items.AddRange(new object[] {
            "Pnömoni",
            "Akciğer absesi",
            "Bronşektazi",
            "Kronik bronşit",
            "Tüberküloz",
            "Bronkojenik karsinom",
            "Kistik fibrozis"});
            this.checkedListBoxSonuc.Location = new System.Drawing.Point(226, 77);
            this.checkedListBoxSonuc.Name = "checkedListBoxSonuc";
            this.checkedListBoxSonuc.Size = new System.Drawing.Size(1082, 596);
            this.checkedListBoxSonuc.TabIndex = 14;
            // 
            // Sonuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 722);
            this.Controls.Add(this.kumeKomutLbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.checkedListBoxSonuc);
            this.Name = "Sonuc";
            this.Text = "Sonuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kumeKomutLbl;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.CheckedListBox checkedListBoxSonuc;
    }
}