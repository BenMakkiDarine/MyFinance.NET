using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myfinance.domain.ComplexType;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myfinance.domain.Entities
{
    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Compare(nameof(Password),ErrorMessage ="Mot de passe non valide")]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        public bool IsApproved { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Product> products { get; set; }

    }
}
