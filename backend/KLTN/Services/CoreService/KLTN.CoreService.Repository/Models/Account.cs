using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLTN.CoreService.Repository.Models
{
    public class Account
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("role_id")]
        public string RoleId { get; set; }

        [BsonElement("phone_number")]
        public string PhoneNumber { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("is_active")]
        public bool IsActive { get; set; }

        [BsonElement("gender")]
        public bool Gender { get; set; }

        [BsonElement("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [BsonElement("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [BsonElement("deleted_at")]
        public DateTime? DeletedAt { get; set; }

        [BsonElement("created_by")]
        public string CreatedBy { get; set; }

        [BsonElement("updated_by")]
        public string UpdatedBy { get; set; }

        [BsonElement("deleted_by")]
        public string DeletedBy { get; set; }
    }
}
