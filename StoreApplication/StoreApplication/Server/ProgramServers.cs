using StoreApplication.Data.DAL;
using StoreApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreApplication.Server
{
    public class ProgramServers
    {
        StoreDbContext storeDbContext = new StoreDbContext();
        public void AddProduct(Products product)
        {
            Console.WriteLine("Productin adini daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Productin satis qiymetini daxil edin");
            int salePrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Productin alish deyerini daxil edin: ");
            int costPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Productin sayini daxil edin: ");
            int count = int.Parse(Console.ReadLine());

            Products products = new Products()
            {
                Name = name,
                CostPrice = costPrice,
                SalePrice = salePrice,
                Count = count
            };

            storeDbContext.Products.Add(products);
            storeDbContext.SaveChanges();
        }
        public void ShowInfoFromProduct()
        {
            Console.WriteLine("Axtarmaq istediyiniz adi yazin : ");
            string str = Console.ReadLine();
            var data = storeDbContext.Products.Where(x => x.Name.Contains(str)).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Count);
            }
        }
        public void ShowCommentByProduct()
        {
            Console.WriteLine("Id ni yazin : ");
            int ID = int.Parse(Console.ReadLine());
            var data = storeDbContext.Comments.Where(x => x.ProductId == ID).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Text);
            }
        }
        public void ShowCommentByUserID()
        {
            Console.WriteLine("Id ni yazin : ");
            int ID = int.Parse(Console.ReadLine());
            var data = storeDbContext.Comments.Where(x => x.UserId == ID).ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Text);
            }
        }
        public void DeleteCommontByID()
        {
            Console.WriteLine("ID ni daxil edin :");
            int ID = int.Parse(Console.ReadLine());
            var data =storeDbContext.Comments.Where(x => x.Id == ID).FirstOrDefault();
            storeDbContext.Comments.Remove(data);
            storeDbContext.SaveChanges();
        }
        public void ShowAVGPrice()
        {
            var data = storeDbContext.Products.ToList();
            int sum = 0, count = 0;
            foreach (var item in data)
            {
                sum += item.SalePrice;
                count++;
            }
            Console.WriteLine(sum / count);
        }
    }
       
}
