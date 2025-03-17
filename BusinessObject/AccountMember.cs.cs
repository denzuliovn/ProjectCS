using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject
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
