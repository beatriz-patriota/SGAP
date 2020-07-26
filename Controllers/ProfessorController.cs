using SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Controllers
{
    public class ProfessorController : Controller
    {
        SGAPContext dbContext = new SGAPContext();
        // GET: Professor
        public ActionResult LstProfessor()
        {
            return View();
        }
        public JsonResult GetProfessores()
        {
            var lstProfessores = dbContext.Professores.ToList();
            return Json(lstProfessores);
        }
        public JsonResult Excluir(int Id, int PessoaId)
        {
            var professor = dbContext.Professores.FirstOrDefault(a => a.Id == Id);
            dbContext.Professores.Remove(professor);
            var pessoa = dbContext.Pessoas.FirstOrDefault(a => a.Id == PessoaId);
            dbContext.Pessoas.Remove(pessoa);
            dbContext.SaveChanges();
            return Json("Excluído com Sucesso");

        }
    }
}