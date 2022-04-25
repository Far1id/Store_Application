using StoreApplication.Server;
using System;

namespace StoreApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            string answer;

            do
            {
                Console.WriteLine("========================M E N U======================");
                Console.WriteLine("1. Product elave et");
                Console.WriteLine("2. Productlar uzre axtaris et");
                Console.WriteLine("3. Secilmis productin commentlerine bax (productİd ile)");
                Console.WriteLine("4. Secilmis userin commentlerine bax (userİd ile)");
                Console.WriteLine("5. Commenti sil (id ile)");
                Console.WriteLine("6. Productlarin ortalama qiymetine bax");
                Console.WriteLine("7. Verilmis 2 tarix araligindaki Commentlere bax");
                Console.WriteLine("0. Programdan cixin");
                Console.WriteLine("======================================================");
                Console.WriteLine("Secim edin: ");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        ProgramServers.AddProduct();
                        break;
                    case "2":
                        ProgramServers.ShowInfoFromProduct();
                        break;
                    case "3":
                        ProgramServers.ShowCommentByProduct();
                        break;
                    case "4":
                        ProgramServers.ShowCommentByUserID();
                        break;
                    case "5":
                        ProgramServers.DeleteCommontByID();
                        break;
                    case "6":
                        ProgramServers.ShowAVGPrice();
                        break;
                    case "0":
                        check = false;
                        break;
                    default:
                        break;
                }
            } while (check);
            


        }
    }
}
