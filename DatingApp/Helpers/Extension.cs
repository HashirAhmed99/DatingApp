using Microsoft.AspNetCore.Http;

namespace DatingApp.Helpers
{
    public static class Extension
    {
        public static void addApplicationError(this HttpResponse response,string messeage)
        {
            response.Headers.Add("Applictaion-Error",messeage);
            response.Headers.Add("Access-Control-Expose-Header","Application-error");
            response.Headers.Add("Access-Control-Allow-Origin","*");
        }
    }
}
