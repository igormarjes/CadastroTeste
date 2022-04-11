using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadastroTeste.Models
{
    public class Cadastro : BaseModel
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        
        public bool Status { get; set; }
    }
}