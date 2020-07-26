using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models
{
    public class Professores
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string NumeroDocumento { get; set; }

        [MaxLength(20)]
        public string TipoDocumento { get; set; }

        public int PessoaId { get; set; }

        [ForeignKey ("PessoaId")]
        public virtual Pessoas Pessoas { get; set; }

    }
}