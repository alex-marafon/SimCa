using SimCa_Web.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Cadastro
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Usúario")]
        [Display(Name = "Nome Usúario")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string SenhaUsuario { get; set; }

        [Required(ErrorMessage = "Informe a Confirmação de senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmação Senha")]
        public string SenhaUsuarioConfirmacao { get; set; }

        [Required(ErrorMessage = "Informe a Confirmação de senha")]
        [Display(Name = "")]
        public TipoUsuario TipoUsuario { get; set; }
    }

    

    
}
