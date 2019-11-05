using System;
using System.ComponentModel.DataAnnotations; //validar a tela
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhaPrimeiraAplicacaoMVC.Models
{
    public class EstagiarioModel
    {
        [Required(
            AllowEmptyStrings=false, 
            ErrorMessage="O nome é obrigatório!")]
        [Display(Name="Nome")]
        [StringLength(100, ErrorMessage="O máximo de caracteres é 100")]
        public string Nome { get; set; }

        [Required(
            AllowEmptyStrings=false,
            ErrorMessage="A idade é obrigatória")]
        [Display(Name="Idade")]
        [Range(18, 25, ErrorMessage="Você é muito velho")]
        public int Idade { get; set; }
    }
}