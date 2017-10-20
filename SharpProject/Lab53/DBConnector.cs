using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Entity;

namespace SharpProject.Lab53
{
    public class DBConnector
    {
        public void RunLab()
        {
            try
            {
                using (SqlConnection dbConnection = new SqlConnection("server=(local);Integrated Security=true;"))
                {
                    dbConnection.Open();
                    int arg1 = new Random().Next(0, 10000);
                    int arg2 = new Random().Next(0, 10000);
                    using (SqlCommand command =
                        new SqlCommand(
                            "insert into Trading.dbo.TEST_TABLE (AB, BC) VALUES ('" + arg1 + "','" + arg2 + "');",
                            dbConnection))
                    {
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand("select * from Trading.dbo.TEST_TABLE;", dbConnection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet set = new DataSet();
                        adapter.Fill(set, "Trading.dbo.TEST_TABLE");
                        DataTable table = set.Tables["Trading.dbo.TEST_TABLE"];
                        foreach (DataRow row in table.Rows)
                        {
                            Console.Write(row["AB"]);
                            Console.Write(":");
                            Console.WriteLine(row["BC"]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}