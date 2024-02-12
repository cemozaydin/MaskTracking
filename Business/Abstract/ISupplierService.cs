using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISupplierService<TApplicantService> where TApplicantService : class, new()
    {
        void GiveMask(TApplicantService applicantService);
    }
}
