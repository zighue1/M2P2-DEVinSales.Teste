using System.ComponentModel.DataAnnotations;

namespace DevInSales.api.DTOs
{

    /// <summary>
    /// DTO que representa as informações de login do usuário
    /// </summary>
    public class UserLoginDTO
    {

            /// <summary>
            /// O id do usuário
            /// </summary>
            [Display(Name = "id")]
            public int Id { get; set; }

            /// <summary>
            /// Senha do usuário
            /// </summary>
            [Display(Name = "Password")]
            public string Password { get; set; }

           
        
    }
}
