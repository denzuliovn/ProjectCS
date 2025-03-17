using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClass
{
    public class AccountMember
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MenberID { get; set; }
        [Required]
        [StringLength(11)]
        public string MemberPassword { get; set; }
        [Required]
        public string Fullname { get; set; }
        public int MemberRole { get; set; }

    }
}
