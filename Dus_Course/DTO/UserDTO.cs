using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DTO
{
    public class UserDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please fill the Username Area")]

        public string Username { get; set; }
        [Required(ErrorMessage = "Please fill the Password Area")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Please fill the Email Area")]
        public string Email { get; set; }
        public string Imagepath { get; set; }
        [Required(ErrorMessage = "Please fill the Name Area")]
        public string Name { get; set; }
        public bool isAdmin { get; set; }
        //HttpPostedFileBase là một lớp cơ sở(base class) cho đại diện các tập tin được gửi từ trình duyệt lên máy chủ thông qua một yêu cầu HTTP
        //    .Lớp này cung cấp các thuộc tính và phương thức để xử lý tập tin được tải lên
        [Display(Name ="User Image")]
        public HttpPostedFileBase UserImage { get; set; }
    }
}
