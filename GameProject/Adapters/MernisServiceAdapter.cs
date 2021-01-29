using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer user)
        {
            return TaskAsync(user).Result;
        }
        public static async Task<bool> TaskAsync(Gamer user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.IdentityId), user.FirstName, user.LastName, user.BirthYear));
            return status.Body.TCKimlikNoDogrulaResult;
        }
    }

}