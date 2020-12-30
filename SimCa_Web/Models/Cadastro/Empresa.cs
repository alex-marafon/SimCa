using SimCa_Web.Models.Cadastro;
using SimCa_Web.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Empresa
{
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [Required(ErrorMessage ="Informe o Codigo da empresa")]
        [Display(Name ="Codigo Empresa")]
        public int CodigoEmpresa { get; set; }

        [Required(ErrorMessage = "Rasão Social")]
        [Display(Name = "Rasão Social Empresa")]
        public string RasaoSocial { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ")]
        [Display(Name = "CNPJ")]
        public decimal CNPJ { get; set; }

        [Required(ErrorMessage = "Informe a Inscrição Estadual")]
        [Display(Name = "Inscrição Estadual")]
        public decimal EscricaoEstadual { get; set; }

        [Required(ErrorMessage = "Informe o Endereço")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o Numero")]
        [Display(Name = "Numero")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Informe o Bairro")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

    //    [Required(ErrorMessage = "Informe o Bairro")]
        [Display(Name = "Email")]
        public string Email { get; set; }

     //   [Required(ErrorMessage = "Informe o Bairro")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "Informe a Tributação")]
        [Display(Name = "Tributação")]
        public Tributacao Tributacao { get; set; }

       
        public ICollection<Municipio> cadastroMunicipios { get; set; }

        public int CodigoClinteGrupo { get; set; }


    }
}
