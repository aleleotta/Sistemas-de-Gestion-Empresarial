using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld_WebForms
{
    /// <summary>
    /// Elements from main page
    /// </summary>
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNombre.Text)) {
                lblSaludo.ForeColor = System.Drawing.Color.Black;
                lblSaludo.Font.Bold = false;
                lblSaludo.Text = "Hello " + txtNombre.Text + "!";
                lblSaludo.Visible = true;
            } else
            {
                lblSaludo.Text = "The name field cannot be empty!";
                lblSaludo.ForeColor = System.Drawing.Color.Red;
                lblSaludo.Font.Bold = true;
                lblSaludo.Visible = true;
            }
        }

    }
}