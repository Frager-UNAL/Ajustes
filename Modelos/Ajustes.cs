using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajustes_Fragen.Modelos
{
    public class Ajustes
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        [BsonElement("IdUsuario")]
        public int IdUsuario { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("colorFondo")]
        public string colorFondo { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        [BsonElement("tamanoLetra")]
        public int tamanoLetra { get; set; }

        [BsonRepresentation(BsonType.Int32)]
        [BsonElement("sonidoON")]
        public int sonidoON { get; set; }


    }
}
