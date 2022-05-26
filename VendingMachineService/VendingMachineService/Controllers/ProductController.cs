using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendingMachineService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new List<Product>()
            {
                {new Product()
                    {
                    Name = "Soda",
                    Price = .95m,
                    NumberAvailable = 10

                    }
                },
                {new Product()
                    {
                    Name = "Candy Bar",
                    Price = .60m,
                    NumberAvailable = 10
                    }
                },
                {new Product()
                    {
                    Name = "Chips",
                    Price = .99m,
                    NumberAvailable = 10
                    }
                }

            };
        }


    }
}
