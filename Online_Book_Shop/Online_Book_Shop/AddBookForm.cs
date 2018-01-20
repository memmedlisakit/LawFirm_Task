using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Shop
{
    public partial class AddBookForm : Form
    {
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        OpenFileDialog file = new OpenFileDialog();
        public AddBookForm()
        {
            InitializeComponent();
            this.clearAll();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            this.pctBook.Image = Image.FromFile(file.FileName);
        }


        private void fillCmbAuthor()
        {
            this.cmbBAuthor.Items.Clear();
            List<Author> authors = db.Authors.ToList();
            foreach (Author item in authors)
            {
                this.cmbBAuthor.Items.Add(item.author_name);
            } 
        }
        
        private void fillCmbLang()
        {
            this.cmbBLanguage.Items.Clear();
            List<Language> langs = db.Languages.ToList();
            foreach (Language item in langs)
            {
                this.cmbBLanguage.Items.Add(item.lang_name);
            }
        }

        private void fillCmbCategory()
        {
            this.cmbBCategory.Items.Clear();
            List<Category> categories = db.Categories.ToList();
            foreach (Category item in categories)
            {
                this.cmbBCategory.Items.Add(item.category_name);
            }
        }

        private void clearAll()
        {
            this.txtBAmount.Text = "";
            this.txtBInfo.Text = "";
            this.txtBName.Text = "";
            this.txtBPrice.Text = "";
            this.cmbBAuthor.Text = "";
            this.cmbBCategory.Text = "";
            this.cmbBLanguage.Text = "";
            fillCmbAuthor();
            fillCmbLang();
            fillCmbCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string image = DateTime.Now.ToString("yyyyMMddHHssmm") + file.SafeFileName;



            int langId = db.Languages.Where(l => l.lang_name == this.cmbBLanguage.Text).First().Id;
            int authorId = db.Authors.Where(a => a.author_name == this.cmbBAuthor.Text).First().Id;
            int categoryId = db.Categories.Where(c => c.category_name == this.cmbBCategory.Text).First().Id;
            Book bk = new Book();
            bk.book_name = this.txtBName.Text;
            bk.book_price = Convert.ToDouble(this.txtBPrice.Text);
            bk.book_amount = Convert.ToInt32(this.txtBAmount.Text);
            bk.book_info = this.txtBInfo.Text;
            bk.book_photo = image;
            bk.author_id = authorId;
            bk.lang_id = langId;
            bk.category_id = categoryId;
            db.Books.Add(bk);
            db.SaveChanges();




            WebClient webclient = new WebClient();
            string path = @"C:\Users\Sakit\source\repos\Online_Book_Shop\Online_Book_Shop\Uploads\" + image;
            webclient.DownloadFile(file.FileName, path);


            MessageBox.Show("Elave edildi");
            this.clearAll();

        }
    }
}
