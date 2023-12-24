﻿using System.Net.Http;
using System;
using Newtonsoft.Json;

namespace Fluxus.Infra.ExternalServices
{
    public  class ViaCep
    {
        public dynamic GetViaCep(string cep)
        {
            string json = RequestViaCep(cep);
            return JsonConvert.DeserializeObject<dynamic>(json);
        }

        public static string RequestViaCep(string cep)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.BaseAddress = new Uri("https://viacep.com.br/ws/");
                    var response = httpClient.GetAsync(cep + "/json/").Result;

                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsStringAsync().Result;
                    else
                        return String.Empty;
                }
            }
            catch
            {
                return String.Empty;
            }
        }


    }
}