using System.Net.Http.Headers;

namespace Jifity.DAL
{
    public class ExternalApi
    {

        public static string URL = "https://rpnszaidmg.execute-api.eu-west-1.amazonaws.com/Prod";
        public Dictionary<string,string> cash=new Dictionary<string,string>();
        public static async Task<string> GetExternalResponse(string controller,int? id)
        {
            try
            {

                using (HttpClient client = new HttpClient())
                {

                    var header = new AuthenticationHeaderValue("9874654654987654658");
                    client.DefaultRequestHeaders.Authorization = header;
                    var response = (id.HasValue) ? await client.GetAsync(URL + controller + "/" + id) :
                        await client.GetAsync(URL + controller);

                    var result = await response.Content.ReadAsStringAsync();
                    return result;

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
