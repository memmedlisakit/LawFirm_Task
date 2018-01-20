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
    public partial class BookInfoForm : Form
    {
        public static int UserId { get; set; }
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        public BookInfoForm()
        {
            InitializeComponent();
        }

        private void btnBuyBook_Click(object sender, EventArgs e)
        {
            Book bk = db.Books.Find(BookShopForm.bookId);
            if (bk.book_amount > 0)
            {
                bk.book_amount -= 1;
                db.SaveChanges();
                User custom = db.Users.Find(UserId);
                MessageBox.Show(custom.user_name + "   " + bk.book_name+" kitabi aldiniz.");
            }
            else
            {
                MessageBox.Show("Bu kitabdan basada qalamayib");
            }
        }
    }
}
