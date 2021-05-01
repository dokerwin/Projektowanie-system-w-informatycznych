using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace PhoneMarket.Models
{
    public class DBInitializer :DropCreateDatabaseAlways<PhoneContext>
    {


        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Huawei P20", Price = 40000, Producer = "Huawei" });
            context.Phones.Add(new Phone() {  Name = "Z3 Play", Price = 34000, Producer = "Motorola" });
            context.Phones.Add(new Phone() {  Name = "Mi Note 9", Price = 25000, Producer = "Xiaomi" });

            base.Seed(context);
        }
    }


}