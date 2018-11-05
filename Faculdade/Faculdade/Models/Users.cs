//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faculdade.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        public int id_user { get; set; }

        [DisplayName("Nome")]
        public string name { get; set; }

        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [DisplayName("Registro")]
        [Required(ErrorMessage = "Campo obrigatorio!")]
        public long register { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Campo obrigatorio!")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
