using DataGenerator.Core.Interfaces;
using DataGenerator.Core.Models;
using DataGenerator.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DataGenerator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataGeneratorController : ControllerBase
    {
        private readonly IDataGeneratorServices _dataGeneratorServices;

        public DataGeneratorController(IDataGeneratorServices dataGeneratorServices)
        {
            _dataGeneratorServices = dataGeneratorServices;
        }

        #region Persons
        [HttpGet("persons")]
        public async Task<IEnumerable<PersonModel>> GetAllPersonListAsync([FromQuery] uint quantity = 3)
        {
            var response = await _dataGeneratorServices.GeneratePersonListAsync(quantity);

            return response;
        }

        [HttpGet("person/id")]
        public async Task<PersonModel> GetPersonByIdAsync([FromQuery] uint id)
        {
            var response = await _dataGeneratorServices.GeneratePersonListAsync(1);

            return response.FirstOrDefault();
        }
        #endregion


        #region Products
        [HttpGet("products")]
        public async Task<IEnumerable<ProductModel>> GetAllProductListAsync([FromQuery] uint quantity = 3)
        {
            var response = await _dataGeneratorServices.GenerateProductListAsync(quantity);

            return response;
        }

        [HttpGet("product/id")]
        public async Task<ProductModel> GetProductByIdAsync([FromQuery] uint id)
        {
            var response = await _dataGeneratorServices.GenerateProductListAsync(1);

            return response.FirstOrDefault();
        }
        #endregion


    }
}
