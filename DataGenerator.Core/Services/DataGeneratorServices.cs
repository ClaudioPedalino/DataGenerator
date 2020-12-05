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

        public async Task<List<PersonModel>> GeneratePersonListAsync(uint quantity)
            => await _generator.GetAllPersonListAsync(quantity);

        public async Task<List<ProductModel>> GenerateProductListAsync(uint quantity)
            => await _generator.GetAllProductList(quantity);
    }
}
