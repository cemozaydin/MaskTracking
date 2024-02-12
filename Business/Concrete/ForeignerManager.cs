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
    public class ForeignerManager : IApplicantService<Foreigner>
    {
        FakePassportCheckService fakePassportCheckService = new FakePassportCheckService();
        public void ApplyForMask(Foreigner foreigner)
        {
            
        }

        public bool CheckPerson(Foreigner foreigner)
        {
            if (fakePassportCheckService.CheckPassport(foreigner))
            {
                return true;
            }           
            return false;
        }

        public List<Foreigner> GetList()
        {
            return null;
        }

    }
}
