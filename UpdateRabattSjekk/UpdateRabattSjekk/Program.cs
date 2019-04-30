using System;
using System.Data;
using System.Data.SqlClient;

namespace UpdateRabattSjekk
{
    class Program
    {
        static void Main(string[] args)
        {
            string devConString = @"Data Source=fb-dev-sql.database.windows.net;Encrypt=False;Initial Catalog=fb-dev;Integrated Security=False;User ID=fbadmin;Password=SdqtjvDD4EUj;";

            string prodConString = @"Server=10.1.43.166;Database=fb;User Id=Feedback;Password=InformationOhYeah;Connection Timeout=30;MultipleActiveResultSets=True;";

            SqlConnection devCn = new SqlConnection(devConString);

            SqlConnection prodCn = new SqlConnection(prodConString);

        }
        private UpdateIntro()
        {
            
        }
        
        //    try
        //    {

                

        //        devCn.Open();
        //        //prodCn.Open();

        //        // read from dev rabattsjekk

        //        SqlCommand command;

        //        SqlDataReader dataReader;

        //        String sql, output = "";

        //        //read surveyname for rabatt

        //        sql = "Select SurveyName, Title from [fb-dev].dbo.Surveys where SurveyId = 3639";

        //        command = new SqlCommand(sql, devCn);
        //        var dt = new DataTable();
        //        var prodCommand = new SqlCommand("", prodCn);

        //        var dataadapter = new SqlDataAdapter(command);
        //        dataadapter.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                var name = row["SurveyName"];
        //                var newsql = "Update Survey Set(text) Values(@name) where ReportElementId=@id;";
        //                prodCommand.Parameters.AddWithValue("@name", name);
        //                prodCommand.CommandText = newsql;
        //                prodCommand.ExecuteNonQuery();
        //            }
        //        }
                
        //        devCn.Close();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
           
        }
    }
}
