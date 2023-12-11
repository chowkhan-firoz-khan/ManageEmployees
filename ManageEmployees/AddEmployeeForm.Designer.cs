namespace ManageEmployees
{
    partial class AddEmployeeForm
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
            labelName = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            labelEmail = new Label();
            txtGender = new TextBox();
            labelGender = new Label();
            txtStatus = new TextBox();
            label2 = new Label();
            btnReset = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(212, 96);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(294, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 23);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(294, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 23);
            txtEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(212, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(294, 183);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(206, 23);
            txtGender.TabIndex = 5;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(212, 191);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(45, 15);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(294, 236);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(206, 23);
            txtStatus.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 244);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Status";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(368, 302);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(132, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(212, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(txtStatus);
            Controls.Add(label2);
            Controls.Add(txtGender);
            Controls.Add(labelGender);
            Controls.Add(txtEmail);
            Controls.Add(labelEmail);
            Controls.Add(txtName);
            Controls.Add(labelName);
            Name = "AddEmployeeForm";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label labelEmail;
        private TextBox txtGender;
        private Label labelGender;
        private TextBox txtStatus;
        private Label label2;
        private Button btnReset;
        private Button btnSave;
    }
}