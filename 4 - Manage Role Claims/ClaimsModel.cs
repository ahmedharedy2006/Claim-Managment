using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application
{
    public class ClaimsModel
    {
        public int RoleId { get; set; }

        public List<ClaimSelection> FirstClaimsList { get; set; } = new();
       
        public ClaimsModel()
        {
            FirstClaimsList = [];
            
        }

    }

    public class ClaimSelection
    {
        public string ClaimType { get; set; }
        public string? Label { get; set; }
        public bool IsSelected { get; set; }
    }
}