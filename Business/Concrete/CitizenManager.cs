using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using MernisKPSService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CitizenManager : IApplicantService<Citizen>
{
    public void ApplyForMask(Citizen citizen)
    {
        
    }

    public List<Citizen> GetList()
    {
        return null;
    }

    public bool CheckPerson(Citizen citizen)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(new KPSPublicSoapClient.EndpointConfiguration());

        //var result = true;
        var result = client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
            citizen.IdentityNumber,
            citizen.FirstName,
            citizen.LastName,
            citizen.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;

        return result;
    }

}
