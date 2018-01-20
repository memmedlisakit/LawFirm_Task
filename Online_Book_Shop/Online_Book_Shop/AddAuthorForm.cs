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
    public partial class AddAuthorForm : Form
    {
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        OpenFileDialog file = new OpenFileDialog();
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            file.ShowDialog();
            this.pctAuthor.Image = Image.FromFile(file.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string image = DateTime.Now.ToString("yyyyMMddHHssmm") + file.SafeFileName;
 
            Author aut = new Author();
            aut.author_name = this.txtAuthorName.Text;
            aut.author_info = this.txtAuthorInfo.Text;
            aut.author_photo = image;
            db.Authors.Add(aut);
            db.SaveChanges();




            WebClient webclient = new WebClient();
            string path = @"C:\Users\Sakit\source\repos\Online_Book_Shop\Online_Book_Shop\Uploads\" + image;
            webclient.DownloadFile(file.FileName, path);

            this.Close();
        }
    }
}
