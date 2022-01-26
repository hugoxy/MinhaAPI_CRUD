using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAPI.Controllers.Model
{
    public class Fornecedor
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage =" O campo {0} orecusa ter ebtre {2} e {1} caracteres", MinimumLength = 1)]

        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(14, ErrorMessage = " O campo {0} orecusa ter ebtre {2} e {1} caracteres", MinimumLength = 1)]

        public string Documento { get; set; }

        public int TipoFornecedor { get; set; }

        public bool Ativo { get; set; }


    }
}
