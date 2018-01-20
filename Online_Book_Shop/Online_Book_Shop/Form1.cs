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
    public partial class Home : Form
    {
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        public Home()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nickName = this.txtNickName.Text;
            string password = this.txtPassword.Text;
            int logined = db.Users.Where(u => u.user_nick_name == nickName).Count();

            if (logined > 0)
            {
                User loginedUser = db.Users.Where(u => u.user_nick_name == nickName).First();
                if (loginedUser.user_status == 0)
                {
                    if(loginedUser.user_password == this.txtPassword.Text && loginedUser.user_nick_name == this.txtNickName.Text)
                    {
                        AdminPanelForm admn = new AdminPanelForm();
                        admn.ShowDialog();
                    }
                }
                else
                {
                    string path = @"C:\Users\Sakit\source\repos\Online_Book_Shop\Online_Book_Shop\Uploads\";

                    BookShopForm frm = new BookShopForm();
                    frm.pctUser.Image = Image.FromFile(path + loginedUser.user_photo);
                    frm.lblUser.Text = loginedUser.user_name + " " + loginedUser.user_surname;
                    BookInfoForm.UserId = loginedUser.Id;
                    frm.ShowDialog();
                }
            }
            else
            {
                this.lblError.Text = "bele istifadechi yoxdu qeydiyyatdan kechin";
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm rgst = new RegisterForm();
            rgst.ShowDialog();
        }
    }
}
