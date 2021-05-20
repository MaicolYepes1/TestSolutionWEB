using System.Threading.Tasks;

namespace TestSolutionWEB.PROVIDERS.Interfaces
{
    public interface IDataService<T>
    {
        Task<bool> PostBool(object objrequest = null);
    }
}
