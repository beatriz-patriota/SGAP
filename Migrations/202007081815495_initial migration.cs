namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50, unicode: false),
                        Endereco = c.String(maxLength: 50, unicode: false),
                        Telefone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Cpf = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AlunosDisciplinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlunoId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alunos", t => t.AlunoId, cascadeDelete: true)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId, cascadeDelete: true)
                .Index(t => t.AlunoId)
                .Index(t => t.DisciplinaId);
            
            CreateTable(
                "dbo.Disciplinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50, unicode: false),
                        Periodo = c.String(maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumeroDocumento = c.String(maxLength: 30, unicode: false),
                        TipoDocumento = c.String(maxLength: 20, unicode: false),
                        PessoaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.PessoaId, cascadeDelete: true)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.ProfessoresDisciplinas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfessorId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Disciplinas", t => t.DisciplinaId, cascadeDelete: true)
                .ForeignKey("dbo.Professores", t => t.ProfessorId, cascadeDelete: true)
                .Index(t => t.ProfessorId)
                .Index(t => t.DisciplinaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProfessoresDisciplinas", "ProfessorId", "dbo.Professores");
            DropForeignKey("dbo.ProfessoresDisciplinas", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.Professores", "PessoaId", "dbo.Pessoas");
            DropForeignKey("dbo.AlunosDisciplinas", "DisciplinaId", "dbo.Disciplinas");
            DropForeignKey("dbo.AlunosDisciplinas", "AlunoId", "dbo.Alunos");
            DropForeignKey("dbo.Alunos", "PessoaId", "dbo.Pessoas");
            DropIndex("dbo.ProfessoresDisciplinas", new[] { "DisciplinaId" });
            DropIndex("dbo.ProfessoresDisciplinas", new[] { "ProfessorId" });
            DropIndex("dbo.Professores", new[] { "PessoaId" });
            DropIndex("dbo.AlunosDisciplinas", new[] { "DisciplinaId" });
            DropIndex("dbo.AlunosDisciplinas", new[] { "AlunoId" });
            DropIndex("dbo.Alunos", new[] { "PessoaId" });
            DropTable("dbo.ProfessoresDisciplinas");
            DropTable("dbo.Professores");
            DropTable("dbo.Disciplinas");
            DropTable("dbo.AlunosDisciplinas");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Alunos");
        }
    }
}
