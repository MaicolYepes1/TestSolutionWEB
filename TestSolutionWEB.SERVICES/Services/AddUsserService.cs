using System;
using System.Threading.Tasks;
using TestSolutionWEB.MODELS.Constants;
using TestSolutionWEB.MODELS.Loads;
using TestSolutionWEB.PROVIDERS.Interfaces;
using TestSolutionWEB.SERVICES.Interfaces;

namespace TestSolutionWEB.SERVICES.Services
{
    public class AddUsserService : IAddUsserService
    {
        #region Dependency
        private readonly IDataService<bool> _data;
        #endregion

        #region Constructor
        public AddUsserService(IDataService<bool> data)
        {
            _data = data;
        }
        #endregion

        #region Methods
        public async Task<bool> Add(string url, UsserLoad usser)
        {
            try
            {
                Base.EndPoint = url;
                var result = await _data.PostBool(usser);
                return result;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        #endregion
    }
}
