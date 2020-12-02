using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Cadastro
{
    public class CadastroModelo
    {
        [Key]
        public int ModeloId { get; set; }
        [Display(Name ="Nome Modelo")]
        []
        public string NomeModelo { get; set; }
        public string Descricao { get; set; }

    }
}
