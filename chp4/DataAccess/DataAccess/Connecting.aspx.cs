using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Web.UI.WebControls;

namespace DataAccess
{
    public partial class Connecting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(IsPostBack)
            {
                ConnectWithCredential();
            }
            else
            {
                // Connect();
                ConnectAsync();
            }
        }

        private void Connect()
        {
            try
            {
                //string connectionString = ConfigurationManager.ConnectionStrings["Sample1DB"].ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["Sample1DB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    //connection.ChangeDatabase("rulesdemo");

                    DisplayConnectionDetails(connection);
                   
                }
            } 
            catch(Exception ex)
            {
                errorDiv.InnerText = ex.ToString();
            }
        }

        /* This does not work*/
        private void ConnectWithCredential()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["rulesDB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SecureString password = new SecureString();
                    char[] chars = pwd.Text.ToCharArray();
                    for (int x = 0; x < chars.Length; x++)
                    {
                        password.InsertAt(x, chars[x]);
                        password.AppendChar(pwd.Text[x]);
                    }
                    password.MakeReadOnly();
                    SqlCredential credential = new SqlCredential(userId.Text, password);                                     
                    connection.Open();
                    connection.ChangeDatabase(dbName.Text);

                    DisplayConnectionDetails(connection);
                }
            }
            catch(Exception ex)
            {
                errorDiv.InnerText = ex.ToString();
            }
        }

        private void ConnectAsync()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Sample1DB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.OpenAsync();
                    DisplayConnectionDetails(connection);
                }
            }
            catch(Exception ex)
            {
                errorDiv.InnerText = ex.Message;
            }
        }
        private void DisplayConnectionDetails(SqlConnection connection)
        {
            Dictionary<string, string> connectionDetails = new Dictionary<string, string>
                    {
                        {"Station ID", connection.WorkstationId },
                        {"Client ID", connection.ClientConnectionId.ToString() },
                        {"State", connection.State.ToString()},
                        {"DataSource" , connection.DataSource},
                        {"Database", connection.Database }
                    };


            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, string> detail in connectionDetails)
            {
                stringBuilder.AppendFormat("<p><b>{0}</b> {1} </p>", detail.Key, detail.Value);
            }
            string html = stringBuilder.ToString();
            connectionDiv.InnerHtml = html;
        }       
    }
}