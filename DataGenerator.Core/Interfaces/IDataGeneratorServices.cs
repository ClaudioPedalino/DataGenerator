using DataGenerator.Core.Models;
using DataGenerator.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGenerator.Core.Interfaces
{
    public interface IDataGeneratorServices
    {
        Task<List<PersonModel>> GeneratePersonListAsync(uint quantity);
        Task<List<ProductModel>> GenerateProductListAsync(uint quantity);
    }
}