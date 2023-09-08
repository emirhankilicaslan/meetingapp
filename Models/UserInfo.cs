using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace meetingapp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alani zorunludur.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon alani zorunludur.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email alani zorunludur.")]
        [EmailAddress(ErrorMessage = "Hatali email !")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katilim durumunuzu belirtiniz.")]
        public bool? WillAttend { get; set; }
    }
}