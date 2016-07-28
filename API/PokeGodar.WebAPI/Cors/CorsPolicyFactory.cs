using System.Net.Http;
using System.Web.Http.Cors;

namespace PokeGodar.WebAPI.Cors
{
    public class CorsPolicyFactory : ICorsPolicyProviderFactory
    {
        ICorsPolicyProvider _provider = new CustomCorsPolicyProvider();

        public ICorsPolicyProvider GetCorsPolicyProvider(HttpRequestMessage request)
        {
            return _provider;
        }
    }
}
