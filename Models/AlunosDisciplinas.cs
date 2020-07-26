using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models
{
    public class AlunosDisciplinas
    {
        [Key]
        public int Id { get; set; }
        public int AlunoId { get; set; }
        
        [ForeignKey("AlunoId")]
        public virtual Alunos Alunos { get; set; }

        public int DisciplinaId { get; set; }

        [ForeignKey("DisciplinaId")]
        public virtual Disciplinas Disciplinas { get; set; }

    }
}