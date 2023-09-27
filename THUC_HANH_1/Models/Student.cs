using System.ComponentModel.DataAnnotations;
using THUC_HANH_1.Models;

namespace THUC_HANH_1.Models
{
    public class Student
    {
        public int Id { get; set; } // Ma sinh vien
       
        [StringLength(100, MinimumLength = 4)]
        [Required(ErrorMessage = "Name tối thiểu 4 ký tự, tối đa 100 ký tự")]
        public string? Name { get; set; } // Ho ten
        [Required(ErrorMessage = "Địa chỉ email phải có đuôi gmail.com")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string? Email { get; set; }
        [StringLength(100, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@#$%^&+=!]).{8,}$")]
        [Required(ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        public Branch? Branch { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        public Gender? Gender { get; set; }
        public bool IsRegular { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Vui lòng nhập trường này")]
        public string? Address { get; set; }
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Vui lòng nhập trường này ")]
        public DateTime DateOfBorth { get; set; }
        public string? AvatarUrl { get; set; }

        [Required(ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        public double Score { get; set; }
    }
}