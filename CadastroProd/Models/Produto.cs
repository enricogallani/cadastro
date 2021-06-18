using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web;


namespace CadastroProd.Models
{
    public class Produto 
    {
        
        [Display (Name = "Nº Código")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O nome do produto é obrigatório!")]
        public string NomeProd { get; set; }


        [Required(ErrorMessage = "Insira a descrição do produto")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Insira uma descrição de no minímo 10 caracteres e no máximo 200 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O peso do produto é obrigatório!")]
        [Range(1.00, 18.99, ErrorMessage = "O peso do produto é inválido!")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Insira a categoria do produto")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "O valor da unidade do produto é obrigatório!")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "O valor da unidade do produto é inválido!")]
        public string ValorUnit { get; set; }
    }
}