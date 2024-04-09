using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Security.Cryptography;

namespace QLCSKD
{
    public class ADO
    {
        private MongoClient client;
        private IMongoDatabase database;
        public string HashPassword(string password)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
        public ADO(string connectionString, string databaseName)
        {
            client = new MongoClient(connectionString);
            database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return database.GetCollection<BsonDocument>(collectionName);
        }

        public async Task ThemNguoiDung(string collectionname, string username, string password, string email)
        {
            var collection = GetCollection(collectionname);
            var hashedpass = HashPassword(password);
            var document = new BsonDocument { {"username", username}, { "password", hashedpass}, { "email", email} };
            await collection.InsertOneAsync(document);
        }
        public async Task<bool> KiemTraDangNhap(string collectionname, string username, string password)
        {
            var collection = GetCollection(collectionname);
            var hashedpass = HashPassword(password);
            var filter = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("username", username),Builders<BsonDocument>.Filter.Eq("password", hashedpass));
            var result = await collection.Find(filter).FirstOrDefaultAsync();
            return result != null;
        }
    }
}
