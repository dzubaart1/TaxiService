namespace TaxiClient
{
    partial class RemoveUserForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            IDTextBox = new TextBox();
            RemoveBtn = new Button();
            DebugText = new Label();
            UserListView = new ListView();
            ID = new ColumnHeader();
            Login = new ColumnHeader();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(UserListView, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(700, 338);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(IDTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(RemoveBtn, 0, 1);
            tableLayoutPanel2.Controls.Add(DebugText, 1, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(212, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(109, 3);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 1;
            IDTextBox.TextChanged += IDTextBox_TextChanged;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(3, 32);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(75, 23);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // DebugText
            // 
            DebugText.AutoSize = true;
            DebugText.Location = new Point(109, 29);
            DebugText.Name = "DebugText";
            DebugText.Size = new Size(63, 15);
            DebugText.TabIndex = 3;
            DebugText.Text = "DebugText";
            // 
            // UserListView
            // 
            UserListView.Columns.AddRange(new ColumnHeader[] { ID, Login });
            UserListView.Dock = DockStyle.Fill;
            UserListView.Location = new Point(353, 3);
            UserListView.Name = "UserListView";
            UserListView.Size = new Size(344, 332);
            UserListView.TabIndex = 1;
            UserListView.UseCompatibleStateImageBehavior = false;
            UserListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Login
            // 
            Login.Text = "Login";
            // 
            // RemoveUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanel1);
            Name = "RemoveUserForm";
            Text = "RemoveUserForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox IDTextBox;
        private Button RemoveBtn;
        private ListView UserListView;
        private ColumnHeader ID;
        private ColumnHeader Login;
        private Label DebugText;
    }
}