using gandon.Controllers;
using gandon.Models;
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
    public partial class EditForm : Form
    {

        private readonly BookController _bookController = new();
        private readonly Book _book;

        public EditForm(Book book)
        {
            try
            {
                InitializeComponent();
                _book = book;
                LoadAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAuthors()
        {
            comboBoxAuthors.DataSource = _bookController.GetAuthor();
            comboBoxAuthors.DisplayMember = "AuthorName";
            comboBoxAuthors.ValueMember = "Idauthor";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    MessageBox.Show("Enter the value into Name field");
                    return;
                }

                if (!decimal.TryParse(textBoxPrice.Text, out decimal price))
                {
                    MessageBox.Show("Invalid price!");
                    return;
                }

                _bookController.UpdateBook(_book.Idbook, textBoxName.Text, (int)comboBoxAuthors.SelectedValue, price);
                MessageBox.Show("Changes saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
