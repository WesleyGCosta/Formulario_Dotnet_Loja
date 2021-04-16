using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ClienteViewModel
    {
        [Required(ErrorMessage = "* O campo Nome é Obrigatório!!!")]
        [StringLength(30, ErrorMessage = "O nome Precisa ter no mínimo 5 letras", MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "* O campo Cpf é Obrigatório!!!")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        public string Sexo { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Número")]
        public int Numero { get; set; }

        public string Bairro { get; set; }
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "* O campo Telefone é Obrigatório!!!")]
        public string Telefone { get; set; }

    }
}
