using SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Context
{
    public class SGAPContext : DbContext
    {
        public SGAPContext() : base("Name=conn")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(a => a.HasColumnType("varchar"));
        }

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<AlunosDisciplinas> AlunosDisciplinas { get; set; }
        public DbSet<Disciplinas> Disciplinas { get; set; }
        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<Professores> Professores { get; set; }
        public DbSet<ProfessoresDisciplinas> ProfessoresDisciplinas { get; set; }

    }
}