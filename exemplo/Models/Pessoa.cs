using System.ComponentModel.DataAnnotations;

namespace exemplo.Models
{
    public class Pessoa
    {
        [Display (Name = "Código do Cliente")]

        public int PessoaId
        {
            /*o get é um metodo que retorna um valor atual de um atributo, o set permite definer ou modificar o valor do atributo*/
            get; set;
        }
        [Display(Name = "Nome do Cliente")]
        /*a interrogação informa que o campo esta null*/
        public string? Nome
        {
            get; set;
        }
        [Display(Name = "Email do Cliente")]
        public string? Email
        {

            get; set;
        }
    }
}
