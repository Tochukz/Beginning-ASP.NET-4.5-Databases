using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.UI.HtmlControls;

namespace DataAccess
{
    public partial class Read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadEmployeeTable();
        }

        private void ReadEmployeeTable()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Sample1DB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("select id, name, gender, city, salary from tblEmployee", connection);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    DisplayResults(reader);
                }
            }
            catch(Exception ex)
            {
                errorDiv.InnerText = ex.Message;
            }
        }

        private void DisplayResults(SqlDataReader reader)
        {
            while(reader.Read())
            {
        
                HtmlTableRow row = CreateRow(reader.GetValue(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetValue(4).ToString());                
                employeeTable.Controls.Add(row);
            }
        }

        private HtmlTableRow CreateRow(params string[] fields)
        {
            HtmlTableRow row = new HtmlTableRow();
            for (int x = 0; x < fields.Length; x++)
            {
                HtmlTableCell cell = new HtmlTableCell();
                cell.InnerText = fields[x];
                row.Controls.Add(cell);
            }

            return row;
        }
    }
}