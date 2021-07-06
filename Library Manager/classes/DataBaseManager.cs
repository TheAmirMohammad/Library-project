using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_Manager.classes
{
    public class DataBaseManager
    {
        public static void Sample ()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\University\Term 4\AP\Programming\Project\Library-project\Library-project\Library Manager\DataBase\LibraryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string comment = "INSERT INTO TblTest  VALUES ('2', 'Amir');";
            SqlCommand com = new SqlCommand(comment, con);
            com.BeginExecuteNonQuery();
        }
    }
}
