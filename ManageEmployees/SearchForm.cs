using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageEmployees
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            EmployeeDetails emp = new EmployeeDetails();
            emp.GetEmployeeByID("");
            this.Close();
        }
    }
}
