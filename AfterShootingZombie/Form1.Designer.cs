namespace AfterShootingZombie
{
    partial class Form1
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
            personListBox = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            searchButton = new Button();
            exitButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // personListBox
            // 
            personListBox.FormattingEnabled = true;
            personListBox.Location = new Point(27, 23);
            personListBox.Name = "personListBox";
            personListBox.Size = new Size(279, 199);
            personListBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(27, 255);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(128, 255);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(231, 257);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(27, 299);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(279, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 345);
            Controls.Add(textBox1);
            Controls.Add(exitButton);
            Controls.Add(searchButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(personListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox personListBox;
        private Button addButton;
        private Button removeButton;
        private Button searchButton;
        private Button exitButton;
        private TextBox textBox1;
    }
}
