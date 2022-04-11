using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadastroTeste.Models
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}