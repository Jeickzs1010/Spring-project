namespace Restaurant
{
    partial class Main_screen
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 129);
            label1.Name = "label1";
            label1.Size = new Size(396, 84);
            label1.TabIndex = 0;
            label1.Text = "Welcome to J's";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, -2);
            button1.Name = "button1";
            button1.Size = new Size(96, 37);
            button1.TabIndex = 1;
            button1.Text = "Tables";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(88, -2);
            button2.Name = "button2";
            button2.Size = new Size(96, 37);
            button2.TabIndex = 2;
            button2.Text = "Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(181, -2);
            button3.Name = "button3";
            button3.Size = new Size(96, 37);
            button3.TabIndex = 3;
            button3.Text = "Staff";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 198);
            label2.Name = "label2";
            label2.Size = new Size(302, 84);
            label2.TabIndex = 4;
            label2.Text = "Restaurant";
            label2.Click += label2_Click;
            // 
            // Main_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Main_screen";
            Text = "Main_screen";
            Load += Main_screen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
    }
}