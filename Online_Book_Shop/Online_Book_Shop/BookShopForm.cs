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
    public partial class BookShopForm : Form
    {
        public static int bookId { get; set; }
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        string path = @"C:\Users\Sakit\source\repos\Online_Book_Shop\Online_Book_Shop\Uploads\";
        
        


        public BookShopForm()
        {
            InitializeComponent();
            this.fillPhoto();
        }

        private void fillPhoto()
        {
            List<Book> books = db.Books.ToList();

            for(int  i =0; i < books.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Name = books[i].Id.ToString();
                pb.Width = 200;
                pb.Height = 250;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = Image.FromFile(path + books[i].book_photo);
                pb.Click += new EventHandler(bookInfo);
                this.flpBookPhoto.Controls.Add(pb);
            }
        }

        private void bookInfo(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            bookId = Convert.ToInt32(pb.Name);
            Book bk = db.Books.Find(bookId);
            BookInfoForm book = new BookInfoForm();
            book.lblBookName.Text = bk.book_name;
            book.lblAuthorName.Text = bk.Author.author_name;
            book.lblBookAmount.Text = bk.book_amount.ToString();
            book.lblBookCategory.Text = bk.Category.category_name;
            book.txtBookInfo.Text = bk.book_info;
            book.lblBookLang.Text = bk.Language.lang_name;
            book.lblBookPrice.Text = bk.book_price + " AZN";
            book.pctBook.Image = Image.FromFile(path + bk.book_photo);
            book.ShowDialog();
        }
    }
}
