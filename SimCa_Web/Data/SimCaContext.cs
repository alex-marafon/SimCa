using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimCa_Web.Models.Cadastro;

namespace SimCa_Web.Data
{
    public class SimCaContext : DbContext
    {
        public SimCaContext (DbContextOptions<SimCaContext> options)
            : base(options)
        {
        }

        public DbSet<SimCa_Web.Models.Cadastro.CadastroCategoria> CadastroCategoria { get; set; }
    }
}
