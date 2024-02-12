using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmbassyManager : ISupplierService<Foreigner>
    {
        private IApplicantService<Foreigner> _applicantService;

        public EmbassyManager(ForeignerManager applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Foreigner foreigner)
        {
            if (_applicantService.CheckPerson(foreigner))
            {
                Console.WriteLine($"\n<{foreigner.PassportNumber.ToUpper()}> Pasaport numaralı, <{foreigner.FirstName.ToUpper()} {foreigner.LastName.ToUpper()}> adlı kişiye ELÇİLİK tarafından maske verilmiştir.", foreigner.PassportNumber, foreigner.FirstName);
            }
            else
            {
                Console.WriteLine($"\n<{foreigner.PassportNumber.ToUpper()}> Pasaport numaralı, <{foreigner.FirstName.ToUpper()} {foreigner.LastName.ToUpper()}> adlı kişi kayıtlarda bulunamamıştır. Maske VERİLEMEDİ !!!", foreigner.PassportNumber, foreigner.FirstName);
            }


        }
    }
}
