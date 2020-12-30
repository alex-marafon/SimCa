using SimCa_Web.Models.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Cadastro
{
    public class Caixa
    {
        public int CaixaId { get; set; }

        
        [Display(Name="Empresa")]
        public int EmpresaId { get; set; }
        public Empresa.Empresa CadastroEmpresa { get; set; }


        [Display(Name = "Informe empresa Agrupadora")]
        public List<Empresa.Empresa> Empresas { get; set; }



    }
}
