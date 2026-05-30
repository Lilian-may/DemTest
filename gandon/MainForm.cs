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
    public partial class MainForm : Form
    {

        private readonly BookController _bookController = new();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = _bookController.GetBooks();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            Book book = (Book)dataGridView1.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show("Attention", "Are you really want to delete row?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result != DialogResult.Yes) return;

            _bookController.DeleteBook(book.Idbook);
            LoadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();
            addForm.ShowDialog();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            Book book = (Book)dataGridView1.CurrentRow.DataBoundItem;
            EditForm editForm = new(book);
            editForm.Show();
            LoadData();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower().ToString();

            dataGridView1.DataSource = _bookController.GetBooks().Where(x => x.Name.ToLower().Contains(search)).ToList();

        }
    }
}
