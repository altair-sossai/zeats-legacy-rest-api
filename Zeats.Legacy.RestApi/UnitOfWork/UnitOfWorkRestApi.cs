using System;
using RestSharp;
using Parameter = Zeats.Legacy.RestApi.Parameters.Parameter;

namespace Zeats.Legacy.RestApi.UnitOfWork
{
    public class UnitOfWorkRestApi : RestClient
    {
        public UnitOfWorkRestApi(string apiUrl)
            : base(new Uri(apiUrl))
        {
        }

        public IRestResponse<T> Post<T>(string resource, object model, Parameter[] headers = null, Parameter[] parameters = null)
            where T : new()
        {
            var restRequest = new RestRequest(resource, Method.POST);
            restRequest.AddJsonBody(model);

            foreach (var header in headers ?? new Parameter[0])
                restRequest.AddHeader(header.Name, header.Value);

            foreach (var parameter in parameters ?? new Parameter[0])
                restRequest.AddQueryParameter(parameter.Name, parameter.Value);

            return ExecuteRequest<T>(restRequest);
        }


        private IRestResponse<T> ExecuteRequest<T>(IRestRequest restRequest)
            where T : new()
        {
            return Execute<T>(restRequest);
        }
    }
}