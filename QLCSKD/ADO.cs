﻿using System;
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
<<<<<<<<< Temporary merge branch 1
            var filter = Builders<BsonDocument>.Filter.And(Builders<BsonDocument>.Filter.Eq("Status_Invoices", "unpaid"));
            var rooms = collection.Find(filter).ToList();
            List<string> listroom = new List<string>();
            foreach (var room in rooms) 
            {
               listroom.Add(room["Name"].ToString());
            }
            return listroom;
        }
        // Task For Phong Page


        public class Contract
        {
            public ObjectId Id { get; set; }
            public string TenKhach { get; set; }
            public string ThongTinLienHe { get; set; }
            public string SoPhong { get; set; }
            public string SOCCCD { get; set; }
            public string LoaiPhong { get; set; }
            public string Gia { get; set; }
            public string NgayBatDau { get; set; }
        }
        public IMongoCollection<Contract> GetTColl(string collectionName)
        {
            return database.GetCollection<Contract>(collectionName);
        }
        public async Task<List<Contract>> Trans_Hisa(string collectionname)
        {
            var collection = GetTColl(collectionname);
            List<Contract> list = await collection.Find(Builders<Contract>.Filter.Empty).ToListAsync();
            return list;
        }
        public async Task ThemHopDong(string collectionName, Contract contract)
        {
            var collection = database.GetCollection<Contract>(collectionName);
            await collection.InsertOneAsync(contract);
        }

        public async Task XoaHopDong(string collectionName, Contract contract)
        {
            var collection = database.GetCollection<Contract>(collectionName);
            await collection.DeleteOneAsync(c => c.Id == contract.Id);
        }

        public async Task SuaHopDong(string collectionName, Contract contract)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", contract.Id);
            var update = Builders<BsonDocument>.Update
                .Set("TenKhach", contract.TenKhach)
                .Set("ThongTinLienHe", contract.ThongTinLienHe)
                .Set("SOCCCD", contract.SOCCCD)
                .Set("SoPhong", contract.SoPhong)
                .Set("LoaiPhong", contract.LoaiPhong)
                .Set("Gia", contract.Gia)
                .Set("NgayBatDau", contract.NgayBatDau);

            await collection.UpdateOneAsync(filter, update);
        }
        // Task For Quan ly hop dong Page
        public class Supplies
        {
            public ObjectId Id { get; set; }

            public string Tenthietbi { get; set; }
            public string PS { get; set; }
            public string ViTri { get; set; }
            public string TrangThai { get; set; }
        }

        public IMongoCollection<Supplies> GetCollect_Supplies(string collectionName)
        {
            return database.GetCollection<Supplies>(collectionName);
        }
        public async Task<List<Supplies>> LsKho(string collectionname)
        {
            var collection = GetCollect_Supplies(collectionname);
            List<Supplies> list = await collection.Find(Builders<Supplies>.Filter.Empty).ToListAsync();
            return list;
        }
        
        public async Task ThemThietBi(string collectionName, Supplies supplies)
        {
            var collection = database.GetCollection<Supplies>(collectionName);
            await collection.InsertOneAsync(supplies);
        }
        public async Task XoaThietBi(string collectionName, Supplies supplies)
        {
            var collection = database.GetCollection<Supplies>(collectionName);
            await collection.DeleteOneAsync(c => c.Id == supplies.Id);
        }

        public async Task SuaThietBi(string collectionName, Supplies supplies)
        {
            var collection = database.GetCollection<Supplies>(collectionName);
            var filter = Builders<Supplies>.Filter.Eq("_id", supplies.Id);
            var update = Builders<Supplies>.Update
                .Set("Tenthietbi", supplies.Tenthietbi)
                .Set("PS", supplies.PS)
                .Set("ViTri", supplies.ViTri)
                .Set("TrangThai", supplies.TrangThai);

            await collection.UpdateOneAsync(filter, update);
        }

        // Task For Kho Page

        public class Services
        {
            public ObjectId Id { get; set; }

            public string Name { get; set; }
            public int Price { get; set; }

        }

        public IMongoCollection<Services> GetCollect_Services(string collectionName)
        {
            return database.GetCollection<Services>(collectionName);
        }
        public async Task<List<Services>> LsDichVu(string collectionname)
        {
            var collection = GetCollect_Services(collectionname);
            List<Services> list = await collection.Find(Builders<Services>.Filter.Empty).ToListAsync();
            return list;
        }

        public async Task ThemDichVu(string collectionName, Services services)
        {
            var collection = database.GetCollection<Services>(collectionName);
            await collection.InsertOneAsync(services);
        }
        public async Task XoaDichVu(string collectionName, Services services)
        {
            var collection = database.GetCollection<Services>(collectionName);
            await collection.DeleteOneAsync(c => c.Id == services.Id);
        }

        public async Task SuaDichVu(string collectionName, Services services)
        {
            var collection = database.GetCollection<Services>(collectionName);
            var filter = Builders<Services>.Filter.Eq("_id", services.Id);
            var update = Builders<Services>.Update
                .Set("Name", services.Name)
                .Set("Price", services.Price);


            await collection.UpdateOneAsync(filter, update);
        }

        // Task For Dich Vu Page
    }
}
