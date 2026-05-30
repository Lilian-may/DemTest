namespace gandon
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAuth = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // buttonAuth
            // 
            buttonAuth.Location = new Point(292, 347);
            buttonAuth.Name = "buttonAuth";
            buttonAuth.Size = new Size(150, 46);
            buttonAuth.TabIndex = 0;
            buttonAuth.Text = "Authorize";
            buttonAuth.UseVisualStyleBackColor = true;
            buttonAuth.Click += buttonAuth_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(276, 119);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(200, 39);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(276, 230);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(200, 39);
            textBoxPassword.TabIndex = 2;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(276, 75);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(121, 32);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(276, 195);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(111, 32);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonAuth);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAuth;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Label labelPassword;
    }
}
