namespace Mts_Api.Models.DTOs
{
    public class PhoneDTO
    {
        // Базовая информация
        public int Id { get; set; }
        public string Model { get; set; }
        public string BrandName { get; set; }   // Из PhBrandNavigation
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }

        // Внешний вид
        public string ColorName { get; set; }   // Из PhColorNavigation
        public string Material { get; set; }    // Из PhMaterialNavigation

        // Основное "железо" (то, что спрашивают клиенты)
        public string OSName { get; set; }      // Из PhOsNavigation
        public string Storage { get; set; }     // Из PhStorageNavigation (например, "128 ГБ")
        public int Ram { get; set; }            // PhRam
        public string Processor { get; set; }   // Из PhCpuNavigation (например, "A15 Bionic")

        // Экран и Камера
        public string ScreenSize { get; set; }  // PhScreenSize
        public string MatrixType { get; set; }  // Из PhMatrixNavigation (например, "OLED")
        public string CameraInfo { get; set; }  // Из PhCamNavigation

        // Связь
        public string NetStandart { get; set; } // Из PhNetStandartNavigation (например, "5G")
        public int SimCount { get; set; }       // PhCountSim
    }
}