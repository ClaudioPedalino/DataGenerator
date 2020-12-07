using DataGenerator.Core.Models;
using DataGenerator.Data.Interfaces;
using DataGenerator.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace DataGenerator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGeneratorController : ControllerBase
    {
        private readonly IGenerator _generator;

        public DataGeneratorController(IGenerator generator)
        {
            _generator = generator ?? throw new System.ArgumentNullException(nameof(generator));
        }

        [HttpGet("persons")]
        public async Task<IEnumerable<PersonModel>> GetAllPersonListAsync([FromQuery] uint quantity = 3)
        {
            var response = await _generator.GeneratePersonListAsync(quantity);

            return response;
        }

        [HttpGet("products")]
        public async Task<IEnumerable<ProductModel>> GetAllProductListAsync([FromQuery] uint quantity = 3)
        {
            var response = await _generator.GenerateProductListAsync(quantity);

            return response;
        }


    }
}
