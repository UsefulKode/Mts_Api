using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Mts_Api.Models;

namespace Mts_Api.Data;

public partial class MtsDbContext : DbContext
{
    public MtsDbContext()
    {
    }

    public MtsDbContext(DbContextOptions<MtsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adapter> Adapters { get; set; }

    public virtual DbSet<Basket> Baskets { get; set; }

    public virtual DbSet<Bluetooth> Blueteeth { get; set; }

    public virtual DbSet<BrandName> BrandNames { get; set; }

    public virtual DbSet<Camera> Cameras { get; set; }

    public virtual DbSet<Charger> Chargers { get; set; }

    public virtual DbSet<ChargerType> ChargerTypes { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<FilmMaterial> FilmMaterials { get; set; }

    public virtual DbSet<FilmType> FilmTypes { get; set; }

    public virtual DbSet<Flash> Flashes { get; set; }

    public virtual DbSet<FormatTv> FormatTvs { get; set; }

    public virtual DbSet<Gadget> Gadgets { get; set; }

    public virtual DbSet<Headset> Headsets { get; set; }

    public virtual DbSet<Laptop> Laptops { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Matrix> Matrices { get; set; }

    public virtual DbSet<NetStandart> NetStandarts { get; set; }

    public virtual DbSet<O> Os { get; set; }

    public virtual DbSet<PersonalDatum> PersonalData { get; set; }

    public virtual DbSet<PhAccessory> PhAccessories { get; set; }

    public virtual DbSet<PhCase> PhCases { get; set; }

    public virtual DbSet<PhCaseMaterial> PhCaseMaterials { get; set; }

    public virtual DbSet<PhCaseType> PhCaseTypes { get; set; }

    public virtual DbSet<Phone> Phones { get; set; }

    public virtual DbSet<Port> Ports { get; set; }

    public virtual DbSet<PowerBank> PowerBanks { get; set; }

    public virtual DbSet<Processor> Processors { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Protector> Protectors { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sensor> Sensors { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Slate> Slates { get; set; }

    public virtual DbSet<Sound> Sounds { get; set; }

    public virtual DbSet<Specification> Specifications { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<Tarif> Tarifs { get; set; }

    public virtual DbSet<Tv> Tvs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Video> Videos { get; set; }

    public virtual DbSet<Watch> Watches { get; set; }

    public virtual DbSet<Wifi> Wifis { get; set; }

    public virtual DbSet<WpStandart> WpStandarts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=46.182.132.89,1433;Database=MTS;User Id=sofa;Password=cjyz2605*;TrustServerCertificate=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adapter>(entity =>
        {
            entity.HasOne(d => d.AdapterBrandNavigation).WithMany(p => p.Adapters).HasConstraintName("FK_Adapter_Brand_name");

            entity.HasOne(d => d.AdapterColorNavigation).WithMany(p => p.Adapters).HasConstraintName("FK_Adapter_Color");

            entity.HasOne(d => d.AdapterPort1Navigation).WithMany(p => p.AdapterAdapterPort1Navigations).HasConstraintName("FK_Adapter_Port");

            entity.HasOne(d => d.AdapterPort2Navigation).WithMany(p => p.AdapterAdapterPort2Navigations).HasConstraintName("FK_Adapter_Port1");

            entity.HasOne(d => d.IdAdapterPoductGroupTypeNavigation).WithMany(p => p.Adapters).HasConstraintName("FK_Adapter_Product");
        });

        modelBuilder.Entity<Basket>(entity =>
        {
            entity.Property(e => e.UnicCode).IsFixedLength();

            entity.HasOne(d => d.ConsultantUserNavigation).WithMany(p => p.Baskets).HasConstraintName("FK_Basket_User");
        });

        modelBuilder.Entity<Charger>(entity =>
        {
            entity.HasOne(d => d.ChBrandNavigation).WithMany(p => p.Chargers).HasConstraintName("FK_Charger_Brand_name");

            entity.HasOne(d => d.ChColorNavigation).WithMany(p => p.Chargers).HasConstraintName("FK_Charger_Color");

            entity.HasOne(d => d.ChMaterialNavigation).WithMany(p => p.Chargers).HasConstraintName("FK_Charger_Material");

            entity.HasOne(d => d.ChPortNavigation).WithMany(p => p.Chargers).HasConstraintName("FK_Charger_Port");

            entity.HasOne(d => d.ChTypeNavigation).WithMany(p => p.Chargers).HasConstraintName("FK_Charger_Charger_type");

            entity.HasOne(d => d.IdChPoductGroupTypeNavigation).WithMany(p => p.Chargers).HasConstraintName("FK_Charger_Product");
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasKey(e => e.IdFilm).HasName("PK_Films_1");

            entity.HasOne(d => d.FilmGadgetNavigation).WithMany(p => p.Films).HasConstraintName("FK_Films_Gadgets");

            entity.HasOne(d => d.FilmMaterialNavigation).WithMany(p => p.Films).HasConstraintName("FK_Films_Film_material");

            entity.HasOne(d => d.FilmPhoneNavigation).WithMany(p => p.Films).HasConstraintName("FK_Films_Phone");

            entity.HasOne(d => d.FilmTypeNavigation).WithMany(p => p.Films).HasConstraintName("FK_Films_Film_type");

            entity.HasOne(d => d.IdFilmBrendNavigation).WithMany(p => p.Films).HasConstraintName("FK_Films_Brand_name");

            entity.HasOne(d => d.IdFilmProtectorsNavigation).WithMany(p => p.Films).HasConstraintName("FK_Films_Protector");
        });

        modelBuilder.Entity<Flash>(entity =>
        {
            entity.HasOne(d => d.FlBrandNavigation).WithMany(p => p.Flashes).HasConstraintName("FK_Flash_Brand_name");

            entity.HasOne(d => d.FlColorNavigation).WithMany(p => p.Flashes).HasConstraintName("FK_Flash_Color");

            entity.HasOne(d => d.FlPortNavigation).WithMany(p => p.Flashes).HasConstraintName("FK_Flash_Port");

            entity.HasOne(d => d.FlStorageNavigation).WithMany(p => p.Flashes).HasConstraintName("FK_Flash_Storage");

            entity.HasOne(d => d.IdFlPoductGroupTypeNavigation).WithMany(p => p.Flashes).HasConstraintName("FK_Flash_Product");
        });

        modelBuilder.Entity<Headset>(entity =>
        {
            entity.HasOne(d => d.HdBluetoothNavigation).WithMany(p => p.Headsets).HasConstraintName("FK_Headset_Bluetooth");

            entity.HasOne(d => d.HdBrendNavigation).WithMany(p => p.Headsets).HasConstraintName("FK_Headset_Brand_name");

            entity.HasOne(d => d.HdColorNavigation).WithMany(p => p.Headsets).HasConstraintName("FK_Headset_Color");

            entity.HasOne(d => d.HdSensorsNavigation).WithMany(p => p.Headsets).HasConstraintName("FK_Headset_Sensors");

            entity.HasOne(d => d.HdSpecsNavigation).WithMany(p => p.Headsets).HasConstraintName("FK_Headset_Specifications");

            entity.HasOne(d => d.HdWpStandartNavigation).WithMany(p => p.Headsets).HasConstraintName("FK_Headset_Wp_standart");

            entity.HasOne(d => d.IdHdPoductGroupTypeNavigation).WithMany(p => p.Headsets).HasConstraintName("FK_Headset_Product");
        });

        modelBuilder.Entity<Laptop>(entity =>
        {
            entity.HasOne(d => d.IdLpPoductGroupTypeNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Product");

            entity.HasOne(d => d.LpBluetoothNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Bluetooth");

            entity.HasOne(d => d.LpBrandNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Brand_name");

            entity.HasOne(d => d.LpCamNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Camera");

            entity.HasOne(d => d.LpColorNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Color");

            entity.HasOne(d => d.LpCpuNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Processor");

            entity.HasOne(d => d.LpMaterialNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Material");

            entity.HasOne(d => d.LpMatrixNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Matrix");

            entity.HasOne(d => d.LpNetStandartNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Net_standart");

            entity.HasOne(d => d.LpOsNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Os");

            entity.HasOne(d => d.LpStorageNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Storage");

            entity.HasOne(d => d.LpVideoNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Video");

            entity.HasOne(d => d.LpWifiNavigation).WithMany(p => p.Laptops).HasConstraintName("FK_Laptop_Wifi");
        });

        modelBuilder.Entity<PhAccessory>(entity =>
        {
            entity.HasOne(d => d.IdPhAccsProductGroupTypeNavigation).WithMany(p => p.PhAccessories).HasConstraintName("FK_Ph_accessories_Product");
        });

        modelBuilder.Entity<PhCase>(entity =>
        {
            entity.HasOne(d => d.IdPhCaseAccessoriesTypeNavigation).WithMany(p => p.PhCases).HasConstraintName("FK_Ph_case_Ph_accessories");

            entity.HasOne(d => d.PhCaseBrandNavigation).WithMany(p => p.PhCases).HasConstraintName("FK_Ph_case_Brand_name");

            entity.HasOne(d => d.PhCaseColorNavigation).WithMany(p => p.PhCases).HasConstraintName("FK_Ph_case_Color");

            entity.HasOne(d => d.PhCaseMaterialNavigation).WithMany(p => p.PhCases).HasConstraintName("FK_Ph_case_Ph_case_material");

            entity.HasOne(d => d.PhCasePhoneNavigation).WithMany(p => p.PhCases).HasConstraintName("FK_Ph_case_Phone");

            entity.HasOne(d => d.PhCaseTypeNavigation).WithMany(p => p.PhCases).HasConstraintName("FK_Ph_case_Ph_case_type");
        });

        modelBuilder.Entity<Phone>(entity =>
        {
            entity.HasOne(d => d.IdPhPoductGroupTypeNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Product");

            entity.HasOne(d => d.PhBluetoothNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Bluetooth");

            entity.HasOne(d => d.PhBrandNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Brand_name");

            entity.HasOne(d => d.PhCamNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Camera");

            entity.HasOne(d => d.PhColorNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Color");

            entity.HasOne(d => d.PhCpuNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Processor");

            entity.HasOne(d => d.PhMaterialNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Material");

            entity.HasOne(d => d.PhMatrixNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Matrix");

            entity.HasOne(d => d.PhNetStandartNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Net_standart");

            entity.HasOne(d => d.PhOsNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Os");

            entity.HasOne(d => d.PhPortNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Port");

            entity.HasOne(d => d.PhStorageNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Storage");

            entity.HasOne(d => d.PhVideoNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Video");

            entity.HasOne(d => d.PhWifiNavigation).WithMany(p => p.Phones).HasConstraintName("FK_Phone_Wifi");
        });

        modelBuilder.Entity<PowerBank>(entity =>
        {
            entity.HasOne(d => d.IdPbPoductGroupTypeNavigation).WithMany(p => p.PowerBanks).HasConstraintName("FK_Power_bank_Product");

            entity.HasOne(d => d.PbBrandNavigation).WithMany(p => p.PowerBanks).HasConstraintName("FK_Power_bank_Brand_name");

            entity.HasOne(d => d.PbColorNavigation).WithMany(p => p.PowerBanks).HasConstraintName("FK_Power_bank_Color");

            entity.HasOne(d => d.PbMaterialNavigation).WithMany(p => p.PowerBanks).HasConstraintName("FK_Power_bank_Material");
        });

        modelBuilder.Entity<Protector>(entity =>
        {
            entity.HasOne(d => d.IdPhProtectorAccessoriesTypeNavigation).WithMany(p => p.Protectors).HasConstraintName("FK_Protector_Ph_accessories");
        });

        modelBuilder.Entity<Sensor>(entity =>
        {
            entity.Property(e => e.Sensor1).IsFixedLength();
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasOne(d => d.IdSvPoductGroupTypeNavigation).WithMany(p => p.Services).HasConstraintName("FK_Service_Product");
        });

        modelBuilder.Entity<Slate>(entity =>
        {
            entity.HasOne(d => d.IdSlPoductGroupTypeNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Product");

            entity.HasOne(d => d.SlBluetoothNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Bluetooth");

            entity.HasOne(d => d.SlBrandNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Brand_name");

            entity.HasOne(d => d.SlCamNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Camera");

            entity.HasOne(d => d.SlColorNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Color");

            entity.HasOne(d => d.SlCpuNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Processor");

            entity.HasOne(d => d.SlMatrixNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Matrix");

            entity.HasOne(d => d.SlNetStandartNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Net_standart");

            entity.HasOne(d => d.SlOsNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Os");

            entity.HasOne(d => d.SlStorageNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Storage");

            entity.HasOne(d => d.SlVideoNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Video");

            entity.HasOne(d => d.SlWifiNavigation).WithMany(p => p.Slates).HasConstraintName("FK_Slate_Wifi");
        });

        modelBuilder.Entity<Tarif>(entity =>
        {
            entity.HasOne(d => d.IdTarifPoductGroupTypeNavigation).WithMany(p => p.Tarifs).HasConstraintName("FK_Tarif_Product");
        });

        modelBuilder.Entity<Tv>(entity =>
        {
            entity.HasOne(d => d.IdTvPoductGroupTypeNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Product");

            entity.HasOne(d => d.TvBluetoothNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Bluetooth");

            entity.HasOne(d => d.TvBrandNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Brand_name");

            entity.HasOne(d => d.TvCpuNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Processor");

            entity.HasOne(d => d.TvFormatNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Format_tv");

            entity.HasOne(d => d.TvMatrixNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Matrix");

            entity.HasOne(d => d.TvOsNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Os");

            entity.HasOne(d => d.TvSoundNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Sound");

            entity.HasOne(d => d.TvStorageNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Storage");

            entity.HasOne(d => d.TvVideoNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Video");

            entity.HasOne(d => d.TvWifiNavigation).WithMany(p => p.Tvs).HasConstraintName("FK_Tv_Wifi");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users).HasConstraintName("FK_User_Role");
        });

        modelBuilder.Entity<Watch>(entity =>
        {
            entity.HasKey(e => e.IdWatch).HasName("PK_Wath");

            entity.HasOne(d => d.IdWtPoductGroupTypeNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Product");

            entity.HasOne(d => d.WtBluetoothNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Bluetooth");

            entity.HasOne(d => d.WtBrandNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Brand_name");

            entity.HasOne(d => d.WtCamNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Camera");

            entity.HasOne(d => d.WtColorNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Color");

            entity.HasOne(d => d.WtCpuNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Processor");

            entity.HasOne(d => d.WtMaterialNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Material");

            entity.HasOne(d => d.WtMatrixNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Matrix");

            entity.HasOne(d => d.WtNetStandartNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Net_standart");

            entity.HasOne(d => d.WtOsNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Os");

            entity.HasOne(d => d.WtPortNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Port");

            entity.HasOne(d => d.WtStorageNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Storage");

            entity.HasOne(d => d.WtVideoNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Video");

            entity.HasOne(d => d.WtWifiNavigation).WithMany(p => p.Watches).HasConstraintName("FK_Watch_Wifi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
