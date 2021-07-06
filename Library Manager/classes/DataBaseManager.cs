using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Manager
{
    public class DataBaseManager
    {
        static string command;
        static DataBaseManager()
        {
            
        }
        public static void Sample()
        {
            //command = "INSERT INTO TblTest  VALUES ('2', 'Amir');";
            //SqlCommand com = new SqlCommand(command, con);
            //com.BeginExecuteNonQuery();
        }

        public static void AddMember(Member MemberToAdd)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\University\Term 4\AP\Programming\Project\Library-project\Library-project\Library Manager\DataBase\LibraryDataBase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            MessageBox.Show(String.Format("INSERT INTO tblMembers (Name, Email, PhoneNumber, Password, SignDate, SubscriptionDate, ImageFileName) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", MemberToAdd.Name, MemberToAdd.Email, MemberToAdd.PhoneNumber, MemberToAdd.Password, Date.DateToDateTime(MemberToAdd.SignDate).ToString(), Date.DateToDateTime(MemberToAdd.ExtensionDate).ToString(), MemberToAdd.ImageFileName));
            command = String.Format("INSERT INTO tblMembers (Name, Email, PhoneNumber, Password, SignDate, SubscriptionDate, ImageFileName) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}');", MemberToAdd.Name, MemberToAdd.Email, MemberToAdd.PhoneNumber, MemberToAdd.Password, Date.DateToDateTime(MemberToAdd.SignDate).ToString(), Date.DateToDateTime(MemberToAdd.ExtensionDate).ToString(), MemberToAdd.ImageFileName);
            //command = "INSERT INTO tblMembers (Name, Email, PhoneNumber, Password, SignDate, SubscriptionDate, ImageFileName) VALUES ('0','1','2','}','4','5');";
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
        }
    }
}
