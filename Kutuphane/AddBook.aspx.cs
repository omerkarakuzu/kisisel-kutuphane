using Kutuphane.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kutuphane
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                using (BookContext context = new BookContext())
                {
                    var categories = context.Categories.ToList();
                    var reads = context.Reads.ToList();

                    Category.DataSource = categories;
                    Category.DataValueField = "ID";
                    Category.DataTextField = "Name";
                    Category.SelectedIndex = 0;
                   
                    Read.DataSource = reads;
                    Read.DataValueField = "ID";
                    Read.DataTextField = "Name";
                    Read.SelectedIndex = 0;
                    Read.DataBind();
                    Category.DataBind();
                }
            }

        }

        protected void CreateBook_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Name = Name.Text,
                CategoryID = Int32.Parse(Category.SelectedValue),
                ReadID = Int32.Parse(Read.SelectedValue),
                Author = Author.Text,
                Link = Link.Text
            };
            using (BookContext context = new BookContext())
            {
                context.Books.Add(book);
                context.SaveChanges();
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Başarıyla Eklendi.')", true);
            }
            Name.Text = "";
            Author.Text = "";
            Link.Text = "";
            Category.SelectedValue = 0.ToString();
            Read.SelectedValue = 0.ToString();
            
        }
    }
}