using SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Controllers
{
    public class AlunoController : Controller
    {
        SGAPContext dbContext = new SGAPContext();
        // GET: Aluno
        public ActionResult LstAlunos()
        {
            return View();
        }
        public JsonResult GetAlunos()
        {
            var lstAlunos = dbContext.Alunos.ToList();
            return Json(lstAlunos);
        }
        public JsonResult Excluir(int Id, int PessoaId)
        {
            var aluno = dbContext.Alunos.FirstOrDefault(a => a.Id == Id);
            dbContext.Alunos.Remove(aluno);
            var pessoa = dbContext.Pessoas.FirstOrDefault(a => a.Id == PessoaId);
            dbContext.Pessoas.Remove(pessoa);
            dbContext.SaveChanges();
            return Json("Excluído com Sucesso!");
        }
    }
}