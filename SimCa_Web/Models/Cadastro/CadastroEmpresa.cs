using SimCa_Web.Models.Cadastro;
using SimCa_Web.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Empresa
{
    public class CadastroEmpresa
    {
        public int EmpresaId { get; set; }
        public int CodigoEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public decimal CNPJ { get; set; }
        public decimal EscricaoEstadual { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }


        public string Email { get; set; }
        public string TelefoneCel { get; set; }
        public string TelefoneFixo { get; set; }

        public Tributacao Tributacao { get; set; }



        public ICollection<CadastroMunicipio> cadastroMunicipios { get; set; }

        public int CodigoClinteGrupo { get; set; }


    }
}
