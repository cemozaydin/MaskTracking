using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FakePassportCheckService
    {
        List<Foreigner> foreigners;
        public FakePassportCheckService()
        {
            foreigners = new List<Foreigner>
            {
                new Foreigner
                {
                    FirstName ="Anna",
                    LastName  = "Vladislova",
                    PassportNumber = "J1234567"
                },
                new Foreigner
                {
                    FirstName = "Arthur",
                    LastName = "Anderson",
                    PassportNumber = "H7654321"
                }
            };
        }

        public bool CheckPassport(Foreigner _foreigner)
        {
            foreach (var foreigner in foreigners)
            {
                if (foreigner.FirstName.ToLower() == _foreigner.FirstName && foreigner.LastName.ToLower() == _foreigner.LastName && foreigner.PassportNumber.ToLower() == _foreigner.PassportNumber)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
