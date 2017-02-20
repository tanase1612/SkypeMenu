using System.Security;
using System.Windows;

namespace SkypeMenuAdmin
{
    /// <summary>
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class LoginUser : Window
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            // Verify user credentials are empty or not.
            if (txtUsername.Text == "" || passwordBox1.Password.ToString() == "")
            {
                MessageBoxResult res = MessageBox.Show("Username and Password cannot be empty", "Problem in login");
               res = MessageBoxResult.None;
                return;
            }

            // Assign username to variable.
            UserCredential.UserName = txtUsername.Text;

            // Create and assign secure password string.
            SecureString securePass = new SecureString();
            foreach (char secureChar in passwordBox1.Password.ToString())
            {
                securePass.AppendChar(secureChar);
            }

            UserCredential.Password = securePass;

            // Close this dialog box and proceed to verify user credentials.
           
            MessageBoxResult dcv = MessageBoxResult.OK;
           // this.Close();

            MainWindow m = new MainWindow();
            this.Close();         
            m.Show();
        }

     
    }
}
