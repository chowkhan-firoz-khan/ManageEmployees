using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Immutable;
using System.Data;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ManageEmployees
{
    public partial class EmployeeDetails : Form
    {
        string authToken = "0bf7fb56e6a27cbcadc402fc2fce8e3aa9ac2b40d4190698eb4e8df9284e2023";

        public EmployeeDetails()
        {
            InitializeComponent();
        }

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

        public async void GetEmployeeByID(string empID)
        {
            empID = "5825872";
            string uri = "https://gorest.co.in/public/v2/users/" + empID;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authToken);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //var res = response.Content.ReadAsByteArrayAsync().Wait();
                        var fileJsonString = await response.Content.ReadAsAsync<Employee>();
                        string json = JsonConvert.SerializeObject(fileJsonString);
                        //string jsonString = "[" + json + "]";
                        //List<Employee> datalist = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                        JObject jsonObject = JObject.Parse(json);
                        JArray jArray = new JArray(jsonObject);
                        var jsonArray = jsonObject.Properties().Select(p => new { Key = p.Name, Value = p.Value }).ToArray();

                        Dictionary<string,object> dic = new Dictionary<string,object>();
                        foreach (var property in jsonObject.Properties())
                        {
                            dic.Add(property.Name, property.Value);
                        }

                        foreach (var kvp in dic)
                        {
                            dataGridView1.Columns.Add(kvp.Key, kvp.Key);
                        }

                        dataGridView1.Rows.Add(dic.Values.ToArray());
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.ShowDialog();
        }
    }
}
