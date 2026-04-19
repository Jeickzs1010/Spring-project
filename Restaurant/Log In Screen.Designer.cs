namespace Restaurant
{
    partial class Log_In_Screen
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
            Create = new Button();
            Cancel = new Button();
            label2 = new Label();
            label1 = new Label();
            Password = new TextBox();
            User = new TextBox();
            SuspendLayout();
            // 
            // Create
            // 
            Create.Location = new Point(286, 312);
            Create.Name = "Create";
            Create.Size = new Size(75, 23);
            Create.TabIndex = 12;
            Create.Text = "Continue";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click_1;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(480, 312);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 11;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 217);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 118);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "UserName";
            label1.Click += label1_Click;
            // 
            // Password
            // 
            Password.Location = new Point(284, 214);
            Password.Name = "Password";
            Password.Size = new Size(271, 23);
            Password.TabIndex = 8;
            Password.TextChanged += Password_TextChanged;
            // 
            // User
            // 
            User.Location = new Point(286, 115);
            User.Name = "User";
            User.Size = new Size(269, 23);
            User.TabIndex = 7;
            User.TextChanged += User_TextChanged;
            // 
            // Log_In_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Create);
            Controls.Add(Cancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(User);
            Name = "Log_In_Screen";
            Text = "Log_In_Screen";
            Load += Log_In_Screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Create;
        private Button Cancel;
        private Label label2;
        private Label label1;
        private TextBox Password;
        private TextBox User;
    }
}