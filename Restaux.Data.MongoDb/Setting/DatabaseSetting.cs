using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Data.MongoDb.Setting
{
    public class DatabaseSetting : IDatabaseSetting
    {
        public readonly IMongoDatabase _db;

        public DatabaseSetting(IOptions<Settings> options, IMongoClient client)
        {
            _db = client.GetDatabase(options.Value.DataBase);
        }

        public IMongoCollection<Composer> Composers => _db.GetCollection<Composer>("Composers");
    }
}
