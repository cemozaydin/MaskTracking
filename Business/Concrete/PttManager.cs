
using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : ISupplierService<Citizen>
{
    private IApplicantService<Citizen> _applicantService;

    public PttManager(CitizenManager applicantService)
    {
        _applicantService = applicantService;
    }

    public void GiveMask(Citizen applicant)
    {

        if (_applicantService.CheckPerson(applicant))
        {
            Console.WriteLine($"\n<{applicant.IdentityNumber}> TC numaralı, <{applicant.FirstName.ToUpper()} {applicant.LastName.ToUpper()}> adlı vatandaşımız için maske gönderilmiştir.");
        }
        else
        {
            Console.WriteLine("\nVatandaşlık kaydı bulunamadı. Maske VERİLEMEDİ !!!");
        }
    }

   
}
