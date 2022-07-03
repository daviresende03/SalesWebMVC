using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMVC.Data
{
    public class SeedingService //Service para popular o Banco de Dados
    {
        private ApplicationDbContext _context;

        public SeedingService(ApplicationDbContext context) //Recebendo o DbContext logo no em sua inicialização
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //Banco de dados já está populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21),1000, d3);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r31 = new SalesRecord(31, new DateTime(2021, 05, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r32 = new SalesRecord(32, new DateTime(2021, 06, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r33 = new SalesRecord(33, new DateTime(2021, 05, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r34 = new SalesRecord(34, new DateTime(2021, 05, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r35 = new SalesRecord(35, new DateTime(2021, 05, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r36 = new SalesRecord(36, new DateTime(2021, 05, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r37 = new SalesRecord(37, new DateTime(2022, 05, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r38 = new SalesRecord(38, new DateTime(2022, 05, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r39 = new SalesRecord(39, new DateTime(2022, 05, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r40 = new SalesRecord(40, new DateTime(2022, 05, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r41 = new SalesRecord(41, new DateTime(2022, 05, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r42 = new SalesRecord(42, new DateTime(2022, 05, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r43 = new SalesRecord(43, new DateTime(2022, 05, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r44 = new SalesRecord(44, new DateTime(2022, 05, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r45 = new SalesRecord(45, new DateTime(2022, 05, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r46 = new SalesRecord(46, new DateTime(2022, 05, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r47 = new SalesRecord(47, new DateTime(2022, 05, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r48 = new SalesRecord(48, new DateTime(2022, 05, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r49 = new SalesRecord(49, new DateTime(2022, 05, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r50 = new SalesRecord(50, new DateTime(2022, 05, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r51 = new SalesRecord(51, new DateTime(2022, 05, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r52 = new SalesRecord(52, new DateTime(2022, 05, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r53 = new SalesRecord(53, new DateTime(2022, 05, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r54 = new SalesRecord(54, new DateTime(2022, 05, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r55 = new SalesRecord(55, new DateTime(2022, 05, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r56 = new SalesRecord(56, new DateTime(2022, 05, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r57 = new SalesRecord(57, new DateTime(2022, 05, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r58 = new SalesRecord(58, new DateTime(2022, 05, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r59 = new SalesRecord(59, new DateTime(2022, 05, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r60 = new SalesRecord(60, new DateTime(2022, 05, 12), 5000.0, SaleStatus.Billed, s2);

            _context.Department.AddRangeAsync(d1, d2, d3, d4);
            _context.Seller.AddRangeAsync(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRangeAsync(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30,
                r31, r32, r33, r34, r35, r36, r37, r38, r39, r40,
                r41, r42, r43, r44, r45, r46, r47, r48, r49, r50,
                r51, r52, r53, r54, r55, r56, r57, r58, r59, r60
            );

            _context.SaveChanges();
        
        }
    }
}
