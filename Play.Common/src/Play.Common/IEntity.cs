using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Seria;ization.Attributes;

namespace Play.Common
{
    public class IEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.GuidRepresentation.Standard)]
        Guid Id { get; init; }
    }
}