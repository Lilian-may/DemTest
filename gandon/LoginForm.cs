using gandon.Controllers;
using gandon.Models;

namespace gandon
{
    public partial class LoginForm : Form
    {
        private UserController _userController = new();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            try
            {
                Librarian? user = _userController.Authorize(textBoxUsername.Text, textBoxPassword.Text);

                if (user == null) return;

                MainForm mainForm = new();
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
