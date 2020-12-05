using DataGenerator.Core.Models;
using DataGenerator.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataGenerator.Core.Interfaces
{
    public interface IDataGeneratorServices
    {

        /// <summary>
        /// Generate a random list of people with sanitized information
        /// </summary>
        /// <param name="quantity">Quantity of results wanted [Default 3]</param>
        /// <returns></returns>
        Task<List<PersonModel>> GeneratePersonListAsync(uint quantity = 3);

        /// <summary>
        /// Generate a random list of people with sanitized information
        /// </summary>
        /// <param name="quantity">Quantity of results wanted [Default 3]</param>
        /// <returns></returns>
        Task<List<ProductModel>> GenerateProductListAsync(uint quantity = 3);
    }
}