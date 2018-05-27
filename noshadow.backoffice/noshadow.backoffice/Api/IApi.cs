using System.Collections.Generic;
using System.Threading.Tasks;
using noshadow.backoffice.Models;
using RestEase;

namespace noshadow.backoffice.Api
{
    public interface IApi
    {
        [Post("/location/list")]
        Task<Response<List<GeolocationProxy>>> GetLocations([Body]GetLocationPayload payload);
    }
}