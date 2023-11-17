using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration.Shared.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [RegularExpression("\b([A-ZÀ-ÿ][-,a-z. ']+[ ]*)+")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("\b([A-ZÀ-ÿ][-,a-z. ']+[ ]*)+")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$")]
        public string Email { get; set; }
    }
}
