using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Identity
{
    public static class ClaimStore
    {
        public static List<Claim> FirstClaimList = [
            new Claim("First Claim" , "الصلاحية الاولى"),
            new Claim("Second Claim" , "الصلاحية الثانية"),
        ];

        public static List<Claim> SecondClaimList = [
             new Claim("First Claim" , "الصلاحية الاولى"),
            new Claim("Second Claim" , "الصلاحية الثانية"),
        ];

    }
}