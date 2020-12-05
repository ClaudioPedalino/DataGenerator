using DataGenerator.Core.Models;
using DataGenerator.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGenerator.Core.Interfaces
{
    public interface IDataGeneratorServices
    {
        Task<List<PersonModel>> GeneratePersonListAsync(uint quantity = 1);
        Task<List<ProductModel>> GenerateProductListAsync(uint quantity = 1);
    }
}