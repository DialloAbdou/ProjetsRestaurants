using MongoDB.Bson;
using MongoDB.Driver;
using Restaux.Core.Models;
using Restaux.Core.Repositories;
using Restaux.Data.MongoDb.Setting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaux.Data.MongoDb.Repositories
{
    public class ComposerRepository : IComposerRepository
    {
        private readonly IDatabaseSetting _Context;

        public ComposerRepository(IDatabaseSetting context)
        {
            _Context = context;
        }
        public async Task<Composer> Create(Composer composer)
        {
            await _Context.Composers.InsertOneAsync(composer);
             return composer;
        }

        public async Task<bool> Delete(string id)
        {
            ObjectId idMongo = new ObjectId(id);
            FilterDefinition<Composer> filter = Builders<Composer>.Filter.Eq(m => m.Id, idMongo);
            DeleteResult deleteResult = await _Context.Composers.DeleteOneAsync(filter);

            return deleteResult
                .IsAcknowledged
                && deleteResult.DeletedCount > 0;

        }

        public async Task<IEnumerable<Composer>> GetAllComposer()
        {
            return await _Context
                .Composers.
                Find(_ => true).ToListAsync();
            
        }

        public async Task<Composer> GetComposerById(string id)
        {
            ObjectId idMongo = new ObjectId(id);
            FilterDefinition<Composer> filter = Builders<Composer>.Filter.Eq(m => m.Id, idMongo);
            return await _Context.Composers.Find(filter)
                .FirstOrDefaultAsync();

        }

        public void Update(string id, Composer composer)
        {
            ObjectId idMongo = new ObjectId(id);
            FilterDefinition<Composer> filter = Builders<Composer>.Filter.Eq(m => m.Id, idMongo);
            var update = Builders<Composer>.Update.Set("FirstName", composer.FirstName).Set("LastName", composer.LastName);
            _Context.Composers.FindOneAndUpdate(filter, update);

        }
    }
}
