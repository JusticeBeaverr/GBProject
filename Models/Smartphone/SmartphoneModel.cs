namespace GadgetBlitzPZ.Models.Smartphone
{
    public class SmartphoneModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Data Data { get; set; }

        public List<string>? Urls { get; set; }
        public double? Price { get; set; }
        public List<OpinionModel>? Opinions { get; set; }


    }
    public class Data
    {
        public Battery? Battery { get; set; }
        public Camera? Camera { get; set; }
        public Cpu? Cpu { get; set; }
        public Design? Design { get; set; }
        public Display? Display { get; set; }
        public General? General { get; set; }
        public Measurements? Measurements { get; set; }
        public Navigation? Navigation { get; set; }
        public Network? Network { get; set; }
        public PortsInterfaces? PortsInterfaces { get; set; }
        public Sensors? Sensors { get; set; }
        public Software? Software { get; set; }
        public Storage? Storage { get; set; }
        public bool Has_magsafe { get; set; }
        public bool? Has_video_call { get; set; }
        public bool? Has_fast_charge { get; set; }
        public bool? Has_loudspeaker { get; set; }
        public bool? Is_shock_resistant { get; set; }
        public bool? Is_water_resistant { get; set; }
        public bool? Has_vibrating_alarm { get; set; }
        public bool? Has_face_recognition { get; set; }
        public bool? Has_wireless_charging { get; set; }
        public bool? Can_be_used_underwater { get; set; }
        public bool? Has_dialing_with_voice { get; set; }
        public bool? Has_spoken_navigation_instructions { get; set; }
        public bool? Has_fingerprint_reader { get; set; }
        public bool? Has_headphone_jack { get; set; }
    }
    public class Battery
    {
        public int? Capacity__mAh { get; set; }
        public int? Continuous_audio_playtime__h { get; set; }
        public int? Continuous_video_playtime__h { get; set; }
        public string? Technology { get; set; }
    }
    public class Camera
    {
        public int? Camera_back__mp { get; set; }
        public int? Camera_front__mp { get; set; }
        public int? Camera_back_amount { get; set; }
        public int? Camera_front_amount { get; set; }
        public int? Camera_back_digital_zoom { get; set; }
        public int? Camera_back_max_frame_rate__fps { get; set; }
        public int? Camera_back_number_of_lens_elements { get; set; }
        public bool? Camera_back_has_flash { get; set; }
        public bool? Camera_back_has_panorama { get; set; }
        public bool? Camera_back_has_auto_focus { get; set; }
        public bool? Camera_back_has_geotagging { get; set; }
        public bool? Camera_back_has_night_mode { get; set; }
        public bool? Camera_back_has_time_lapse_modus { get; set; }
        public bool? Camera_back_has_video_stabilizer { get; set; }
        public string? Camera_back_resolution { get; set; }
        public string? Camera_back_type_flash { get; set; }
    }
    public class Cpu
    {
        public string? Type { get; set; }
        public int? Number_of_cores { get; set; }
    }

    public class Design
    {
        public string? Color { get; set; }
        public string? Material { get; set; }
    }

    public class Display
    {
        public string? Type { get; set; }
        public string? Shape { get; set; }
        public double? Size__inch { get; set; }
        public string? Contrast_ratio { get; set; }
        public int? Brightness__cdm { get; set; }
        public bool? Has_touchscreen { get; set; }
        public int? Refresh_rate__hz { get; set; }
        public int? Pixel_density__ppi { get; set; }
        public string? Resolution__pixels { get; set; }
        public bool? Fingerprint_resistant { get; set; }
        public bool? Has_gorilla_glass { get; set; }
    }

    public class General
    {
        public string? Brand { get; set; }
        public int? Year { get; set; }
        public string? Mpn { get; set; }
    }

    public class Measurements
    {
        public double? Height__mm { get; set; }
        public double? Length__mm { get; set; }
        public double? Width__mm { get; set; }
        public double? Weight__g { get; set; }
    }

    public class Navigation
    {
        public bool? Has_gps { get; set; }
        public bool? Has_a_gps { get; set; }
        public bool? Has_beidou { get; set; }
        public bool? Has_galileo { get; set; }
        public bool? Has_glonass { get; set; }
        public bool? Has_electronic_compass { get; set; }
    }

    public class Network
    {
        public bool? Has_nfc { get; set; }
        public bool? Has_mimo { get; set; }
        public bool? Has_wifi { get; set; }
        public bool? Has_volte { get; set; }
        public bool? Has_airplay { get; set; }
        public bool? Has_ibeacon { get; set; }
        public bool? Has_dual_sim { get; set; }
        public bool? Has_bluetooth { get; set; }

        public string? Type_sim_card { get; set; }
        public string? Wifi_standards { get; set; }
        public string? Sim_card_capacity { get; set; }
        public string? Generation_mobile_network { get; set; }
        public int? Bluetooth_version { get; set; }
    }

    public class PortsInterfaces
    {
        public bool? Has_lightning_connector { get; set; }
        public bool? Has_usb { get; set; }
        public string? Type_of_connector { get; set; }
    }
    public class Sensors
    {
        public bool? Has_barometer { get; set; }
        public bool? Has_gyroscope { get; set; }
        public bool? Has_accelerometer { get; set; }
        public bool? Has_proximity_sensor { get; set; }
        public bool? Has_ambient_light_sensor { get; set; }
    }

    public class Software
    {
        public string? Os { get; set; }
    }

    public class Storage
    {
        public int? Capacity__gb { get; set; }
    }


    public class OpinionModel
    {
        public string? Content { get; set; }
        public int? Rating { get; set; }
        public string? User { get; set; }
    }
}

