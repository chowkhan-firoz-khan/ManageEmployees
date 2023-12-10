namespace ManageEmployees
{
    partial class EmployeeDetails
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
            AddButton = new Button();
            ViewButton = new Button();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(245, 29);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(104, 23);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.Location = new Point(397, 29);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(106, 23);
            ViewButton.TabIndex = 3;
            ViewButton.Text = "View";
            ViewButton.UseVisualStyleBackColor = true;
            ViewButton.Click += ViewButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(550, 550);
            dataGridView1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(551, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 836);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(ViewButton);
            Controls.Add(AddButton);
            Name = "EmployeeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Button ViewButton;
        private DataGridView dataGridView1;
        private Button btnSearch;
    }
}
