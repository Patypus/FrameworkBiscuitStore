using System;
using System.Collections.Generic;
using Data.Dtos;
using Data.Context;
using MongoDB.Driver;
using Data.Entities;
using System.Linq;

namespace Data.Collections
{
    public class BiscuitCollection : IBiscuitCollection
    {
        private readonly IDataContext _context;
        private readonly IMongoDatabase _database;

        public BiscuitCollection(IDataContext context)
        {
            _context = context;
            _database = _context.GetDatabase();
        }

        public List<BiscuitDto> GetAllBiscuits()
        {
            var entities = _database.GetCollection<Biscuit>("Biscuit")
                .Find(biscuit => true)
                .ToList();

            return entities.Select(entity => new BiscuitDto(entity)).ToList();
        }

        public BiscuitDto GetBiscuitById(int biscuitId)
        {
            var filter = Builders<Biscuit>.Filter.Eq(biscuit => biscuit.Id, biscuitId);
            var result = _database.GetCollection<Biscuit>("Biscuit").Find(filter).ToList();

            if (result.Count != 1)
            {
                throw new Exception($"Expected one biscuit for id {biscuitId} but instead found {result.Count}");
            }

            return result.Select(entity => new BiscuitDto(entity)).First();
        }

        public void AddBiscuit(BiscuitDto biscuitToAdd)
        {
            var biscuitEntity = biscuitToAdd.ConvertToEntity();

            _database.GetCollection<Biscuit>("Biscuit").InsertOne(biscuitEntity);
        }
        
        public BiscuitDto UpdateBiscuit(BiscuitDto biscuitToUpdate)
        {
            var filter = Builders<Biscuit>.Filter.Eq(biscuit => biscuit.Id, biscuitToUpdate.Id);
            var update = Builders<Biscuit>.Update
                .Set(biscuit => biscuit.Name, biscuitToUpdate.Name)
                .Set(biscuit => biscuit.Description, biscuitToUpdate.Description)
                .Set(biscuit => biscuit.Price, biscuitToUpdate.Price);

            var result = _database.GetCollection<Biscuit>("Biscuit").FindOneAndUpdate(filter, update);

            return new BiscuitDto(result);
        }

        public bool DeleteBiscuit(int biscuitId)
        {
            var filter = Builders<Biscuit>.Filter.Eq(biscuit => biscuit.Id, biscuitId);
            var result = _database.GetCollection<Biscuit>("Biscuit").FindOneAndDelete(filter);

            return result != null;
        }
    }
}
