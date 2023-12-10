using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace ManageEmployees
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Employee newEmp = new Employee();

            newEmp.name = txtName.Text;
            newEmp.email = txtEmail.Text;
            newEmp.gender = txtGender.Text;
            newEmp.status = txtStatus.Text;

            JsonContent content = JsonContent.Create(newEmp);
            string json = JsonConvert.SerializeObject(newEmp);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            string uri = "https://gorest.co.in/public/v2/users/";

            using (HttpClient client = new HttpClient())
            {
                string authToken = "0bf7fb56e6a27cbcadc402fc2fce8e3aa9ac2b40d4190698eb4e8df9284e2023";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                using (var response = await client.PostAsync(uri, stringContent))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Record added successfully!");
                        this.Close();
                    }
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtStatus.Text = "";
        }
    }
}
