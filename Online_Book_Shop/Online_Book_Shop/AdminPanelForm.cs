using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Shop
{
    public partial class AdminPanelForm : Form
    {
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineBookShopDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.onlineBookShopDataSet1.Books);
            // TODO: This line of code loads data into the 'onlineBookShopDataSet.Language' table. You can move, or remove it, as needed.
            this.languageTableAdapter.Fill(this.onlineBookShopDataSet.Language);

            List<Book> books = db.Books.ToList();
            foreach (Book item in books)
            {

            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm frm = new AddBookForm();
            frm.ShowDialog();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm aut = new AddAuthorForm();
            aut.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.ShowDialog();
        }

        private void btnAddLang_Click(object sender, EventArgs e)
        {
            LanguageForm frm = new LanguageForm();
            frm.ShowDialog();
        }
    }
}
