using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroceryStoreFinal
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (lboxItemsSold.Items.Count != 0)
            {
                lboxItemsSelected.Items.Add(lboxItemsSold.SelectedItem.Value);
                lboxItemsSold.Items.Remove(lboxItemsSold.SelectedItem.Value);
            }
            if (lboxItemsSold.Items.Count == 0)
            {
                Response.Write("It is already empty.");
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            if (lboxItemsSold.Items.Count != 0)
            {
                lboxItemsSold.Items.Add(lboxItemsSelected.SelectedItem.Value);
                lboxItemsSelected.Items.Remove(lboxItemsSelected.SelectedItem.Value);
            }
            if (lboxItemsSelected.Items.Count == 0)
            {
                Response.Write("It is already empty.");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            while (lboxItemsSelected.Items.Count != 0)
            {
                lboxItemsSold.Items.Add(lboxItemsSelected.Items[0]);
                lboxItemsSelected.Items.Remove(lboxItemsSelected.Items[0]);
            }
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            if (lboxItemsSelected.Items.Count != 0)
            {
                Response.Redirect("Checkout.aspx");
            }
        }
    }
}