using SimCa_Web.Models.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Empresa
{
    public class CadastroEmpresa
    {

       
        
        
        public ICollection<CadastroCategoria> cadastroCategoria { get; set; }
        public ICollection<CadastroEstado> cadastroEstado { get; set; }
        public ICollection<CadastroLocalizacao> cadastroLocalizacao { get; set; }
    }
}
