namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Enderecomaxlengt500 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Endereco", c => c.String(maxLength: 500, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Endereco", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
