using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround;

public class Program
{
    static void Main(string[] args)
    {
        int secim=0;

        ISupplierService<Citizen> supplierService = new PttManager(new CitizenManager());       
        ISupplierService<Foreigner> supplierService2=new EmbassyManager(new ForeignerManager());
       

        Console.WriteLine("============= MASKE TALEP =============");
        Console.WriteLine();
        Console.WriteLine("\t1. Türk Vatandaşı");
        Console.WriteLine("\t2. Turist/Yabancı Uyruklu");
        Console.WriteLine();
        Console.WriteLine("=======================================");
        Console.WriteLine();
        Console.Write("Seçiminiz <1-2> : ");
        secim = Convert.ToInt32(Console.ReadLine());

       

        Console.WriteLine();
        if (secim==1)
        {
            Console.Write("Adınız : ");
            string name = Console.ReadLine().ToLower();

            Console.Write("Soyadınız : ");
            string lastName = Console.ReadLine().ToLower();

            Console.Write("Doğum yılınız : ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("TC Numaranız : ");
            long idNumber = Convert.ToInt64(Console.ReadLine());

            supplierService.GiveMask(new Citizen
                {

                    FirstName = name,
                    LastName = lastName,
                    DateOfBirthYear = birthYear,
                    IdentityNumber = idNumber
            }            
            );
            Console.WriteLine();
        }
        else if (secim==2)
        {
            Console.Write("Adınız : ");
            string name = Console.ReadLine().ToLower();

            Console.Write("Soyadınız : ");
            string lastName = Console.ReadLine().ToLower();

            Console.Write("Pasaport Numaranız : ");
            string pasaportNumber = Console.ReadLine().ToLower();

            supplierService2.GiveMask(new Foreigner
            {
                FirstName = name,
                LastName = lastName,
                PassportNumber = pasaportNumber
            });
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine("Hatalı Seçim...");
        }

    }

}
