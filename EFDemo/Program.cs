using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            
            using (PersonModel db = new PersonModel())
            {
                Person p3 = new Person();
                p3.Navn = "xxx";
                p3.Alder = 70;
                p3.Fødselsdato = DateTime.Now;
                p3.ErILive = true;
                p3.Id = 10;
                db.Personer.Add(p3);
                db.SaveChanges();
            }   // kalder dispose

            //{
            //    PersonModel db;
            //    try
            //    {
            //        db = new PersonModel();
            //        db.Dispose();
            //    }
            //    catch (Exception ex)
            //    {

            //        throw;
            //    }
            //    finally
            //    {
            //        db.Dispose();
            //    }
            //}

            //var personer = db.Personer                
            //    .OrderBy(i=>i.Alder)  
            //    .GroupBy(i=>i.ErILive)
            //    .ToList();



            //var person = db.Personer.Where(i => i.Id == 1).FirstOrDefault();

            //person.Alder = 100;
            //person.Navn = "a*";
            //db.SaveChanges();

            //var person2 = db.Personer.Where(i => i.Id == 4).FirstOrDefault();

            //db.Personer.Remove(person2);
            //db.SaveChanges();






        }
    }
}
