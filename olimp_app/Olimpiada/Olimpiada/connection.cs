using System.Data.SqlClient;

namespace Olimpiada
{
    internal class connection
    {
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-SNOUO08\SQLEXPRESS;Initial Catalog=DB_olimp; Integrated Security=true");
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=MASHY\SQLEXPRESS;Initial Catalog=DB_olimp; Integrated Security=true");

        public SqlConnection getConnection()
        { 
            return sqlConnection;
        }
    }
}
