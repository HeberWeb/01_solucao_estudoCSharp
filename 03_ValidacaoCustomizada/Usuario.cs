using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _03_ValidacaoCustomizada
{
    class Usuario
    {
        [Required(ErrorMessage = "O campo nome é de preenchimento obrigatório!")]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [MyValidationAttribute(ErrorMessage = "O campo senha deve possuir 10 caracteres.")]
        public string Senha { get; set; }
    }
}
