using KLTN.CoreService.Application.DTOs.AuthDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.CoreService.Application.Interfaces
{
    public interface IAuthApplication
    {
        Task<string?> LoginAsync(LoginRequest request);
        Task<bool> RegisterAsync(RegisterRequest request);
    }
}
