using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResturenModels;
using ResturentRepository;
using System.Runtime.InteropServices;

namespace ResturentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public readonly IRepositoryResturent _irepositoryResturent;
        public AccountController(IRepositoryResturent repositoryResturent)
        {
            _irepositoryResturent = repositoryResturent;
        }


        [HttpGet]
        [Route("GetAccount")]
        public async Task<IActionResult> GerAccount()
        {
            var account = await _irepositoryResturent.GetAll();
            return Ok(account);
        }

        [HttpPost]
        [Route("PostAccount")]
        public IActionResult PsostAccount(Account oAccount)
        {
            oAccount.ObjGuid = Guid.NewGuid();
            var account = _irepositoryResturent.addAccount(oAccount);
            return Ok(account);
        }


        [HttpPost]
        [Route("UpdateAccount")]

        public Account UpdateAccount(Account oAccount)
        {
             _irepositoryResturent.Update(oAccount);
            return oAccount;
        }


    }
}
