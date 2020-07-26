using SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Context;
using SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Controllers
{
    public class DisciplinaController : Controller
    {
        SGAPContext dbContext = new SGAPContext();
        // GET: Disciplina
        public ActionResult CadastroDisciplina()
        {                  
            return View();
        }
        public JsonResult Salvar(Disciplinas disciplina)
        {
            dbContext.Disciplinas.Add(disciplina);
            dbContext.SaveChanges();
            return Json("Disciplina Cadastrada com Sucesso!");
        }
        public ActionResult ListaDisciplinas()
        {
            return View();
        }

        public JsonResult GetDisciplinas()
        {
            var lstDisciplinas= dbContext.Disciplinas.ToList();
            
            return Json(lstDisciplinas);

        }
        public JsonResult Excluir(int Id)
        {
            var disciplina = dbContext.Disciplinas.FirstOrDefault(a => a.Id == Id);
            dbContext.Disciplinas.Remove(disciplina);
            dbContext.SaveChanges();
            return Json("Excluído com Sucesso!");
        }

        
    }
}