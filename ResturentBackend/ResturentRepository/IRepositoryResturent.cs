using ResturenModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturentRepository
{
    public interface IRepositoryResturent
    {
        Task<IEnumerable<Account>> GetAll();
        Task<Account> addAccount(Account account);
        Task<Account> GetById(int Id);
        Task<Account> Update(Account Oaccount);
        Task DeleteById(int Id);
    }
}
