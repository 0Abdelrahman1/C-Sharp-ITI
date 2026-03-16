using Microsoft.EntityFrameworkCore;
using NorthWindAPP.Context;

namespace NorthWindAPP
{
    public partial class frmProductsGrdView : Form
    {
        public frmProductsGrdView()
        {
            InitializeComponent();

        }
        NorthwindContext Context = new();
        private void frmProductsGrdView_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) => Context?.Dispose();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Load All products from DB into Local
            Context.Products.Load();
            //Bind to Local Copy 
            grdViewPrds.DataSource = Context.Products.Local.ToBindingList();

            #region Wrong way to Bind
            //var Prds = (from P in Context.Products
            //           where P.UnitsInStock > 0
            //           select P).ToList();

            //PrdBindingSource = new BindingSource(Prds, "");

            //grdViewPrds.DataSource = PrdBindingSource;

            //grdViewPrds.DataSource = Context.Products; 
            #endregion
        }
        BindingSource PrdBindingSource;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.grdViewPrds.EndEdit();
            Context.SaveChanges();
        }
    }
}
