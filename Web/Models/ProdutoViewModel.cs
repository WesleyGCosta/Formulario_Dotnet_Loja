using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ProdutoViewModel
    {
        [DisplayName("Código")]
        [Required(ErrorMessage = "*O campo Código é obrigatório!!!")]
        public int Codigo { get; set; }

        [DisplayName("Preço")]
        [Required(ErrorMessage = "*O campo Preço é obrigatório!!!")]
        public double Preco{ get; set; }

        [StringLength(30, ErrorMessage = "A Descrição Precisa ter no mínimo 8 letras", MinimumLength = 5)]
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "*O campo Descrição é obrigatório!!!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "*O campo Categoria é obrigatório!!!")]
        public string Categoria { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
    }
}
