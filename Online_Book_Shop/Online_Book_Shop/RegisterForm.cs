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
    public partial class RegisterForm : Form
    {
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        //step first
        OpenFileDialog file = new OpenFileDialog();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // step Second
            file.ShowDialog();
            this.pctRegister.Image = Image.FromFile(file.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //step third
            string image = DateTime.Now.ToString("yyyyMMddHHssmm") + file.SafeFileName;


            User usr = new User();
            usr.user_nick_name = this.txtNickName.Text;
            usr.user_name = this.txtUserName.Text;
            usr.user_surname = this.txtSurname.Text;
            usr.user_password = this.txtPassword.Text;
            usr.user_email = this.txtEmail.Text;
            usr.user_tel = this.txtTel.Text;
            usr.user_photo = image;
            usr.user_status = 1;
            db.Users.Add(usr);
            db.SaveChanges();


           



        //file upload
            WebClient webclient = new WebClient();
            string path = @"C:\Users\Sakit\source\repos\Online_Book_Shop\Online_Book_Shop\Uploads\" + image;
            webclient.DownloadFile(file.FileName, path);
























            MessageBox.Show("Siz ugurla qeydiyyatdan kecdiniz");
            this.Close();
        }

       
    }
}
