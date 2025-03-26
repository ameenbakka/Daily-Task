using System.Data;
using Microsoft.Data.SqlClient;    
namespace DataViews
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=ASlam;Database=books;IntegratedSecurity=True";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select *from books", conn);
                DataSet ds = new DataSet(); 
                adapter.Fill(ds,"books");
                DataView view=new DataView(ds.Tables["books"]);
                view.Sort("title ASC");

            }
        }
  
}
