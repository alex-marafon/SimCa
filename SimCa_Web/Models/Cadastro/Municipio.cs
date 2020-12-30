using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Cadastro
{
    public class Municipio
    {
        [Key]
        public int MunicipioId { get; set; }
        [Required(ErrorMessage = "Informe o Nome do Municipio")]
        [Display(Name = "Municipio")]
        public string NomeMunicipio { get; set; }

    }
}
