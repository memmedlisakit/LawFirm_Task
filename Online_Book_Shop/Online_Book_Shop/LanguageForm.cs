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
    public partial class LanguageForm : Form
    {
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Language lang = new Language();
            lang.lang_name = this.txtLang.Text;
            db.Languages.Add(lang);
            db.SaveChanges();
            this.clearAll();
        }
        private void clearAll()
        {
            MessageBox.Show("Elave edildi");
            this.txtLang.Text = "";
        }
    }
}
