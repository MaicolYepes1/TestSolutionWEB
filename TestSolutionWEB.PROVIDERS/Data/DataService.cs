using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;
using TestSolutionWEB.MODELS.Constants;
using TestSolutionWEB.PROVIDERS.Interfaces;

namespace TestSolutionWEB.PROVIDERS.Data
{
    public class DataService<T> : IDataService<T>
    {
        #region Methods
        public async Task<bool> PostBool(object objrequest = null)
        {
            try
            {
                var _RestClient = ConexionWebAPis();
                RestRequest request = new RestRequest(Base.EndPoint, Method.POST, DataFormat.Json);
                request.Timeout = 10000000;
                if (objrequest != null)
                {
                    request.AddParameter("application/json", JsonConvert.SerializeObject(objrequest), ParameterType.RequestBody);

                    bool response = await _RestClient.PostAsync<bool>(request);
                    return response;
                }
                else
                {
                    bool response = await _RestClient.PostAsync<bool>(request);

                    return response;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public RestClient ConexionWebAPis()
        {
            RestClient _RestClient = new RestClient(Base.Url);
            return _RestClient;
        }
        #endregion
    }
}
