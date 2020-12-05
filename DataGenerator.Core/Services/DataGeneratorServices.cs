using DataGenerator.Core.Interfaces;
using DataGenerator.Core.Models;
using DataGenerator.Data.Interfaces;
using DataGenerator.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGenerator.Core.Services
{
    public class DataGeneratorServices : IDataGeneratorServices
    {
        private readonly IGenerator _generator;

        public DataGeneratorServices(IGenerator generator)
        {
            _generator = generator;
        }

        /// <summary>
        /// Generate a random list of people with sanitized information
        /// </summary>
        /// <param name="quantity">Amount of results [Default 3]</param>
        /// <returns></returns>
        public async Task<List<PersonModel>> GeneratePersonListAsync(uint quantity = 3)
            => await _generator.GetAllPersonListAsync(quantity);

        /// <summary>
        /// Generate a random list of products with sanitized information
        /// </summary>
        /// <param name="quantity">Amount of results [Default 3]</param>
        /// <returns></returns>
        public async Task<List<ProductModel>> GenerateProductListAsync(uint quantity = 3)
            => await _generator.GetAllProductList(quantity);
    }
}
