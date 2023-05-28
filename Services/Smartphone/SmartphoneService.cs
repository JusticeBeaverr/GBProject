﻿using GadgetBlitzPZ.Models.Smartphone;
using System.Diagnostics;
using System.Text.Json;

namespace GadgetBlitzPZ.Services.Smartphone
{
    public class SmartphoneService : ISmartphoneService
    {
        private readonly HttpClient _httpClient;
        private readonly string _remoteServiceBaseUrl;

        public SmartphoneService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<SmartphoneModel> GetSmartphoneByIdAsync(string id)
        {
            var responsestring = await _httpClient.GetStringAsync($"phones/{id}");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true,
            };
            var smartphone = JsonSerializer.Deserialize<SmartphoneModel>(responsestring, options);

            return smartphone;
        }

        public async Task<List<SmartphoneListModel>> GetSmartphonesAsync(string filter)
        {

            try
            {
                var response = await _httpClient.GetStringAsync($"phones?{filter}");
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    IncludeFields = true,
                };
                var jsonObject = JsonDocument.Parse(response).RootElement;
                var smartphones = JsonSerializer.Deserialize<List<SmartphoneListModel>>(jsonObject.GetProperty("content").ToString(), options);
                return smartphones;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }

}


