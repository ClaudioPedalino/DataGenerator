using DataGenerator.Core.Models;
using DataGenerator.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGenerator.Data.Interfaces
{
    public interface IGenerator
    {
        Task<List<PersonModel>> GetAllPersonListAsync(uint quantity);
        Task<List<ProductModel>> GetAllProductList(uint quantity);
    }
}
