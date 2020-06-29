using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSHOP.Models.ViewsModel
{
    public class FailViewsModel
    {
          public string Name { get; set; }
          public IFormFile Avatar { get; set; }
    }
}
