using Kutuphane.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kutuphane
{
    public partial class Books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            using (BookContext context = new BookContext())
            {
                datagrid.DataSource = context.Books.Select(b => new { b.ID, b.Name, b.Author, b.Link, ReadName=b.Read.Name, CategoryName = b.Category.Name }).ToList(); ;
                datagrid.DataBind();
            }
        }

        protected void datagrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}