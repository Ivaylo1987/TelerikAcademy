﻿namespace MongoDemos
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    public class Student
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}