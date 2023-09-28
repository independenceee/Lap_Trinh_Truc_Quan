using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using THUC_HANH_1.Models;

namespace THUC_HANH_1.Models
{
    public class Student
    {
        public int Id { get; set; } //Mã sinh viên

        [Required(ErrorMessage = "Họ tên bắt buộc phải được nhập. Tối thiểu 4 ký tự, tối đa 100 ký tự.")]
        [Display(Name = "Họ tên")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên tối thiểu 4 ký tự, tối đa 100 ký tự.")]
        public string? Name { get; set; } //Họ tên

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email phải được nhập.")]
        [RegularExpression(@"^[^@\s]+@gmail\.com$", ErrorMessage = "Email không hợp lệ.")]
        public string? Email { get; set; } //Email

        [Display(Name = "Mật khẩu")]
        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập.")]
        [RegularExpression(@"(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#%^&*()_+\-=\[\]{};':""\\|,.<>\/?~]).{8,}",
            ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        public string? Password { get; set; } //Mật khẩu

        [Display(Name = "Ngành")]
        [Required(ErrorMessage = "Chưa chọn ngành học")]
        public Branch? Branch { get; set; } //Ngành học

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Chưa chọn giới tính")]
        public Gender? Gender { get; set; } //Giới tính

        [Display(Name = "Chính quy")]
        public bool IsRegular { get; set; } //Hệ: true-chính quy, false-phi chính quy

        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; } //Địa chỉ

        [Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime), "01/01/1963 00:00", "01/01/2006 00:00",
            ErrorMessage = "Ngày sinh phải từ 01/01/1963 - 31/12/2005")]

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Chưa chọn ngày sinh.")]
        public DateTime DateOfBorth { get; set; } //Ngày sinh

        [Display(Name = "Avatar")]
        [AllowNull]
        public string? AvatarUrl { get; set; } // Ảnh đại diện sinh viên

        [DataType(DataType.Currency)]
        //[Required(ErrorMessage = "Bắt buộc nhập điểm.")]
        [Display(Name = "Điểm")]
        [Range(0, 10.0, ErrorMessage = "Điểm phải từ 0.0 - 10.0")]
        public float? Mark { get; set; }
    }
}