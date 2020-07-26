using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models
{
    public class ProfessoresDisciplinas
    {
        [Key]
        public int Id { get; set; }
        public int ProfessorId { get; set; }

        [ForeignKey("ProfessorId")]
        public virtual Professores Professores { get; set; }

        public int DisciplinaId { get; set; }

        [ForeignKey("DisciplinaId")]
        public virtual Disciplinas Disciplinas { get; set; }


    }
}