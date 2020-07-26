using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models
{
    public class Disciplinas
    {
       [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(2)]
        public string Periodo { get; set; }

    }
}