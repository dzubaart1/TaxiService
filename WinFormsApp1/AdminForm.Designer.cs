namespace TaxiClient
{
    partial class AdminForm
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
            label2 = new Label();
            LoginText = new Label();
            UserTypeText = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            AddUserBtn = new Button();
            RemoveUserBtn = new Button();
            EditUserBtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
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
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(LoginText, 1, 0);
            tableLayoutPanel1.Controls.Add(UserTypeText, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 2);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(219, 94);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Роль";
            // 
            // LoginText
            // 
            LoginText.AutoSize = true;
            LoginText.Location = new Point(112, 0);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(58, 15);
            LoginText.TabIndex = 2;
            LoginText.Text = "LoginText";
            // 
            // UserTypeText
            // 
            UserTypeText.AutoSize = true;
            UserTypeText.Location = new Point(112, 15);
            UserTypeText.Name = "UserTypeText";
            UserTypeText.Size = new Size(75, 15);
            UserTypeText.TabIndex = 3;
            UserTypeText.Text = "UserTypeText";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(AddUserBtn);
            flowLayoutPanel2.Controls.Add(RemoveUserBtn);
            flowLayoutPanel2.Controls.Add(EditUserBtn);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(228, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(140, 92);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Location = new Point(3, 3);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(137, 23);
            AddUserBtn.TabIndex = 0;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // RemoveUserBtn
            // 
            RemoveUserBtn.ForeColor = SystemColors.ControlText;
            RemoveUserBtn.Location = new Point(3, 32);
            RemoveUserBtn.Name = "RemoveUserBtn";
            RemoveUserBtn.Size = new Size(137, 23);
            RemoveUserBtn.TabIndex = 1;
            RemoveUserBtn.Text = "Remove User";
            RemoveUserBtn.UseVisualStyleBackColor = true;
            // 
            // EditUserBtn
            // 
            EditUserBtn.Location = new Point(3, 61);
            EditUserBtn.Name = "EditUserBtn";
            EditUserBtn.Size = new Size(137, 23);
            EditUserBtn.TabIndex = 2;
            EditUserBtn.Text = "Edit User";
            EditUserBtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "AdminForm";
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label LoginText;
        private Label UserTypeText;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button AddUserBtn;
        private Button RemoveUserBtn;
        private Button EditUserBtn;
    }
}