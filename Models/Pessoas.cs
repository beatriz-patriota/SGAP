using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGAP_Sistema_de_Gerenciamento_de_Alunos_e_Professores.Models
{
    public class Pessoas
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(500)]
        public string Endereco { get; set; }

        [MaxLength(20)]
        public string Telefone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }

        [MaxLength(20)]
        public string Cpf { get; set; }

    }
}