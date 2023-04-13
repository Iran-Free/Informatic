
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_mvc.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "پر کردن این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل کاراکتر وارد شده سه حرف می باشد")]
        [MaxLength(9,ErrorMessage = "حداکثر تعداد کاراکترها 9 حرف می باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage = "پر کردن این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نمی باشد")]
        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

    }
}
