using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {

        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context) {

            _context = context;
        }


        public void Seed() {

            if (_context.Department.Any() || _context.Department.Any() || _context.Seller.Any())
            {
                return;
            }

            Department d1 = new Department(1,"Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1,"Bob Brown","bob@gmail.com",new DateTime(1992,4,21),1000.0,d1);
            Seller s2 = new Seller(2, "Micole Brown", "nicole@gmail.com", new DateTime(1992, 4, 21), 1000.0, d3);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1992, 4, 21), 1000.0, d2);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1992, 4, 21), 1000.0, d3);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(1992, 4, 21), 1000.0, d4);


            SalesRecord r1 = new SalesRecord(1,new DateTime(2019,04,25),1100.0,SalesStatus.Billed,s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019,06,11), 1100.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019,05,30), 1100.0, SalesStatus.Billed, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019,06,15), 1100.0, SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019,06,15), 1200.0, SalesStatus.Billed, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019,05,10), 1100.0, SalesStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019,07,04), 100.0, SalesStatus.Billed, s5);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 04, 25), 1100.0, SalesStatus.Billed, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 06, 11), 1100.0, SalesStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 05, 30), 1100.0, SalesStatus.Billed, s2);
            SalesRecord r11= new SalesRecord(11, new DateTime(2019, 06, 15), 1100.0, SalesStatus.Billed, s4);
            SalesRecord r12= new SalesRecord(12, new DateTime(2019, 06, 15), 1200.0, SalesStatus.Billed, s4);
            SalesRecord r13= new SalesRecord(13, new DateTime(2019, 05, 10), 1100.0, SalesStatus.Billed, s3);
            SalesRecord r14= new SalesRecord(14, new DateTime(2019, 07, 04), 100.0, SalesStatus.Billed, s5);

            _context.Department.AddRange(d1,d2,d3,d4);

            _context.Seller.AddRange(s1,s2,s3,s4,s5);

            _context.SalesRecord.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13,r14);

            _context.SaveChanges();


        }

    }
}
