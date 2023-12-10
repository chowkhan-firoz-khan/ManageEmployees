namespace ManageEmployees
{
    partial class SearchForm
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
            btnSearchID = new Button();
            labelID = new Label();
            txtSearchID = new TextBox();
            SuspendLayout();
            // 
            // btnSearchID
            // 
            btnSearchID.Location = new Point(327, 138);
            btnSearchID.Name = "btnSearchID";
            btnSearchID.Size = new Size(75, 23);
            btnSearchID.TabIndex = 0;
            btnSearchID.Text = "Search ID";
            btnSearchID.UseVisualStyleBackColor = true;
            btnSearchID.Click += btnSearchID_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(222, 98);
            labelID.Name = "labelID";
            labelID.Size = new Size(25, 15);
            labelID.TabIndex = 1;
            labelID.Text = "ID#";
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(327, 90);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(100, 23);
            txtSearchID.TabIndex = 2;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearchID);
            Controls.Add(labelID);
            Controls.Add(btnSearchID);
            Name = "SearchForm";
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchID;
        private Label labelID;
        private TextBox txtSearchID;
    }
}