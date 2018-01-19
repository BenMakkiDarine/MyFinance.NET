using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfinance.domain.Entities
{
    public class Product
    {


        public  int ProductId { get; set; }
      

        [Display(Name ="Production Date")]
        [DataType(DataType.Date)]
        public DateTime DateProduction { get; set; }

        [Required]
        [StringLength(25,ErrorMessage ="Vous devez saisir 25 ")]
        [MaxLength(50,ErrorMessage ="50")]
        public String Name { get; set; }

        [DataType(DataType.Currency)]
        public float Price { get; set; }

        [Range(0,int.MaxValue,ErrorMessage ="Positive")]
        public int Quantity { get; set; }
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
        public virtual ICollection<Provider> providers { get; set; }

        public string ImageName { get; set; }

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category category { get; set; }

    }
}
