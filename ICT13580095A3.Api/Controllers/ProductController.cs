using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ICT13580095A3.Api.Data;
using ICT13580095A3.Api.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ICT13580095A3.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        MyDbContext db;
        IHostingEnvironment env;

        public ProductController(MyDbContext db,IHostingEnvironment env)
        {
            this.db = db;
            this.env = env;
        }



        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return db.Products;
        }
    }
}
