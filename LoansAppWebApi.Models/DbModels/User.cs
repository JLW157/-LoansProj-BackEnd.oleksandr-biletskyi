﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansAppWebApi.Models.DbModels
{
    public class User : IdentityUser<Guid>
    {
        public ICollection<Loans> Loans { get; set; }
    }
}
