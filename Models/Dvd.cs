using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Dvd
    {
        [Key]
        public int IDDvd{ get; set; }

        [Required(ErrorMessage ="Digite o Titulo do DVD")]
        [StringLength(50, ErrorMessage = "O tamanho minimo de caracteres é {1}.", MinimumLength = 6)]
        public string Titulo { get; set; }

        public string Categoria { get; set; }

        public string Observacao { get; set; }
    }
}