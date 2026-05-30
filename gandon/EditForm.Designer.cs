namespace gandon
{
    partial class EditForm
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
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            comboBoxAuthors = new ComboBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 39);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(218, 12);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(200, 39);
            textBoxPrice.TabIndex = 1;
            // 
            // comboBoxAuthors
            // 
            comboBoxAuthors.FormattingEnabled = true;
            comboBoxAuthors.Location = new Point(12, 57);
            comboBoxAuthors.Name = "comboBoxAuthors";
            comboBoxAuthors.Size = new Size(242, 40);
            comboBoxAuthors.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(260, 57);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 46);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxAuthors);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private ComboBox comboBoxAuthors;
        private Button buttonSave;
    }
}