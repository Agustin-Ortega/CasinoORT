using CasinoOrt.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoOrt.Context
{
    public class CasinoContext : DbContext
    {

        public CasinoContext(DbContextOptions<CasinoContext> options) : base(options)
        {

        }

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Informe> informes { get; set; }
    }
}
