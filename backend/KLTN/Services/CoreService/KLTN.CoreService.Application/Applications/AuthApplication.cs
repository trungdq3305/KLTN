using KLTN.CoreService.Application.DTOs.AuthDtos;
using KLTN.CoreService.Application.Interfaces;
using KLTN.CoreService.Common.Helpers;
using KLTN.CoreService.Repository.Interfaces;
using KLTN.CoreService.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.CoreService.Application.Applications
{
    public class AuthApplication : IAuthApplication
    {
        private readonly IAccountRepository _accountRepo;
        private readonly JwtTokenHelper _jwtHelper;

        public AuthApplication(IAccountRepository userRepo, JwtTokenHelper jwtHelper)
        {
            _accountRepo = userRepo;
            _jwtHelper = jwtHelper;
        }

        public async Task<string?> LoginAsync(LoginRequest request)
        {
            var account = await _accountRepo.GetByEmailAsync(request.Email);
            if (account == null || !VerifyPasswordHash(request.Password, account.Password))
                return null;

            return _jwtHelper.GenerateToken(account);
        }

        public async Task<bool> RegisterAsync(RegisterRequest request)
        {
            var existingUser = await _accountRepo.GetByEmailAsync(request.Email);
            if (existingUser != null)
                return false;

            var acc = new Account
            {
                Id = null,
                Email = request.Email,
                Password = HashPassword(request.Password),
                RoleId = request.Role
            };

            await _accountRepo.AddAsync(acc);
            return true;
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }

        private bool VerifyPasswordHash(string password, string storedHash)
        {
            return HashPassword(password) == storedHash;
        }
    }
}
