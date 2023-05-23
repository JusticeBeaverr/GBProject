using GadgetBlitzPZ.Models.Smartphone;

namespace GadgetBlitzPZ.Services.Smartphone
{
    public class SmartphoneService : ISmartphoneService
    {
        public Task<SmartphoneModel> GetSmartphoneByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SmartphoneModel>> GetSmartphonesAsync()
        {

            var smartphones = new List<SmartphoneModel>
            {
                new SmartphoneModel { Id = 1, Name = "Samsung Galaxy A5", Size = "5.5 inches", Cpu = "Snapdragon 855", System = "Android", Storage = "128 GB", Img = "https://picsum.photos/200/300", Price = 999.99m },
                new SmartphoneModel { Id = 2, Name = "Huawei 100", Size = "6.2 inches", Cpu = "Exynos 990", System = "Android", Storage = "256 GB", Img = "https://picsum.photos/200/300", Price = 1499.99m },
                new SmartphoneModel { Id = 3, Name = "Apple iPhone 14 Pro", Size = "6.4 inches", Cpu = "Apple A14 Bionic", System = "iOS", Storage = "64 GB", Img = "https://picsum.photos/200/300", Price = 1299.99m },
                new SmartphoneModel { Id = 4, Name = "Samsung Galaxy S21", Size = "6.1 inches", Cpu = "Snapdragon 888", System = "Android", Storage = "256 GB", Img = "https://picsum.photos/200/300", Price = 1399.99m },
                new SmartphoneModel { Id = 5, Name = "Samsung Galaxy S20", Size = "6.7 inches", Cpu = "Exynos 2100", System = "Android", Storage = "512 GB", Img = "https://picsum.photos/200/300", Price = 1799.99m },
                new SmartphoneModel { Id = 6, Name = "Huawei 5X", Size = "6.2 inches", Cpu = "Exynos 990", System = "Android", Storage = "256 GB", Img = "https://picsum.photos/200/300", Price = 1499.99m },
                new SmartphoneModel { Id = 7, Name = "Apple iPhone 13 Pro", Size = "6.4 inches", Cpu = "Apple A13 Bionic", System = "iOS", Storage = "64 GB", Img = "https://picsum.photos/200/300", Price = 1299.99m },
                new SmartphoneModel { Id = 8, Name = "Samsung Galaxy S11", Size = "6.1 inches", Cpu = "Snapdragon 777", System = "Android", Storage = "256 GB", Img = "https://picsum.photos/200/300", Price = 1399.99m },
                new SmartphoneModel { Id = 9, Name = "Samsung Galaxy A15", Size = "6.7 inches", Cpu = "Exynos 1900", System = "Android", Storage = "256 GB", Img = "https://picsum.photos/200/300", Price = 1799.99m }
            };

            return smartphones;
        }
    }

}


