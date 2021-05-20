using System.Collections.Generic;
using System.Threading.Tasks;
using TestSolutionWEB.MODELS.Loads;

namespace TestSolutionWEB.SERVICES.Interfaces
{
    public interface IAddUsserService
    {
        Task<bool> Add(string url, UsserLoad usser);
    }
}
