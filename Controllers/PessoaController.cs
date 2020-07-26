using SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Context;
using SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Controllers
{
    public class PessoaController : Controller
    {
        SGAPContext dbContext = new SGAPContext();
        // GET: Pessoas
        public ActionResult Cadastro()
        {
            return View();
        }
        public JsonResult Salvar(Pessoas pessoa, string tipo, Professores professor)
        {
            //A variável p traz do banco de dados na tabela Pessoas o primeiro registro que tem o cpf igual ao cpf digitado pelo usuário. 
            // a.cpf = da tabela do banco da dados.
            // pessoa.cpf = o que o usuário digitou. 
            var p = dbContext.Pessoas.FirstOrDefault(a => a.Cpf == pessoa.Cpf);
            // Se o cpf (variável p) for diferente de nulo, ou seja já consta na tabela. Então retorna "CPF já cadastrado."
            if(p != null)
            {
                return Json("CPF já cadastrado.");
            }
            //Se o cpf for nulo, não consta na tabela, a pessoa pode se cadastrar.
            dbContext.Pessoas.Add(pessoa);
            dbContext.SaveChanges();

            p = dbContext.Pessoas.FirstOrDefault(a => a.Cpf == pessoa.Cpf);
            if (tipo == "Aluno")
            {
                Alunos aluno = new Alunos();
                aluno.PessoaId = p.Id;
                dbContext.Alunos.Add(aluno);
                dbContext.SaveChanges();
            }
            else if (tipo == "Professor")
            {
                professor.PessoaId = p.Id;
                dbContext.Professores.Add(professor);
                dbContext.SaveChanges();
            }
            return Json("Salvo com Sucesso!");

        }

    }
}