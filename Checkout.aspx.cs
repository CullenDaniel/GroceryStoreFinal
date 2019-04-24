using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroceryStoreFinal
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (lboxCart.Items.Count != 0)
            {
                lblPlacedOrder.Text = "Thank you for placing your order. Your order number is:";
            }
        }
    }
}