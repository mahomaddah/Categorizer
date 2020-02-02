namespace Categorizer
{
    partial class Home
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
            this.DelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.ListeleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Sonuc = new System.Windows.Forms.Button();
            this.checkedListBoxSets = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(42, 190);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(182, 23);
            this.DelBtn.TabIndex = 31;
            this.DelBtn.Text = "Küme Sil";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(42, 89);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(182, 23);
            this.addBtn.TabIndex = 30;
            this.addBtn.Text = "Küme Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.Location = new System.Drawing.Point(42, 139);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(182, 23);
            this.ListeleBtn.TabIndex = 29;
            this.ListeleBtn.Text = "Küme Listele";
            this.ListeleBtn.UseVisualStyleBackColor = true;
            this.ListeleBtn.Click += new System.EventHandler(this.ListeleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "SET :";
            // 
            // Sonuc
            // 
            this.Sonuc.Location = new System.Drawing.Point(42, 662);
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.Size = new System.Drawing.Size(182, 23);
            this.Sonuc.TabIndex = 27;
            this.Sonuc.Text = "Kesişim Göster";
            this.Sonuc.UseVisualStyleBackColor = true;
            this.Sonuc.Click += new System.EventHandler(this.Sonuc_Click);
            // 
            // checkedListBoxSets
            // 
            this.checkedListBoxSets.Font = new System.Drawing.Font("Microsoft Tai Le", 20.5F);
            this.checkedListBoxSets.FormattingEnabled = true;
            this.checkedListBoxSets.Items.AddRange(new object[] {
            "Akut öksürük nedenleri",
            "kut öksürük nedenleri",
            "Kronik öksürük nedenleri",
            "Nonprodüktif öksürük nedenleri",
            "Prodüktif öksürük nedenleri"});
            this.checkedListBoxSets.Location = new System.Drawing.Point(286, 89);
            this.checkedListBoxSets.Name = "checkedListBoxSets";
            this.checkedListBoxSets.Size = new System.Drawing.Size(1082, 596);
            this.checkedListBoxSets.TabIndex = 26;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 734);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ListeleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sonuc);
            this.Controls.Add(this.checkedListBoxSets);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button ListeleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sonuc;
        private System.Windows.Forms.CheckedListBox checkedListBoxSets;
    }
}