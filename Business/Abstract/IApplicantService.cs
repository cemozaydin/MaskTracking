using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService<TApplicant> //TApplicant-> Citizen veya başka bir taraf
    {
        void ApplyForMask(TApplicant applicant);

        List<TApplicant> GetList();

        bool CheckPerson(TApplicant applicant);
    }
}
