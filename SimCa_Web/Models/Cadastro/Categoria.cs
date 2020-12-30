using SimCa_Web.Models.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Cadastro
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Display(Name="Descrição Categória")]
        public string CategoriaDescricao { get; set; }

    }
}
