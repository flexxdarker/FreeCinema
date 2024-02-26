using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IAccountsService
    {
        Task Register(RegisterModel model);
        Task Login(LoginModel model);
        Task Logout();

        //Task<ResetToken> GenerageResetToken(string email);
        //Task ResetPassword(ResetPasswordModel model);
    }

    // TODO: create endpoints for resetting user password 
    public class ResetToken
    {
        public string Token { get; set; }
    }
    public class ResetPasswordModel
    {
        public string NewPassword { get; set; }
        public string Token { get; set; }
    }
}
