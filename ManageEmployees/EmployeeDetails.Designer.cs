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
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(550, 550);
            dataGridView1.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(379, 29);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 836);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(AddButton);
            Name = "EmployeeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageEmployees";
            WindowState = FormWindowState.Maximized;
            Load += EmployeeDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private DataGridView dataGridView1;
        private Button btnDelete;
    }
}
