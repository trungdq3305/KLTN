using KLTN.CoreService.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.CoreService.Repository.Interfaces
{
    public interface IAccountRepository
    {
        Task<Account?> GetByEmailAsync(string email);
        Task AddAsync(Account user);
    }
}
