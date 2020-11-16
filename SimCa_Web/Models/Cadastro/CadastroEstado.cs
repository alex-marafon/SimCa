using SimCa_Web.Models.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Cadastro
{
    public class CadastroEstado
    {
        [Key]
        public int CategoriaId { get; set; }
        [Display(Name = "Estado - UF ")]
        public string Estado { get; set; }

        public int EmpresaId { get; set; }
        public CadastroEmpresa CadastroEmpresa { get; set; }
    }
}
