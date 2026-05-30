using gandon.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gandon
{
    public partial class AddForm : Form
    {

        private readonly BookController _bookController = new();

        public AddForm()
        {
            InitializeComponent();
            LoadAuthors();
        }

        private void LoadAuthors()
        {
            comboBoxAuthors.DataSource = _bookController.GetAuthor();
            comboBoxAuthors.DisplayMember = "AuthorName";
            comboBoxAuthors.ValueMember = "Idauthor";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Enter the book name!");
                return;
            }

            if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price!");
                return;
            }

            _bookController.AddBook(textBoxName.Text, (int)comboBoxAuthors.SelectedValue, price);
            MessageBox.Show("Success!");
            this.Close();
        }
    }
}
