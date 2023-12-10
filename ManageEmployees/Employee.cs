using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ManageEmployees
{
    public class Employee
    {
        [Key]
        [DisplayName("ID")]
        public string id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Gender")]
        public string gender {  get; set; }
        [DisplayName("Status")]
        public string status { get; set; }

    }
}
