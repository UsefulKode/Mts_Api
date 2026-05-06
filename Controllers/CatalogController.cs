using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mts_Api.Data;
using Mts_Api.Models.DTOs;

namespace Mts_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly MtsDbContext _context;
        public CatalogController(MtsDbContext context) => _context = context;

        [HttpGet("{category}")]
        public async Task<ActionResult<IEnumerable<ShortProductDTO>>> GetCategoryItems(string category)
        {
            // Приводим к нижнему регистру, чтобы не было ошибок из-за разного написания
            category = category.ToLower();

            if (category == "phones")
            {
                return await _context.Phones
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdPhone,
                        BrandName = p.PhBrandNavigation.BrandName1,
                        Model = p.PhModel,
                        Price = p.PhPrice ?? 0,
                        Stock = p.PhStock ?? 0,
                        ImageUrl = p.PhImage,
                        Category = "phones"
                    }).ToListAsync();
            }

            if (category == "slates")
            {
                return await _context.Slates
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdSlate,
                        BrandName = p.SlBrandNavigation.BrandName1,
                        Model = p.SlModel,
                        Price = p.SlPrice ?? 0,
                        Stock = p.SlStock ?? 0,
                        ImageUrl = p.SlImage,
                        Category = "slates"
                    }).ToListAsync();
            }

            if (category == "watchs")
            {
                return await _context.Watches
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdWatch,
                        BrandName = p.WtBrandNavigation.BrandName1,
                        Model = p.WtModel,
                        Price = p.WtPrice ?? 0,
                        Stock = p.WtStock ?? 0,
                        ImageUrl = p.WtImage,
                        Category = "watchs"
                    }).ToListAsync();
            }

            if (category == "headsets")
            {
                return await _context.Headsets
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdHeadset,
                        BrandName = p.HdBrendNavigation.BrandName1,
                        Model = p.HdModel,
                        Price = p.HdPrice ?? 0,
                        Stock = p.HdStock ?? 0,
                        ImageUrl = p.HdImage,
                        Category = "headsets"
                    }).ToListAsync();
            }

            if (category == "laptops")
            {
                return await _context.Laptops
                    .Include(l=>l.LpBrandNavigation)
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdLaptop,
                        BrandName = p.LpBrandNavigation.BrandName1,
                        Model = p.LpModel,
                        Price = p.LpPrice ?? 0,
                        Stock = p.LpStock ?? 0,
                        ImageUrl = p.LpImage,
                        Category = "laptops"
                    }).ToListAsync();
            }

            if (category == "tvs")
            {
                return await _context.Tvs
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdTv,
                        BrandName = p.TvBrandNavigation.BrandName1,
                        Model = p.TvModel,
                        Price = p.TvPrice ?? 0,
                        Stock = p.TvStock ?? 0,
                        ImageUrl = p.TvImage,
                        Category = "tvs"
                    }).ToListAsync();
            }

            if (category == "powerbanks")
            {
                return await _context.PowerBanks
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdPowerBank,
                        BrandName = p.PbBrandNavigation.BrandName1,
                        Model = p.PbModel,
                        Price = p.PbPrice ?? 0,
                        Stock = p.PbStock ?? 0,
                        ImageUrl = p.PbImage,
                        Category = "powerbanks"
                    }).ToListAsync();
            }

            if (category == "chargers")
            {
                return await _context.Chargers
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdСharger,
                        BrandName = p.ChBrandNavigation.BrandName1,
                        Model = p.ChModel,
                        Price = p.ChPrice ?? 0,
                        Stock = p.ChStock ?? 0,
                        ImageUrl = p.ChImage,
                        Category = "chargers"
                    }).ToListAsync();
            }

            if (category == "adapters")
            {
                return await _context.Adapters
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdAdapter,
                        BrandName = p.AdapterBrandNavigation.BrandName1,
                        Model = p.AdapterModel,
                        Price = p.AdapterPrice ?? 0,
                        Stock = p.AdapterStock ?? 0,
                        ImageUrl = p.AdapterImage,
                        Category = "adapters"
                    }).ToListAsync();
            }

            if (category == "flashs")
            {
                return await _context.Flashes
                    .Select(p => new ShortProductDTO
                    {
                        Id = p.IdFlash,
                        BrandName = p.FlBrandNavigation.BrandName1,
                        Model = p.FlModel,
                        Price = p.FlPrice ?? 0,
                        Stock = p.FlStock ?? 0,
                        ImageUrl = p.FlImage,
                        Category = "flashs"
                    }).ToListAsync();
            }



            if (category == "phcases") // Название должно совпадать с тем, что шлет MAUI
            {
                return await _context.PhCases // Проверьте имя таблицы в контексте
                    .Select(a => new ShortProductDTO
                    {
                        Id = a.IdPhCase,
                        BrandName = a.PhCaseBrandNavigation.ToString(), // Если у аксессуаров нет бренда, пишем заглушку
                        Model = a.PhCaseModel,
                        Price = a.PhCasePrice ?? 0,
                        Stock = (a.PhCaseStock ?? false) ? 1 : 0,
                        ImageUrl = a.PhCaseImage,
                        Category = "phcases"
                    }).ToListAsync();
            }

            if (category == "films") // Название должно совпадать с тем, что шлет MAUI
            {
                return await _context.Films // Проверьте имя таблицы в контексте
                    .Include(l=>l.IdFilmBrendNavigation)
                    .Select(a => new ShortProductDTO
                    {
                        Id = a.IdFilm,
                        BrandName = a.IdFilmBrend.ToString(), // Если у аксессуаров нет бренда, пишем заглушку
                        Model = a.FilmModel,
                        Price = 500,
                        Stock = a.FilmStock ?? 0,
                        Category = "films"
                    }).ToListAsync();
            }

            return NotFound();
        }


        [HttpGet("{category}/{id}")]
        public async Task<IActionResult> GetItemDetails(string category, int id)
        {
            return category.ToLower() switch
            {
                "phones" => Ok(await GetPhoneDetails(id)),
                "laptops" => Ok(await GetLaptopDetails(id)),
                "tvs" => Ok(await GetTvDetails(id)),
                "headsets" => Ok(await GetHeadsetDetails(id)), 
                "slates" => Ok(await GetSlateDetails(id)),     
                "watchs" => Ok(await GetWatchDetails(id)),     
                _ => NotFound("Детальное описание для этой категории в процессе разработки")
            };
        }
        private async Task<FullProductDTO> GetLaptopDetails(int id)
        {
            // Загружаем ноутбук со всеми связанными справочниками
            var l = await _context.Laptops
                .Include(x => x.LpBrandNavigation)
                .Include(x => x.LpCpuNavigation)
                .Include(x => x.LpVideoNavigation)   
                .Include(x => x.LpMatrixNavigation)
                .Include(x => x.LpOsNavigation)
                .Include(x => x.LpStorageNavigation)
                .Include(x => x.LpColorNavigation)
                .Include(x => x.LpBluetoothNavigation)
                .FirstOrDefaultAsync(x => x.IdLaptop == id);

            if (l == null) return null;

            return new FullProductDTO
            {
                Id = l.IdLaptop,
                Model = l.LpModel ?? "Модель не указана",
                Price = l.LpPrice ?? 0,
                Stock = l.LpStock ?? 0,
                ImageUrl = l.LpImage,
                // Собираем все характеристики в словарь для мобильного приложения
                Specs = new Dictionary<string, string>
        {
            { "Бренд", l.LpBrandNavigation?.BrandName1 ?? "—" },
            { "Процессор", l.LpCpuNavigation?.Processor1 ?? "—" },
            { "Ядер процессора", l.LpCore?.ToString() ?? "—" },
            { "Видеокарта", l.LpVideoNavigation?.Video1 ?? "—" }, 
            { "Оперативная память", (l.LpRam?.ToString() ?? "0") + " ГБ" },
            { "Накопитель", l.LpStorageNavigation?.Sorage.ToString() ?? "—" },
            { "Экран", (l.LpScreenSize?.ToString() ?? "—") + "\"" },
            { "Тип матрицы", l.LpMatrixNavigation?.MatrixType ?? "—" },
            { "Разрешение", (l.LpScreenResH != null && l.LpScreenResV != null) ? $"{l.LpScreenResH}x{l.LpScreenResV}" : "—" },     
            { "ОС", l.LpOsNavigation?.OsName ?? "—" },
            { "Цвет", l.LpColorNavigation?.ColorName ?? "—" },
            { "HDMI", l.LpHdmi == 1 ? "Есть" : "Нет" },
            { "Type-C", l.LpTypeC == 1 ? "Есть" : "Нет" },
            { "Bluetooth", l.LpBluetoothNavigation?.Bluetooth1.ToString() ?? "—" },
            { "Вес", (l.LpMassa?.ToString() ?? "—") + " кг" }
        }
            };
        }
        private async Task<FullProductDTO> GetHeadsetDetails(int id)
        {
            var h = await _context.Headsets
                .Include(x => x.HdBrend)
                .Include(x => x.HdSpecs) // Датчики (таблица Specification)
                .Include(x => x.HdBluetoothNavigation)
                .FirstOrDefaultAsync(x => x.IdHeadset == id);

            if (h == null) return null;

            return new FullProductDTO
            {
                Id = h.IdHeadset,
                Model = h.HdModel,
                Price = h.HdPrice ?? 0,
                Specs = new Dictionary<string, string> {
                { "Бренд", h.HdBrendNavigation?.BrandName1 ?? "-" },
                { "Датчики/Особенности", h.HdSpecsNavigation?.Specifications ?? "-" },
                { "Bluetooth", h.HdBluetoothNavigation?.Bluetooth1.ToString() },
            }
            };
        }
        private async Task<FullProductDTO> GetTvDetails(int id)
        {
            var t = await _context.Tvs
                .Include(x => x.TvBrandNavigation)
                .Include(x => x.TvSoundNavigation) // Звуковая система (Sound)
                .Include(x => x.TvMatrixNavigation)
                .Include(x => x.TvFormatNavigation) // Формат экрана (9:16 и т.д.)
                .FirstOrDefaultAsync(x => x.IdTv == id);

            if (t == null) return null;

            return new FullProductDTO
            {
                Id = t.IdTv,
                Model = t.TvModel,
                Price = t.TvPrice ?? 0,
                Specs = new Dictionary<string, string> {
                { "Бренд", t.TvBrandNavigation?.BrandName1 },
                { "Звук", t.TvSoundNavigation?.Sound1 },
                { "Матрица", t.TvMatrixNavigation?.MatrixType },
                { "Формат экрана", t.TvFormatNavigation?.Format },
                { "Smart TV", t.TvSmart == true ? "Да" : "Нет" }
            }
            };
        }
        private async Task<FullProductDTO> GetPhoneDetails(int id)
        {
            // Загружаем телефон со всеми связанными справочниками
            var p = await _context.Phones
                .Include(x => x.PhBrandNavigation)
                .Include(x => x.PhCpuNavigation)
                .Include(x => x.PhOsNavigation)
                .Include(x => x.PhStorageNavigation)
                .Include(x => x.PhColorNavigation)
                .Include(x => x.PhCamNavigation)
                .Include(x => x.PhMatrixNavigation)
                .Include(x => x.PhNetStandartNavigation)
                .Include(x => x.PhMaterialNavigation)
                .Include(x => x.PhPortNavigation)
                .Include(x => x.PhVideoNavigation)
                .Include(x => x.PhWifiNavigation)
                .Include(x => x.PhBluetoothNavigation)
                .FirstOrDefaultAsync(x => x.IdPhone == id);

            if (p == null) return null;

            return new FullProductDTO
            {
                Id = p.IdPhone,
                Model = p.PhModel ?? "Модель не указана",
                Price = p.PhPrice ?? 0,
                Stock = p.PhStock ?? 0,
                ImageUrl = p.PhImage,
                // Собираем характеристики в словарь
                Specs = new Dictionary<string, string>
                {
                    { "Бренд", p.PhBrandNavigation?.BrandName1 ?? "-" },
                    { "Процессор", p.PhCpuNavigation?.Processor1 ?? "-" }, // Предположил имя поля в справочнике
                    { "Количество ядер", p.PhCore?.ToString() ?? "-" },
                    { "Оперативная память", p.PhRam?.ToString() + " ГБ" },
                    { "Встроенная память", p.PhStorageNavigation?.Sorage.ToString() ?? "-" },
                    { "Операционная система", p.PhOsNavigation?.OsName ?? "-" },
                    { "Экран", $"{p.PhScreenSize}\" ({p.PhScreenResH}x{p.PhScreenResV})" },
                    { "Тип матрицы", p.PhMatrixNavigation?.MatrixType ?? "-" },
                    { "Камера", p.PhCamNavigation?.CameraRes.ToString() ?? "-" },
                    { "Аккумулятор", p.PhAcum?.ToString() + " мАч" },
                    { "Количество SIM", p.PhCountSim?.ToString() ?? "-" },
                    { "Материал корпуса", p.PhMaterialNavigation?.Material1 ?? "-" },
                    { "Интерфейс", p.PhPortNavigation?.PortType ?? "-" },
                    { "Стандарт сети", p.PhNetStandartNavigation?.NetStandart1 ?? "-" },
                    { "Wi-Fi", p.PhWifiNavigation?.Wifi1 ?? "-" },
                    { "Bluetooth", p.PhBluetoothNavigation?.Bluetooth1.ToString() ?? "-" },
                    { "Цвет", p.PhColorNavigation?.ColorName ?? "-" }
                }
            };
        }
        private async Task<FullProductDTO> GetSlateDetails(int id)
        {
            var sl = await _context.Slates
                .Include(x => x.SlBrandNavigation)
                .Include(x => x.SlCpuNavigation)
                .Include(x => x.SlVideoNavigation)
                .Include(x => x.SlMatrixNavigation)
                .Include(x => x.SlOsNavigation)
                .Include(x => x.SlStorageNavigation)
                .Include(x => x.SlColorNavigation)
                .Include(x => x.SlBluetoothNavigation)
                .Include(x => x.SlWifiNavigation) // Если есть в контексте
                .FirstOrDefaultAsync(x => x.IdSlate == id);

            if (sl == null) return null;

            return new FullProductDTO
            {
                Id = sl.IdSlate,
                Model = sl.SlModel ?? "Модель не указана",
                Price = sl.SlPrice ?? 0,
                Stock = sl.SlStock ?? 0,
                ImageUrl = sl.SlImage,

                // Формируем словарь характеристик для мобильного устройства
                Specs = new Dictionary<string, string>
                {
                    { "Бренд", sl.SlBrandNavigation?.BrandName1 ?? "-" },
                    { "Процессор", sl.SlCpuNavigation?.Processor1 ?? "-" },
                    { "Ядер процессора", sl.SlCore?.ToString() ?? "-" },
                    { "Видеочип", sl.SlVideoNavigation?.Video1 ?? "-" },
                    { "Оперативная память", (sl.SlRam?.ToString() ?? "-") + " ГБ" },
                    { "Накопитель", sl.SlStorageNavigation?.Sorage.ToString() ?? "-" },
                    { "Экран", (sl.SlScreenSize?.ToString() ?? "-") + "\"" },
                    { "Тип матрицы", sl.SlMatrixNavigation?.MatrixType ?? "-" },
                    { "Разрешение", $"{sl.SlScreenResH}x{sl.SlScreenResV}" },
                    { "ОС", sl.SlOsNavigation?.OsName ?? "-" },
                    { "Камера", (sl.SlCam?.ToString() ?? "-") + " Мп" },
                    { "Кол-во SIM-карт", sl.SlCountSim?.ToString() ?? "-" },
                    { "Аккумулятор", (sl.SlAcum?.ToString() ?? "-") + " мАч" },
                    { "Цвет", sl.SlColorNavigation?.ColorName ?? "-" },
                    { "Bluetooth", sl.SlBluetoothNavigation?.Bluetooth1.ToString() ?? "-" },
                    { "Wi-Fi", sl.SlWifiNavigation?.Wifi1 ?? "-" }
                }
            };
        }
        private async Task<FullProductDTO> GetWatchDetails(int id)
        {
            var wt = await _context.Watches
            .Include(x => x.WtBrandNavigation)
            .Include(x => x.WtCpuNavigation)
            .Include(x => x.WtMatrixNavigation)
            .Include(x => x.WtOsNavigation)
            .Include(x => x.WtStorageNavigation)
            .Include(x => x.WtColorNavigation)
            .Include(x => x.WtMaterialNavigation)
            .Include(x => x.WtPortNavigation)
            .Include(x => x.WtBluetoothNavigation)
            .Include(x => x.WtWifiNavigation)
            .FirstOrDefaultAsync(x => x.IdWatch == id);

            if (wt == null) return null;

            return new FullProductDTO
            {
                Id = wt.IdWatch,
                Model = wt.WtModel ?? "Модель не указана",
                Price = wt.WtPrice ?? 0,
                Stock = wt.WtStock ?? 0,
                ImageUrl = wt.WtImage,

                // Формируем словарь характеристик для часов
                Specs = new Dictionary<string, string>
                {
                    { "Бренд", wt.WtBrandNavigation?.BrandName1 ?? "-" },
                    { "Материал корпуса", wt.WtMaterialNavigation?.Material1 ?? "-" }, // Предположил имя поля
                    { "Цвет", wt.WtColorNavigation?.ColorName ?? "-" },
                    { "Экран", (wt.WtScreenSize?.ToString() ?? "-") + "\"" },
                    { "Тип матрицы", wt.WtMatrixNavigation?.MatrixType ?? "-" },
                    { "Разрешение", $"{wt.WtScreenResH}x{wt.WtScreenResV}" },
                    { "Процессор", wt.WtCpuNavigation?.Processor1 ?? "-" },
                    { "Оперативная память", (wt.WtRam?.ToString() ?? "-") + " МБ" },
                    { "Встроенная память", wt.WtStorageNavigation?.Sorage.ToString() ?? "-" },
                    { "Операционная система", wt.WtOsNavigation?.OsName ?? "-" },
                    { "Аккумулятор", (wt.WtAcum?.ToString() ?? "-") + " мАч" },
                    { "Разъем зарядки", wt.WtPortNavigation?.PortType ?? "-" }, // Предположил имя поля
                    { "Bluetooth", wt.WtBluetoothNavigation?.Bluetooth1.ToString() ?? "-" },
                    { "Wi-Fi", wt.WtWifiNavigation?.Wifi1 ?? "-" }
                }
            };
        }
    }
}
