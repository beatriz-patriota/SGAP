namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Context.SGAPContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Context.SGAPContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
