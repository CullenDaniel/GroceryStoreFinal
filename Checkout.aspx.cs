using System;
using System.Collections;
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

            lblDisplayOrder.Text = Session["test"].ToString();

            

            /*
             
            //String aaa = Session["test"].ToString();
            lblPlacedOrder.Text = Session["test"].ToString();
            ArrayList cartItems = new ArrayList();
            String[] intArray1 = new string[100];
            //lboxCart.Items.Add() = Session["test"].ToString();
            String oldCart = Session["test"].ToString();
            oldCart.CopyTo(intArray1[0], oldCart.IndexOf('*'));
            lboxCart.Items.Add(intArray1[0]);
            //List<string> first = new List<string> { oldCart.Split('*').CopyTo(cartItems, oldCart.IndexOf('*')};
            */

        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            /*
            if (lboxCart.Items.Count != 0)
            {
                lblPlacedOrder.Text = "Thank you for placing your order. Your order number is:";
            }
            */
        }
    }
}