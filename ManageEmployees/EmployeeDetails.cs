using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Net.Http.Headers;

namespace ManageEmployees
{
    public partial class EmployeeDetails : Form
    {
        string authToken = "0bf7fb56e6a27cbcadc402fc2fce8e3aa9ac2b40d4190698eb4e8df9284e2023";

        public EmployeeDetails()
        {
            InitializeComponent();
            GetAllEmployees();
        }

        /// <summary>
        /// Displays all employees from the web service
        /// </summary>
        public async void GetAllEmployees()
        {
            string uri = "https://gorest.co.in/public/v2/users/";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        IList<Employee> employees = await response.Content.ReadAsAsync<IList<Employee>>();
                        dataGridView1.DataSource = employees;
                    }
                }
            }
        }

        /// <summary>
        /// Delete sekected row of data grid view.
        /// </summary>
        /// <param name="empID"></param>
        public async void DeletetEmployeeByID(string empID)
        {
            string uri = "https://gorest.co.in/public/v2/users/" + empID;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.DeleteAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Record deleted successfully!");
                        GetAllEmployees();
                    }
                }
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm();
            addForm.ShowDialog();
            GetAllEmployees();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            GetAllEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            var id = selectedRow.Cells[0].Value.ToString();
            DeletetEmployeeByID(id);
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
