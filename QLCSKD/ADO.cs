using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Security.Cryptography;
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using static QLCSKD.ADO;

namespace QLCSKD
{
    public class ADO
    {
        private MongoClient client;
        private IMongoDatabase database;
        // Hash Pass
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
        // Connect TO Mongo
        public ADO(string username, string pass)
        {
            try
            {
                client = new MongoClient("mongodb+srv://" + username + ":" + pass + "@clusteradmin.xhzdgke.mongodb.net/");
                database = client.GetDatabase("QTCSDL");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Loi Ket Noi");
            }
        }
        // Return Collection
        public IMongoCollection<BsonDocument> GetCollection(string collectionName)
        {
            return database.GetCollection<BsonDocument>(collectionName);
        }
        // Task For Login/Register/ForgotPass
        public async Task ThemNguoiDung(string collectionname, string username, string password, string email, string role)
        {
            var collection = GetCollection(collectionname);
            var hashedpass = HashPassword(password);
            var document = new BsonDocument { { "username", username }, { "password", hashedpass }, { "email", email }, { "role", role } };
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
        //public async Task<bool> KiemTraTaiKhoanTonTai(string check)
        //{
        //    var collection = GetCollection(check);
        //    var filter = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("username", check));
        //    var result = await collection.Find(check).FirstOrDefaultAsync();
        //    if(result  != null)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        // Task For DoanhThu Page
        public class Transaction
        {
            public ObjectId Id { get; set; } 
            public DateTime Ngay { get; set; }
            public string Ten { get; set; }
            public string STK { get; set; }
            public double SoTien { get; set; }
            public string NoiDung {  get; set; }
        }
        // Return TDOCUMENT
        public IMongoCollection<Transaction> GetTCollection(string collectionName)
        {
            return database.GetCollection<Transaction>(collectionName);
        }
        public async Task<List<Transaction>> Trans_His(string collectionname)
        {
            var collection = GetTCollection(collectionname);
            List<Transaction> list = await collection.Find(Builders<Transaction>.Filter.Empty).ToListAsync();
            return list;
        }
        // Insert Trans
        public async Task ThemGiaoDich(string collectionName, Transaction transaction)
        {
            var collection = database.GetCollection<Transaction>(collectionName);
            await collection.InsertOneAsync(transaction);
        }
    }
}
