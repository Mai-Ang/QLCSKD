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
using System.Collections;
using QLCSKD.ChildForm;
using System.Data.Common;

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
        // Get UTC VN
        public static DateTime GetTimeVN()
        {
            TimeZoneInfo localtimezone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime localdatetime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, localtimezone);
            return localdatetime;
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
            var filter = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("username", username), Builders<BsonDocument>.Filter.Eq("password", hashedpass));
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
            public string NoiDung { get; set; }
        }
        // Return TDOCUMENT
        public IMongoCollection<Transaction> GetCollect_Trans(string collectionName)
        {
            return database.GetCollection<Transaction>(collectionName);
        }
        public async Task<List<Transaction>> LsGiaoDich(string collectionname)
        {
            var collection = GetCollect_Trans(collectionname);
            List<Transaction> list = await collection.Find(Builders<Transaction>.Filter.Empty).ToListAsync();
            return list;
        }
        // Insert Trans
        public async Task ThemGiaoDich(string collectionName, Transaction transaction)
        {
            var collection = database.GetCollection<Transaction>(collectionName);
            await collection.InsertOneAsync(transaction);
        }

        // Task For HoaDon Page
        public class Invoices
        {
            public ObjectId Id { get; set; }
            public string Phong { get; set; }
            public double Tienphong { get; set; }
            public double CSD { get; set; }
            public double CSDMoi { get; set; }
            public double TienDien { get; set; }
            public double CSN { get; set; }
            public double CSNMoi { get; set; }
            public double TienNuoc { get; set; }
            public double PhuThu { get; set; }
            public double Khac { get; set; }
            public double TongTien { get; set; }
            public string NoiDung { get; set; }
            public DateTime Ngay { get; set; }
            public string Status { get; set; }
        }
        public IMongoCollection<Invoices> GetCollect_Invoices(string collectionName)
        {
            return database.GetCollection<Invoices>(collectionName);
        }
        public async Task<List<Invoices>> LsHoaDon(string collectionname)
        {
            var collection = GetCollect_Invoices(collectionname);
            List<Invoices> list = await collection.Find(Builders<Invoices>.Filter.Empty).ToListAsync();
            return list;
        }
        // Insert Invoices
        public async Task ThemHoaDon(string collectionName, Invoices invoi)
        {
            var collection = database.GetCollection<Invoices>(collectionName);
            await collection.InsertOneAsync(invoi);
        }
        // Return Price
        public string Get_Price(string nameprice)
        {
            var collection = GetCollection("Services");
            var filter = Builders<BsonDocument>.Filter.Eq("Name", nameprice);
            var projection = Builders<BsonDocument>.Projection.Include("Price");
            var document = collection.Find(filter).Project(projection).FirstOrDefault();
            if (document != null)
            {
                return document["Price"].ToString();
            }
            return "0";
        }
        // Return Phong
        public List<String> Get_List_Phong()
        {
            var collection = GetCollection("Rooms");
            //var filter = Builders<BsonDocument>.Filter.Eq("Status_Invoices", "unpaid");
            //var rooms = collection.Find(filter).ToList();
            var rooms = collection.Find(new BsonDocument()).ToList();
            List<string> listrooms = new List<string>();
            foreach (var room in rooms) 
            {
               listrooms.Add(room["Name"].ToString());
            }
            return listrooms;
        }
        // Task For Phong Page

    }
}
