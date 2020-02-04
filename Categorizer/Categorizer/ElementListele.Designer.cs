namespace Categorizer
{
    partial class ElementListele
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
            this.isimDegisBtn = new System.Windows.Forms.Button();
            this.KumeIsmilbl = new System.Windows.Forms.Label();
            this.GeriDon = new System.Windows.Forms.Button();
            this.checkedListBoxElements = new System.Windows.Forms.CheckedListBox();
            this.ElemanIsimTexbox = new System.Windows.Forms.TextBox();
            this.KumeisimTxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DelBtn.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            this.DelBtn.Location = new System.Drawing.Point(39, 605);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(186, 23);
            this.DelBtn.TabIndex = 37;
            this.DelBtn.Text = "Eleman Sil";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addBtn.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            this.addBtn.Location = new System.Drawing.Point(231, 89);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(126, 23);
            this.addBtn.TabIndex = 36;
            this.addBtn.Text = "Eleman Ekle";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // isimDegisBtn
            // 
            this.isimDegisBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.isimDegisBtn.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            this.isimDegisBtn.Location = new System.Drawing.Point(231, 152);
            this.isimDegisBtn.Name = "isimDegisBtn";
            this.isimDegisBtn.Size = new System.Drawing.Size(126, 23);
            this.isimDegisBtn.TabIndex = 35;
            this.isimDegisBtn.Text = "Küme İsmini Değiştir";
            this.isimDegisBtn.UseVisualStyleBackColor = false;
            this.isimDegisBtn.Click += new System.EventHandler(this.isimDegisBtn_Click);
            // 
            // KumeIsmilbl
            // 
            this.KumeIsmilbl.AutoSize = true;
            this.KumeIsmilbl.BackColor = System.Drawing.Color.DarkRed;
            this.KumeIsmilbl.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.KumeIsmilbl.ForeColor = System.Drawing.Color.HotPink;
            this.KumeIsmilbl.Location = new System.Drawing.Point(392, 36);
            this.KumeIsmilbl.Name = "KumeIsmilbl";
            this.KumeIsmilbl.Size = new System.Drawing.Size(93, 34);
            this.KumeIsmilbl.TabIndex = 34;
            this.KumeIsmilbl.Text = "SET :";
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GeriDon.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold);
            this.GeriDon.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GeriDon.Location = new System.Drawing.Point(39, 656);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(186, 23);
            this.GeriDon.TabIndex = 33;
            this.GeriDon.Text = "Geri Dön....";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // checkedListBoxElements
            // 
            this.checkedListBoxElements.BackColor = System.Drawing.Color.SkyBlue;
            this.checkedListBoxElements.Font = new System.Drawing.Font("Microsoft Tai Le", 20.5F);
            this.checkedListBoxElements.ForeColor = System.Drawing.Color.DarkMagenta;
            this.checkedListBoxElements.FormattingEnabled = true;
            this.checkedListBoxElements.Items.AddRange(new object[] {
            "Akut öksürük nedenleri",
            "kut öksürük nedenleri",
            "Kronik öksürük nedenleri",
            "Nonprodüktif öksürük nedenleri",
            "Prodüktif öksürük nedenleri"});
            this.checkedListBoxElements.Location = new System.Drawing.Point(398, 92);
            this.checkedListBoxElements.Name = "checkedListBoxElements";
            this.checkedListBoxElements.Size = new System.Drawing.Size(1058, 596);
            this.checkedListBoxElements.TabIndex = 32;
            // 
            // ElemanIsimTexbox
            // 
            this.ElemanIsimTexbox.Location = new System.Drawing.Point(39, 92);
            this.ElemanIsimTexbox.Name = "ElemanIsimTexbox";
            this.ElemanIsimTexbox.Size = new System.Drawing.Size(186, 20);
            this.ElemanIsimTexbox.TabIndex = 38;
            this.ElemanIsimTexbox.Text = "Eleman ismi giriniz....";
            // 
            // KumeisimTxtbx
            // 
            this.KumeisimTxtbx.Location = new System.Drawing.Point(39, 152);
            this.KumeisimTxtbx.Name = "KumeisimTxtbx";
            this.KumeisimTxtbx.Size = new System.Drawing.Size(186, 20);
            this.KumeisimTxtbx.TabIndex = 39;
            this.KumeisimTxtbx.Text = "Küme ismi...";
            // 
            // ElementListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Categorizer.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(1505, 722);
            this.Controls.Add(this.KumeisimTxtbx);
            this.Controls.Add(this.ElemanIsimTexbox);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.isimDegisBtn);
            this.Controls.Add(this.KumeIsmilbl);
            this.Controls.Add(this.GeriDon);
            this.Controls.Add(this.checkedListBoxElements);
            this.Name = "ElementListele";
            this.Text = "ElementListele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button isimDegisBtn;
        private System.Windows.Forms.Label KumeIsmilbl;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.CheckedListBox checkedListBoxElements;
        private System.Windows.Forms.TextBox ElemanIsimTexbox;
        private System.Windows.Forms.TextBox KumeisimTxtbx;
    }
}