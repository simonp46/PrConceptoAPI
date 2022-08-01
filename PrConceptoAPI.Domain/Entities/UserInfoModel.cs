using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConceptoAPI.Domain.Entities
{
    [Keyless] 
    public class UserInfoModel
    {
        public string? UserName { get; set; }
        public string? PwdUser { get; set; }    
    }
}
