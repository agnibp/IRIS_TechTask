using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class BankDetail
    {
        [Column(TypeName = "integer")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bank_id { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(30)]
        public string bank_name { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLength(15)]
        public string bank_head_office_location { get; set; }
    }
}
