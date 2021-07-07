using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Library_Manager
{
    public class DataBaseManager
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\works\darC\AP\Project\Library-project\Library Manager\DataBase\LibraryDataBase.mdf;Integrated Security=True;Connect Timeout=30");

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

        public static bool isMemberExists(Member MemberToAdd)
        {
            DataTable data = MemberList();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][1].ToString() == MemberToAdd.Name || data.Rows[i][2].ToString() == MemberToAdd.Email || data.Rows[i][3].ToString() == MemberToAdd.PhoneNumber)
                {
                    System.Windows.MessageBox.Show("Member con not be Added !\nSame info exists !!");
                    return false;
                }
            }
            return true;
        }

        public static void AddMember(Member MemberToAdd)
        {
            con.Open();
            MessageBox.Show(String.Format("INSERT INTO tblMembers (Name, Email, PhoneNumber, Password, SignDate, SubscriptionDate, ImageFileName) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');", MemberToAdd.Name, MemberToAdd.Email, MemberToAdd.PhoneNumber, MemberToAdd.Password, Date.DateToDateTime(MemberToAdd.SignDate).ToString(), Date.DateToDateTime(MemberToAdd.ExtensionDate).ToString(), MemberToAdd.ImageFileName));
            command = String.Format("INSERT INTO tblMembers (Name, Email, PhoneNumber, Password, SignDate, SubscriptionDate, ImageFileName) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}');", MemberToAdd.Name, MemberToAdd.Email, MemberToAdd.PhoneNumber, MemberToAdd.Password, Date.DateToDateTime(MemberToAdd.SignDate).ToString(), Date.DateToDateTime(MemberToAdd.ExtensionDate).ToString(), MemberToAdd.ImageFileName);
            SqlCommand com = new SqlCommand(command, con);
            com.BeginExecuteNonQuery();
            con.Close();
        }

        public static DataTable MemberList()
        {
            con.Open();
            command = "SELECT * from tblMembers";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }
        public static DataTable EmpList()
        {
            con.Open();
            command = "SELECT * from tblEmployees";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
