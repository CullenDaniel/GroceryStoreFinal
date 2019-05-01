using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroceryStoreFinal
{
    public partial class Checkout : System.Web.UI.Page
    {
        private SqlCommand comm;
        protected void Page_Load(object sender, EventArgs e)
        {

            lblDisplayOrder.Text = Session["test"].ToString();

        }
        private void OpenConnection()
        {
            System.Configuration.ConnectionStringSettings strConn; //createa a connection string
            strConn = ReadConnectionString(); //read from web.config
                                              // Console.WriteLine(strConn.ConnectionString);

            System.Data.SqlClient.SqlConnection conn;
            conn = new System.Data.SqlClient.SqlConnection(strConn.ConnectionString); //getting read yto access database
            Session.Add("ConnectionObject", conn);
            // This could go wrong in so many ways...
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                // Miserable error handling...
                Response.Write(ex.Message);
            }
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            String tmp;


            //      If we got this far, the connection attempt worked in the Page_Load event handler.
            //      Note that the connection becomes part of the SQL command in the following statement:
            String tmpQuery = "INSERT INTO tOrder(LoyaltyID, DateTimeCreated, StoreID, OrderStatusID) VALUES("+ Session["LoyaltyNumber"]+", GETDATE()" + Session["info"]+ ", 1);";

            //DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff")


            System.Data.SqlClient.SqlConnection conn;
            // Grab the connection object, already open, from the Session object
            conn = (System.Data.SqlClient.SqlConnection)Session["ConnectionObject"];
            OpenConnection();
            comm = new SqlCommand(tmpQuery, conn);
            comm.BeginExecuteNonQuery();
            //lDataReader reader;
            //reader = comm.ExecuteReader();      // Se also ExecuteScalar and ExecuteNonQuery
            lblPlacedOrder.Text = "Thank you for placing your order. Your order number is:";
            conn.Close();
            /*
            if (lboxCart.Items.Count != 0)
            {
               
            }
            */
        }
        private System.Configuration.ConnectionStringSettings ReadConnectionString()
        {
            String strPath;
            strPath = HttpContext.Current.Request.ApplicationPath + "/web.config";
            System.Configuration.Configuration rootWebConfig =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(strPath);

            System.Configuration.ConnectionStringSettings connString = null;
            if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
            {
                connString = rootWebConfig.ConnectionStrings.ConnectionStrings["lynch2jwConnectionString"];
            }
            return connString;
        }
    }
}