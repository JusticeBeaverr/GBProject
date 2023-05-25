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
                new SmartphoneModel  {
            Id = 6452,
            Name = "Apple iPhone 13",
            Data = new Data
            {
                Battery = new Battery
                {
                    Capacity_mAh = 3095,
                    Continuous_audio_playtime_h = 75,
                    Continuous_video_playtime_h = 19,
                    Technology = "Lithium-ion"
                },
                Camera = new Camera
                {
                    Camera_back_mp = 12,
                    Camera_front_mp = 12,
                    Camera_back_amount = 2,
                    Camera_front_amount = 1,
                    Camera_back_digital_zoom = 5,
                    Camera_back_max_frame_rate_fps = 240,
                    Camera_back_number_of_lens_elements = 5,
                    Camera_back_has_flash = true,
                    Camera_back_has_panorama = true,
                    Camera_back_has_auto_focus = true,
                    Camera_back_has_geotagging = true,
                    Camera_back_has_night_mode = true,
                    Camera_back_has_time_lapse_modus = true,
                    Camera_back_has_video_stabilizer = true,
                    Camera_back_resolution = "3840x2160",
                    Camera_back_type_flash = "Dual LED with True Tone, Quad LED with True Tone and Slow Sync"
                },
                Cpu = new Cpu
                {
                    Type = "A15 Bionic chip",
                    Number_of_cores = 6
                },
                Design = new Design
                {
                    Color = "Green",
                    Material = "Reinforced glass"
                },
                Display = new Display
                {
                    Type = "OLED",
                    Shape = "Flat",
                    Size_inch = 6.1,
                    Contrast_ratio = "2000000:1",
                    Brightness_cdm = 800,
                    Has_touchscreen = true,
                    Refresh_rate_hz = 60,
                    Pixel_density_ppi = 460,
                    Resolution_pixels = "2532x1170",
                    Fingerprint_resistant = true,
                    Has_gorilla_glass = null
                },
                General = new General
                {
                    Brand = "Apple",
                    Year = 2021,
                    Mpn = "MNGK3ZD/A"
                },
                Measurements = new Measurements
                {
                    Height_mm = 146.7,
                    Length_mm = 7.7,
                    Width_mm = 71.5,
                    Weight_g = 173
                },
                Navigation = new Navigation
                {
                    Has_gps = true,
                    Has_a_gps = true,
                    Has_beidou = true,
                    Has_galileo = true,
                    Has_glonass = true,
                    Has_electronic_compass = true
                },
                Network = new Network
                {
                    Has_nfc = true,
                    Has_mimo = true,
                    Has_wifi = true,
                    Has_volte = true,
                    Has_airplay = true,
                    Has_ibeacon = true,
                    Has_dual_sim = true,
                    Has_bluetooth = true,
                    _3g_standards = "DC-HSDPA, HSPA+, UMTS",
                    _4g_standards = "LTE",
                    Type_sim_card = "Nano SIM",
                    Wifi_standards = "Wireless A (WiFi 2), Wireless AC (WiFi 5), Wireless AX (WiFi 6), Wireless B (WiFi 1), Wireless G (WiFi 3), Wireless N (WiFi 4)",
                    Sim_card_capacity = "Dual SIM",
                    Generation_mobile_network = "5G",
                    Bluetooth_version = 5
                },
                PortsInterfaces = new PortsInterfaces
                {
                    Has_lightning_connector = true,
                    Has_usb = null,
                    Type_of_connector = "Apple Lightning"
                },
                Sensors = new Sensors
                {
                    Has_barometer = true,
                    Has_gyroscope = true,
                    Has_accelerometer = true,
                    Has_proximity_sensor = true,
                    Has_ambient_light_sensor = true
                },
                Software = new Software
                {
                    Os = "iOS"
                },
                Storage = new Storage
                {
                    Capacity_gb = 128
                },
                Has_magsafe = true,
                Has_video_call = true,
                Has_fast_charge = true,
                Has_loudspeaker = true,
                Is_shock_resistant = true,
                Is_water_resistant = true,
                Has_vibrating_alarm = true,
                Has_face_recognition = true,
                Has_wireless_charging = true,
                Can_be_used_underwater = true,
                Has_dialing_with_voice = true,
                Has_spoken_navigation_instructions = true,
                Has_fingerprint_reader = null,
                Has_headphone_jack = null
            },
            
            Price = 850.18m,
            Img = "https://picsum.photos/200/300"
        },
                new SmartphoneModel { Id = 1, Name = "Samsung Galaxy A5", Size = "5.5 inches", Cpu = "Snapdragon 855", System = "Android", Storage = "128 GB", Img = "https://picsum.photos/200/300", Price = 999.99m},
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


