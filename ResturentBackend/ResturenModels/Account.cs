using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturenModels
{
    public class Account
    {
        public Account()
        {
            ObjectID = 0;
            ObjGuid = Guid.Empty;
            Name = "";
            Phone = "";
            Email = "";
            Address = "";
        }

        [Key]
        public int ObjectID { get; set; }
        public Guid ObjGuid { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
