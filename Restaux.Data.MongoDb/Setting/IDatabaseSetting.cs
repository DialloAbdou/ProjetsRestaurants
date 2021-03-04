using MongoDB.Driver;
using Restaux.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaux.Data.MongoDb.Setting
{
   public interface IDatabaseSetting
   {
        IMongoCollection<Composer> Composers { get; }

    }
}
