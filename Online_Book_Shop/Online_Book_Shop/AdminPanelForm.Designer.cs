namespace Online_Book_Shop
{
    partial class AdminPanelForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnAddLang = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.onlineBookShopDataSet = new Online_Book_Shop.OnlineBookShopDataSet();
            this.languageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languageTableAdapter = new Online_Book_Shop.OnlineBookShopDataSetTableAdapters.LanguageTableAdapter();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookphotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineBookShopDataSet1 = new Online_Book_Shop.OnlineBookShopDataSet1();
            this.booksTableAdapter = new Online_Book_Shop.OnlineBookShopDataSet1TableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBookShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBookShopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(156, 34);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(141, 23);
            this.btnAddAuthor.TabIndex = 0;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(303, 34);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(141, 23);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddLang
            // 
            this.btnAddLang.Location = new System.Drawing.Point(450, 34);
            this.btnAddLang.Name = "btnAddLang";
            this.btnAddLang.Size = new System.Drawing.Size(141, 23);
            this.btnAddLang.TabIndex = 2;
            this.btnAddLang.Text = "Add Language";
            this.btnAddLang.UseVisualStyleBackColor = true;
            this.btnAddLang.Click += new System.EventHandler(this.btnAddLang_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(597, 34);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(141, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // onlineBookShopDataSet
            // 
            this.onlineBookShopDataSet.DataSetName = "OnlineBookShopDataSet";
            this.onlineBookShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // languageBindingSource
            // 
            this.languageBindingSource.DataMember = "Language";
            this.languageBindingSource.DataSource = this.onlineBookShopDataSet;
            // 
            // languageTableAdapter
            // 
            this.languageTableAdapter.ClearBeforeFill = true;
            // 
            // dgwBooks
            // 
            this.dgwBooks.AutoGenerateColumns = false;
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.authoridDataGridViewTextBoxColumn,
            this.bookpriceDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.langidDataGridViewTextBoxColumn,
            this.bookamountDataGridViewTextBoxColumn,
            this.bookinfoDataGridViewTextBoxColumn,
            this.bookphotoDataGridViewTextBoxColumn});
            this.dgwBooks.DataSource = this.booksBindingSource;
            this.dgwBooks.Location = new System.Drawing.Point(12, 77);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.Size = new System.Drawing.Size(871, 283);
            this.dgwBooks.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "book_name";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // authoridDataGridViewTextBoxColumn
            // 
            this.authoridDataGridViewTextBoxColumn.DataPropertyName = "author_id";
            this.authoridDataGridViewTextBoxColumn.HeaderText = "author_id";
            this.authoridDataGridViewTextBoxColumn.Name = "authoridDataGridViewTextBoxColumn";
            // 
            // bookpriceDataGridViewTextBoxColumn
            // 
            this.bookpriceDataGridViewTextBoxColumn.DataPropertyName = "book_price";
            this.bookpriceDataGridViewTextBoxColumn.HeaderText = "book_price";
            this.bookpriceDataGridViewTextBoxColumn.Name = "bookpriceDataGridViewTextBoxColumn";
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            // 
            // langidDataGridViewTextBoxColumn
            // 
            this.langidDataGridViewTextBoxColumn.DataPropertyName = "lang_id";
            this.langidDataGridViewTextBoxColumn.HeaderText = "lang_id";
            this.langidDataGridViewTextBoxColumn.Name = "langidDataGridViewTextBoxColumn";
            // 
            // bookamountDataGridViewTextBoxColumn
            // 
            this.bookamountDataGridViewTextBoxColumn.DataPropertyName = "book_amount";
            this.bookamountDataGridViewTextBoxColumn.HeaderText = "book_amount";
            this.bookamountDataGridViewTextBoxColumn.Name = "bookamountDataGridViewTextBoxColumn";
            // 
            // bookinfoDataGridViewTextBoxColumn
            // 
            this.bookinfoDataGridViewTextBoxColumn.DataPropertyName = "book_info";
            this.bookinfoDataGridViewTextBoxColumn.HeaderText = "book_info";
            this.bookinfoDataGridViewTextBoxColumn.Name = "bookinfoDataGridViewTextBoxColumn";
            // 
            // bookphotoDataGridViewTextBoxColumn
            // 
            this.bookphotoDataGridViewTextBoxColumn.DataPropertyName = "book_photo";
            this.bookphotoDataGridViewTextBoxColumn.HeaderText = "book_photo";
            this.bookphotoDataGridViewTextBoxColumn.Name = "bookphotoDataGridViewTextBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.onlineBookShopDataSet1;
            // 
            // onlineBookShopDataSet1
            // 
            this.onlineBookShopDataSet1.DataSetName = "OnlineBookShopDataSet1";
            this.onlineBookShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 372);
            this.Controls.Add(this.dgwBooks);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddLang);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnAddAuthor);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onlineBookShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineBookShopDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddLang;
        private System.Windows.Forms.Button btnAddBook;
        private OnlineBookShopDataSet onlineBookShopDataSet;
        private System.Windows.Forms.BindingSource languageBindingSource;
        private OnlineBookShopDataSetTableAdapters.LanguageTableAdapter languageTableAdapter;
        private System.Windows.Forms.DataGridView dgwBooks;
        private OnlineBookShopDataSet1 onlineBookShopDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private OnlineBookShopDataSet1TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn langidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookphotoDataGridViewTextBoxColumn;
    }
}