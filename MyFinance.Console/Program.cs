using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Myfinance.Data;
using Myfinance.domain.Entities;
using Myfinance.domain.ComplexType;
using MyFinance.ServiceSpec;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {


            Provider p = new Provider
            {
                Username = "ahmed",
                Password = "12345678",
                ConfirmPassword = "12345678",
                Email = "fjdkjkf",
                products = new List<Product>
                {

                }

            };


            Provider p2 = new Provider
            {
                Username = "marwen",
                Password = "12345678",
                ConfirmPassword = "12345678",
                Email = "kdjfglkdfjlgj",
                products = new List<Product>
                {

                }

            };

            ProviderService s = new ProviderService();
            s.Add(p);
            s.Add(p2);
            s.Commit();
            List<Provider> providers = new List<Provider>();
            providers = s.getByName("marwen");
            foreach ( var item in providers )
            {
                System.Console.WriteLine(item.Password);

            }
            System.Console.ReadKey();

        }








        }
    }

