using System;
using System.Windows;
using System.Windows.Controls;

namespace Library_Manager
{
    /// <summary>
    /// Interaction logic for PayPanel.xaml
    /// </summary>
    public partial class PayPanel : Page
    {
        Member NewMember;
        Member member;
        int amount;
        bool isForAddMember = false;
        bool isForMember = false;
        public PayPanel(int amount, bool isMember = false, Member member = null)
        {
            InitializeComponent();
            Payment_Amount.Text += amount.ToString();
            isForMember = isMember;
            this.member = member;
            this.amount = amount;
        }

        public PayPanel(int amount, Member MemberToAdd)
        {
            InitializeComponent();
            NewMember = MemberToAdd;
            Payment_Amount.Text += amount.ToString();
            isForAddMember = true;
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            var load = new Pages.Universal.Loading();
            load.Activate();
            load.Show();
            if (isForAddMember)
            {
                if (DataBaseManager.isMemberExists(NewMember.Name, NewMember.Email, NewMember.PhoneNumber))
                    if (isCardValid())
                    {
                        DataBaseManager.AddMember(NewMember);
                        DataBaseManager.AddBudget(amount);

                        MemberPanel member = new MemberPanel(NewMember);
                        member.Show();

                        MainWindow main = Application.Current.MainWindow as MainWindow;
                        if (main != null)
                        {
                            main.Close();
                        }
                    }
            }
            else
            {
                if (isForMember)
                {
                    DataBaseManager.addMemberBalance(member.Name, amount);
                    MessageBox.Show("Done !");
                    MainWindow main = Application.Current.MainWindow as MainWindow;
                    if (main != null)
                    {
                        main.Close();
                    }
                }
                else
                {
                    DataBaseManager.AddBudget(amount);
                    MessageBox.Show("Done !");
                    MainWindow main = Application.Current.MainWindow as MainWindow;
                    if (main != null)
                    {
                        main.Close();
                    }
                }
            }
            load.Close();
        }

        private bool isCardValid()
        {
            DateTime today = DateTime.Now;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            if (string.IsNullOrEmpty(num1.Text) || string.IsNullOrEmpty(num2.Text) || string.IsNullOrEmpty(num3.Text) || string.IsNullOrEmpty(num4.Text))
            {
                MessageBox.Show("Enter card number !");
                return false;
            }
            else
            {
                if (num1.Text.Length != 4 || num2.Text.Length != 4 || num3.Text.Length != 4 || num4.Text.Length != 4)
                {
                    MessageBox.Show("card number should be 16 digits !");
                    return false;
                }
                else
                {
                    if (!IsDigitsOnly(num1.Text) || !IsDigitsOnly(num2.Text) || !IsDigitsOnly(num3.Text) || !IsDigitsOnly(num4.Text))
                    {
                        MessageBox.Show("card number should be all digits !");
                        return false;
                    }
                    else
                    {
                        int sum = 0;
                        int[] number = { int.Parse(num1.Text), int.Parse(num2.Text), int.Parse(num3.Text), int.Parse(num4.Text) };

                        foreach (var item in number)
                        {
                            var temp = item;
                            sum += temp % 10;
                            temp /= 10;
                            sum += IsGraterThan10(2 * (temp % 10));
                            temp /= 10;
                            sum += temp % 10;
                            temp /= 10;
                            sum += IsGraterThan10(2 * (temp % 10));
                        }

                        if (sum % 10 != 0)
                        {
                            MessageBox.Show("card number is not valid !");
                            return false;
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Enter password !");
                return false;
            }
            else
            {
                if (password.Text.Length < 5)
                {
                    MessageBox.Show("PassWord should be at least 5 digits !");
                    return false;
                }
                else
                {
                    if (!IsDigitsOnly(password.Text))
                    {
                        MessageBox.Show("year should be all digits !");
                        return false;
                    }
                }
            }
            if (string.IsNullOrEmpty(cvv2.Text))
            {
                MessageBox.Show("Enter CVV2 !");
                return false;
            }
            else
            {
                if (cvv2.Text.Length != 3 && cvv2.Text.Length != 4)
                {
                    MessageBox.Show("CVV2 should be exactly 3 or 4 digits !");
                    return false;
                }
                else
                {
                    if (!IsDigitsOnly(cvv2.Text))
                    {
                        MessageBox.Show("CVV2 should be all digits !");
                        return false;
                    }
                }
            }

            if (string.IsNullOrEmpty(year.Text))
            {
                MessageBox.Show("Enter year !");
                return false;
            }
            else
            {
                if (!IsDigitsOnly(year.Text))
                {
                    MessageBox.Show("year should be all digits !");
                    return false;
                }
            }
            if (string.IsNullOrEmpty(month.Text))
            {
                MessageBox.Show("Enter month !");
                return false;
            }
            {
                if (!IsDigitsOnly(month.Text))
                {
                    MessageBox.Show("month should be all digits !");
                    return false;
                }
            }

            int txtyear = 1400 + int.Parse(year.Text);
            int txtmonth = int.Parse(month.Text);
            int yearDiff = txtyear - pc.GetYear(today);

            if (yearDiff > 5 || yearDiff < 0)
            {
                MessageBox.Show("Expire year is not valid !");
                return false;
            }
            if (txtmonth < 1 || txtmonth > 12)
            {
                MessageBox.Show("Expire month is not valid !");
                return false;
            }
            if (yearDiff == 0)
                if (txtmonth - pc.GetMonth(today) < 3)
                    return false;
            if (yearDiff == 1)
                if (txtmonth + 12 - pc.GetMonth(today) < 3)
                    return false;

            return true;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        int IsGraterThan10(int num)
        {
            if (num > 9)
            {
                int temp = num % 10;
                num /= 10;
                temp += num;
                return temp;
            }
            return num;
        }
    }
}