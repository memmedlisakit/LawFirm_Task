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
    public partial class CategoryForm : Form
    {
        OnlineBookShopEntities db = new OnlineBookShopEntities();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category ctg = new Category();
            ctg.category_name = this.txtCategory.Text;
            db.Categories.Add(ctg);
            db.SaveChanges();
            this.clearAll();

        }

        private void clearAll()
        {
            MessageBox.Show("Elave edildi");
            this.txtCategory.Text = "";
        }
    }
}
