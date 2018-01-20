namespace Online_Book_Shop
{
    partial class AddBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBAuthor = new System.Windows.Forms.ComboBox();
            this.pctBook = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBLanguage = new System.Windows.Forms.ComboBox();
            this.txtBPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name : ";
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(108, 30);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(100, 20);
            this.txtBName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(308, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbBAuthor
            // 
            this.cmbBAuthor.FormattingEnabled = true;
            this.cmbBAuthor.Location = new System.Drawing.Point(332, 29);
            this.cmbBAuthor.Name = "cmbBAuthor";
            this.cmbBAuthor.Size = new System.Drawing.Size(121, 21);
            this.cmbBAuthor.TabIndex = 3;
            // 
            // pctBook
            // 
            this.pctBook.Location = new System.Drawing.Point(481, 30);
            this.pctBook.Name = "pctBook";
            this.pctBook.Size = new System.Drawing.Size(139, 185);
            this.pctBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBook.TabIndex = 4;
            this.pctBook.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(545, 234);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Author: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category :";
            // 
            // cmbBCategory
            // 
            this.cmbBCategory.FormattingEnabled = true;
            this.cmbBCategory.Location = new System.Drawing.Point(332, 75);
            this.cmbBCategory.Name = "cmbBCategory";
            this.cmbBCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbBCategory.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Language : ";
            // 
            // cmbBLanguage
            // 
            this.cmbBLanguage.FormattingEnabled = true;
            this.cmbBLanguage.Location = new System.Drawing.Point(332, 122);
            this.cmbBLanguage.Name = "cmbBLanguage";
            this.cmbBLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbBLanguage.TabIndex = 9;
            // 
            // txtBPrice
            // 
            this.txtBPrice.Location = new System.Drawing.Point(108, 76);
            this.txtBPrice.Name = "txtBPrice";
            this.txtBPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBPrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Book Price : ";
            // 
            // txtBAmount
            // 
            this.txtBAmount.Location = new System.Drawing.Point(108, 123);
            this.txtBAmount.Name = "txtBAmount";
            this.txtBAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBAmount.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Book Amount : ";
            // 
            // txtBInfo
            // 
            this.txtBInfo.Location = new System.Drawing.Point(65, 175);
            this.txtBInfo.Multiline = true;
            this.txtBInfo.Name = "txtBInfo";
            this.txtBInfo.Size = new System.Drawing.Size(388, 129);
            this.txtBInfo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Info : ";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 388);
            this.Controls.Add(this.txtBInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBLanguage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pctBook);
            this.Controls.Add(this.cmbBAuthor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.Tag = "";
            this.Text = "Book Form";
            ((System.ComponentModel.ISupportInitialize)(this.pctBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbBAuthor;
        private System.Windows.Forms.PictureBox pctBook;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBLanguage;
        private System.Windows.Forms.TextBox txtBPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBInfo;
        private System.Windows.Forms.Label label7;
    }
}