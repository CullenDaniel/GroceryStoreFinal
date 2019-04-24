using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroceryStoreFinal
{
    public partial class _default : System.Web.UI.Page
    {
        private SqlCommand comm;

        /**
         *  Page Load event handler
         * 
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // We will open the connection one time and leave it open.
                OpenConnection();
            }
            
        }
        protected void btnGo_Click(object sender, EventArgs e)
        {
            
            CheckLoyalty();
            String oldloyalty = "";
            oldloyalty = tboxLoyalty.Text.ToString();
            if (oldloyalty != tboxLoyalty.Text.ToString())
            {
                lblLoyaltyError.Text = "";
            }
            if (lblLoyaltyError.Text=="" && lboxStore.SelectedIndex != -1)
            {
                Response.Redirect("ShoppingCart.aspx"); //takes the user to the next web page
            }
            else
            {
                /*
                oldloyalty = tboxLoyalty.Text.ToString();
                if (oldloyalty != tboxLoyalty.Text.ToString())
                {
                    lblLoyaltyError.Text = "";
                }
                */

            }
            

            //if (loyaltynumbercheck)
/*
            if (ddlStore.SelectedIndex.Equals(-1))
            {
                Response.Redirect("ShoppingCart.aspx"); //takes the user to the next web page
            }
            */
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {

            LoadListBox();
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

        private void LoadListBox()
        {
            String tmp;


            //      If we got this far, the connection attempt worked in the Page_Load event handler.
            //      Note that the connection becomes part of the SQL command in the following statement:
            String tmpQuery = "Select Distinct Store, Address1 from tStore inner join tStoreHistory on tStore.StoreID = tStoreHistory.StoreID where StoreStatusID = '1' or StoreStatusID = '11' or StoreStatusID = '2'";





            System.Data.SqlClient.SqlConnection conn;
            // Grab the connection object, already open, from the Session object
            conn = (System.Data.SqlClient.SqlConnection)Session["ConnectionObject"];
            comm = new SqlCommand(tmpQuery, conn);
            SqlDataReader reader;
            reader = comm.ExecuteReader();      // Se also ExecuteScalar and ExecuteNonQuery

            // Now we have our data in the reader object

            if (reader.HasRows)
            {       // probably don't need this. 
                while (reader.Read())
                {
                    if (reader.GetFieldType(0).ToString().Equals("System.String") || reader.GetFieldType(1).ToString().Equals("System.Int32")) //can just about steal this line for line
                    {
                        tmp = reader.GetString(0) + ": " + reader.GetString(1); //changed so name appears before address
                    }
                    else
                    {
                        tmp = reader.GetString(0) + ": " + reader.GetString(1);      // Column 0 in the results set. Refer back to the construction of the query.
                    }
                    System.Console.WriteLine(tmp);
                    lboxStore.Items.Add(tmp);


                }


            }
            // This could also fail. Probably not fatal. 
            try { reader.Close(); }
            catch (Exception ex) { }

            // You can leave it open if you're judicious about it.
            //conn.Close();
        }
        private void CheckLoyalty()
        {
            String tmp;
            String tmpQuery = "Select * from tLoyalty where LoyaltyNumber ='" + tboxLoyalty.Text.ToString() + "'";
            Boolean containsLoyalty = false;

            System.Data.SqlClient.SqlConnection conn;
            // Grab the connection object, already open, from the Session object
            conn = (System.Data.SqlClient.SqlConnection)Session["ConnectionObject"];
            comm = new SqlCommand(tmpQuery, conn);
            SqlDataReader reader;
            reader = comm.ExecuteReader();      // Se also ExecuteScalar and ExecuteNonQuery

            // Now we have our data in the reader object

            if (reader.HasRows)
            {       // probably don't need this. 
                while (reader.Read())
                {
                    if (reader.GetFieldType(0).ToString().Equals("System.String")) //can just about steal this line for line
                    {
                        tmp = reader.GetString(0) + ": " + reader.GetString(1); //changed so name appears before address
                    }

                    else
                    {
                        tmp = reader.GetString(1).ToString(); // Column 0 in the results set. Refer back to the construction of the query.
                    }
                    System.Console.WriteLine(tmp);

                    lblLoyalty.Text = tmp;
                    lblLoyaltyError.Text = "";


                }


            }
            else
            {
                lblLoyaltyError.Text = "The Loyalty Number " +tboxLoyalty.Text +" could not be found.";
            }
            try { reader.Close(); }
            catch (Exception ex) { }
        

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
