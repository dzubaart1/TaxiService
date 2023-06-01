namespace TaxiClient
{
    partial class AddNewUserForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            UserTypeComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            AddUserBtn = new Button();
            DebugText = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(700, 338);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(UserTypeComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(LoginTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(AddUserBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(DebugText, 1, 3);
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(219, 143);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 27);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // UserTypeComboBox
            // 
            UserTypeComboBox.FormattingEnabled = true;
            UserTypeComboBox.Location = new Point(112, 56);
            UserTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            UserTypeComboBox.Name = "UserTypeComboBox";
            UserTypeComboBox.Size = new Size(104, 23);
            UserTypeComboBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(103, 27);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(103, 27);
            label3.TabIndex = 2;
            label3.Text = "UserType";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(112, 2);
            LoginTextBox.Margin = new Padding(3, 2, 3, 2);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(104, 23);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(112, 29);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(104, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new Point(3, 83);
            AddUserBtn.Margin = new Padding(3, 2, 3, 2);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(82, 22);
            AddUserBtn.TabIndex = 5;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // DebugText
            // 
            DebugText.AutoSize = true;
            DebugText.Location = new Point(112, 81);
            DebugText.Name = "DebugText";
            DebugText.Size = new Size(63, 15);
            DebugText.TabIndex = 6;
            DebugText.Text = "DebugText";
            // 
            // AddNewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddNewUserForm";
            Text = "AddNewUserForm";
            FormClosing += AddNewUserForm_FormClosing;
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox UserTypeComboBox;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button AddUserBtn;
        private Label DebugText;
    }
}