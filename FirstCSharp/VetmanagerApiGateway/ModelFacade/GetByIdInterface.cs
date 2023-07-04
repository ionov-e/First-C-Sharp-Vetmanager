using FirstCSharp.VetmanagerApiGateway.DTO.ModelContainer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp.VetmanagerApiGateway.ModelFacade
{
    internal interface GetByIdInterface<T> where T : AbstractModel
    {
        Task<Client> ById(int id);
    }
}
