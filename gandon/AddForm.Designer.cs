namespace gandon
{
    partial class AddForm
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
            comboBoxAuthors = new ComboBox();
            buttonSave = new Button();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            SuspendLayout();
            // 
            // comboBoxAuthors
            // 
            comboBoxAuthors.FormattingEnabled = true;
            comboBoxAuthors.Location = new Point(12, 12);
            comboBoxAuthors.Name = "comboBoxAuthors";
            comboBoxAuthors.Size = new Size(242, 40);
            comboBoxAuthors.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(638, 392);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 46);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(284, 13);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 39);
            textBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(490, 13);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(200, 39);
            textBoxPrice.TabIndex = 3;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxAuthors);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAuthors;
        private Button buttonSave;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
    }
}