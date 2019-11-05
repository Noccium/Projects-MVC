using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppValidaIdade.Models
{
    public class HomeModel
    {
        [Required(
            AllowEmptyStrings = false,
            ErrorMessage = "O nome é obrigatório!")]
        [Display(Name = "Nome")]
        public string campoNome { get; set; }

        [Required(
            AllowEmptyStrings = false,
            ErrorMessage = "A idade é obrigatória!")]
        [Display(Name = "Idade")]
        public int campoIdade { get; set; }
    }
}