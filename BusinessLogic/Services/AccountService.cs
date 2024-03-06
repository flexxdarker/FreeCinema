using AutoMapper;
using BusinessLogic.DTOs;
using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using DataAccess.Repostories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    internal class AccountsService : IAccountsService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IMapper mapper;
        private readonly IRepository<RefreshToken> refreshTokenR;
        public AccountsService(UserManager<User> userManager,
                                SignInManager<User> signInManager,
                                IRepository<RefreshToken> refreshTokenR
                                ,IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.refreshTokenR = refreshTokenR;
            this.mapper = mapper;
        }

        public async Task Register(RegisterModel model)
        {
            // TODO: validation

            // check user
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
                throw new HttpException("Email is already exists.", HttpStatusCode.BadRequest);

            // create user
            var newUser = mapper.Map<User>(model);
            var result = await userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
                throw new HttpException(string.Join(" ", result.Errors.Select(x => x.Description)), HttpStatusCode.BadRequest);
        }

        public async Task Login(LoginModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
                throw new HttpException("Invalid user login or password.", HttpStatusCode.BadRequest);

            await signInManager.SignInAsync(user, true);
        }
        public async Task<UserTokens> RefreshTokens(UserTokens userTokens)
        {
            var refrestToken = await refreshTokenR.GetItemBySpec(new RefreshTokenSpecs.ByToken(userTokens.RefreshToken));

            if (refrestToken == null)
                throw new HttpException(Errors.InvalidToken, HttpStatusCode.BadRequest);

            var claims = jwtService.GetClaimsFromExpiredToken(userTokens.AccessToken);
            var newAccessToken = jwtService.CreateToken(claims);
            var newRefreshToken = jwtService.CreateRefreshToken();

            refrestToken.Token = newRefreshToken;

            // TODO: update creation time
            refreshTokenR.Update(refrestToken);
            refreshTokenR.Save();

            var tokens = new UserTokens()
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            };

            return tokens;
        }

        public async Task Logout(string refreshToken)
        {
            await signInManager.SignOutAsync();
        }
    }
}
