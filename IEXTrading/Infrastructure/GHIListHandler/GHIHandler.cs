using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using GHI.Models;
using Newtonsoft.Json;

namespace GHI.Infrastructure.GHIListHandler
{
    public class GHIHandler
    {
        static string BASE_URL = "https://data.medicare.gov/resource/xubh-q36u.json"; //This is the base URL, method specific URL is appended to this.
        HttpClient httpClient;

        public GHIHandler()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

       

        public List<Hospital> GetFloridadata()
        {
            string GHIHospital_API_PATH = BASE_URL + "?$where=state='FL'";
            string companyList = "";

            List<Hospital> companies = null;

            httpClient.BaseAddress = new Uri(GHIHospital_API_PATH);
            HttpResponseMessage response = httpClient.GetAsync(GHIHospital_API_PATH).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                companyList = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }

            if (!companyList.Equals(""))
            {
                companies = JsonConvert.DeserializeObject<List<Hospital>>(companyList);
                companies = companies.GetRange(0, 50);
            }
            return companies;
        }
        
        
    }
}
