using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreCrud.Models
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}
