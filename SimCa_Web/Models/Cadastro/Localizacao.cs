﻿using SimCa_Web.Models.Empresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimCa_Web.Models.Cadastro
{
    public class Localizacao
    {
        [Key]
        public int CategoriaId { get; set; }
        [Display(Name = "Local (Armazenamento Fisico) ")]
        public string LocalArmazenado { get; set; }

    }
}
