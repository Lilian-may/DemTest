namespace gandon
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonDelete = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(776, 348);
            dataGridView1.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(638, 392);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(482, 392);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 46);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(326, 392);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 46);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 392);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 39);
            textBoxSearch.TabIndex = 4;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonDelete;
        private Button buttonAdd;
        private Button buttonEdit;
        private TextBox textBoxSearch;
    }
}