using Bogus;
using DataGenerator.Core.Models;
using DataGenerator.Data.Enums;
using DataGenerator.Data.Interfaces;
using DataGenerator.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGenerator.Data
{
    public class Generator : IGenerator
    {
        public Task<List<PersonModel>> GetAllPersonListAsync(uint quantity)
            => Task.FromResult(
                    new Faker<PersonModel>()
                    .RuleFor(x => x.PersonId, f => Guid.NewGuid())
                    .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                    .RuleFor(x => x.LastName, f => f.Person.LastName)
                    .RuleFor(x => x.Age, f => f.Random.UInt(16, 80))
                    .RuleFor(x => x.Birthday, f => f.Date.PastOffset(80))
                    .RuleFor(x => x.Email, f => f.Person.Email)
                    .RuleFor(x => x.Avatar, f => f.Person.Avatar)
                    .RuleFor(x => x.City, f => f.Person.Address.City)
                    .RuleFor(x => x.Address, f => f.Person.Address.Street)
                    .RuleFor(x => x.Phone, f => f.Person.Phone)
                    .Generate(Convert.ToInt32(quantity))
                .OrderBy(x => x.FirstName)
                .ToList());

        public Task<List<ProductModel>> GetAllProductList(uint quantity)
            => Task.FromResult(
                new Faker<ProductModel>()
                    .RuleFor(x => x.ProductId, f => Guid.NewGuid())
                    .RuleFor(x => x.ProductName, f => f.Commerce.ProductName())
                    .RuleFor(x => x.ProductAdjective, f => f.Commerce.ProductAdjective())
                    .RuleFor(x => x.ProductDescription, f => f.Commerce.ProductDescription())
                    .RuleFor(x => x.Price, f => f.Commerce.Price(min: 100, symbol: "$"))
                    .RuleFor(x => x.Color, f => f.Commerce.Color())
                    .RuleFor(x => x.Category, f => Enum.GetValues(typeof(Categories)).GetValue(new Random().Next(0, 9)).ToString())
                    .RuleFor(x => x.Material, f => f.Commerce.ProductMaterial())
                    .Generate(Convert.ToInt32(quantity))
                .OrderBy(x => x.ProductName)
                .ToList());
    }
}
