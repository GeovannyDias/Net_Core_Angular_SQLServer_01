using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

// Ctrl + R + G → Eliminar usings o bibliotecas que no se esten utilizando

namespace server.Models
{
    [Table("CreditCard")]
    public class CreditCard
    {
        // [Key, Column(Order = 0)]
        // [Key] si id tiene otro nombre "CardId" se debe colocar esta data annotation
        public int Id { get; set; }

        [Required(ErrorMessage = "Field required")]
        [MaxLength(150)]
        public string Titular{ get; set; }

        [Required]
        [Column("NumberCard")]
        [MaxLength(25)]
        public string NumberCard { get; set; }

        [Required]
        [MaxLength(25)]
        public string ExpirationDate { get; set; }

        [Required]
        [StringLength(4)] // es = [MaxLength(25)]
        public string CVV { get; set; }




        /*
            [Table("tuTabla")]
            public class TablaEntity
            {
                [Key, Column(Order = 0)]
                [Required]
                public int ID { get; set; }

                [Required(ErrorMessage = "Debe Ingresar Un Nombre.")]
                [StringLength(255, ErrorMessage = "{0} la longitud debe estar entre {2} y {1}.", MinimumLength = 4)]
                [Display(Name = "Nombre")]
                public string NOMBRE { get; set; }


                [Required(ErrorMessage = "Debe Ingresar Un Valor.")]
                [Range(1, 100000)]
                [Display(Name = "Valor")]
                public int VALOR { get; set; }
         */

    }
}
