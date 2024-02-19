using Microsoft.EntityFrameworkCore;
using ResturenModels;
using ResturentInfrastructure;
using System.Runtime.InteropServices;

namespace ResturentRepository
{
    public class RepositoryResturent : IRepositoryResturent
    {
        public readonly ResturentDataBase _DbContex;
        public RepositoryResturent(ResturentDataBase dbcontext)
        {
            _DbContex = dbcontext;
        }
        public async Task<IEnumerable<Account>> GetAll()
        {
            var account = await _DbContex.Account.ToListAsync();
            return account;
        }
        public async Task<Account> addAccount(Account account)
        {
            var result =  _DbContex.Account.Add(account);
             _DbContex.SaveChanges();
            if (result != null)
            {
                return new Account();
            }
            return new Account();
        }
        public async Task<Account> Update(Account Oaccount)
        {
            var Store = _DbContex.Account.Find(Oaccount.ObjectID);
            if(Store != null)
            {
                _DbContex.Account.Update(Oaccount);
                _DbContex.SaveChanges();
            }
            else
            {
                Oaccount.Name = "data Not Fond";  
            }
            return Oaccount;
        }

        public Task<Account> GetById(int Id)
        {
            throw new NotImplementedException();
        }
        public Task DeleteById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
