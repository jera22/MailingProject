using System;
using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class MailDTO
    {
        public Guid Id {  get; set; }
        [Required(ErrorMessage = "From field is required")]
        [EmailAddress(ErrorMessage ="Email format is invalid")]
        public string From { get; set; }
        [Required(ErrorMessage = "To field is required")]
        [EmailAddress(ErrorMessage = "Email format is invalid")]
        public string To { get; set; }
        [RegularExpression(pattern: "^((\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)\\s*[;]{0,1}\\s*)+$",ErrorMessage ="Format of CC field needs to be something@example.com;somethingelse@example.com;")]
        public string CC { get; set; }
        [Required(ErrorMessage ="Subject is required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Body is required")]
        public string Body { get; set; }
        public ImportanceEnum Importance { get; set; }
    }

    public enum ImportanceEnum
    {
        Low,
        Medium,
        Important
    }
}
