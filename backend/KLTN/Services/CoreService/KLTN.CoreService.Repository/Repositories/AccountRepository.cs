using KLTN.CoreService.Repository.Interfaces;
using KLTN.CoreService.Repository.Models;
using KLTN.Shared.DTOs;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.CoreService.Repository.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMongoCollection<Account> _users;

        public AccountRepository(IOptions<MongoDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _users = database.GetCollection<Account>("Accounts");
        }

        public async Task<Account?> GetByEmailAsync(string email)
        {
            return await _users.Find(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task AddAsync(Account user)
        {
            await _users.InsertOneAsync(user);
        }
    }
}
