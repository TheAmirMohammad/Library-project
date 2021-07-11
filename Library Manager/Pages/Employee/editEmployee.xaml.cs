using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Library_Manager.Pages.Employee
{
    /// <summary>
    /// Interaction logic for editEmployee.xaml
    /// </summary>
    public partial class editEmployee : Page
    {
        string ImageFile = null;

        public editEmployee(Library_Manager.Employee emp)
        {
            InitializeComponent();
            txtName.Text = emp.Name;
            txtEmail.Text = emp.Email;
            txtPassword.Password = emp.Password;
            txtPhoneNumber.Text = emp.PhoneNumber;
        }
        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateFields())
            {
                Library_Manager.Employee NewEmployee = new Library_Manager.Employee(txtName.Text, txtPhoneNumber.Text, txtEmail.Text, txtPassword.Password, ImageFile);
                if (DataBaseManager.isEmployeeExists(NewEmployee.Name, NewEmployee.Email, NewEmployee.PhoneNumber)
                    && DataBaseManager.isMemberExists(NewEmployee.Name, NewEmployee.Email, NewEmployee.PhoneNumber))
                {
                    DataBaseManager.updateEmployee(NewEmployee);
                }
            }
        }
        bool ValidateFields()
        {
            //Check required fields due to Regex

            //Check Email
            if (txtEmail.Text == "")
            {
                System.Windows.MessageBox.Show("E-mail is required! please provide an e-mail.");
                return false;
            }
            else
            {
                if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                {
                    System.Windows.MessageBox.Show("E-mail must be in correct format! please provide a proper e-mail.");
                    return false;
                }

            }
            //Check PhoneNumber
            if (txtPhoneNumber.Text == "")
            {
                System.Windows.MessageBox.Show("Phone number is required! please provide a phone number.");
                return false;
            }
            else
            {
                if (txtPhoneNumber.Text[0] != '9')
                {
                    System.Windows.MessageBox.Show("Phone number must begin with 9! please provide a proper phone number.");
                    return false;
                }
            }
            //Check preNumber
            if (txtPreNumber.Text == "")
            {
                System.Windows.MessageBox.Show("Country phone number code is required! please provide a country phone number code.");
                return false;
            }
            else
            {
                if (txtPreNumber.Text.Length != 2)
                {
                    System.Windows.MessageBox.Show("Country phone number code must be in correct format! please provide a proper country phone number code.");
                    return false;
                }
            }
            //Check Password
            if (txtPassword.Password != "")
            {
                if (txtPassword.Password.Length < 8)
                {
                    System.Windows.MessageBox.Show("Password must have at least 8 characters!please provide a proper password.");
                    return false;
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Password phone number code is required! please provide a password.");
                return false;
            }
            if (ImageFile == null)
            {
                System.Windows.MessageBox.Show("Choose a profile Photo! please provide a picture.");
                return false;
            }

            //Fields Are Valid
            return true;
        }
        private void ChooseFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ImageFile = dlg.FileName;
                //System.Windows.MessageBox.Show(ImageFile);
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImageFile);
                bitmap.EndInit();
                ProfileImage.Source = bitmap;
            }
        }
    }
}
