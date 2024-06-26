using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IKProje.Models;

public partial class Pro02SbtContext : DbContext
{
    public Pro02SbtContext()
    {
    }

    public Pro02SbtContext(DbContextOptions<Pro02SbtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aylikpuantajtanim> Aylikpuantajtanims { get; set; }

    public virtual DbSet<Bolumdepart> Bolumdeparts { get; set; }

    public virtual DbSet<BorcIzin> BorcIzins { get; set; }

    public virtual DbSet<BorcIzinDevir> BorcIzinDevirs { get; set; }

    public virtual DbSet<BorcIzinFm> BorcIzinFms { get; set; }

    public virtual DbSet<Dislokyemsay> Dislokyemsays { get; set; }

    public virtual DbSet<DosyaAyarlari> DosyaAyarlaris { get; set; }

    public virtual DbSet<DönüştürmeHataları> DönüştürmeHatalarıs { get; set; }

    public virtual DbSet<DönüştürmeHataları1> DönüştürmeHataları1s { get; set; }

    public virtual DbSet<Fazlamesaimasraf> Fazlamesaimasrafs { get; set; }

    public virtual DbSet<Fazlamesaineden> Fazlamesainedens { get; set; }

    public virtual DbSet<Haftaparam> Haftaparams { get; set; }

    public virtual DbSet<IgdasImport> IgdasImports { get; set; }

    public virtual DbSet<IzinPusulasi> IzinPusulasis { get; set; }

    public virtual DbSet<Kapikodlari> Kapikodlaris { get; set; }

    public virtual DbSet<Ndataselect> Ndataselects { get; set; }

    public virtual DbSet<Ozellikler> Ozelliklers { get; set; }

    public virtual DbSet<Ozluk> Ozluks { get; set; }

    public virtual DbSet<Ozlukaile> Ozlukailes { get; set; }

    public virtual DbSet<Ozlukcocuk> Ozlukcocuks { get; set; }

    public virtual DbSet<Ozlukisyeri> Ozlukisyeris { get; set; }

    public virtual DbSet<Periyod> Periyods { get; set; }

    public virtual DbSet<PeriyodGunlugu> PeriyodGunlugus { get; set; }

    public virtual DbSet<Personelcikisneden> Personelcikisnedens { get; set; }

    public virtual DbSet<Personeldisiplin> Personeldisiplins { get; set; }

    public virtual DbSet<Personelegitim> Personelegitims { get; set; }

    public virtual DbSet<Personelkaza> Personelkazas { get; set; }

    public virtual DbSet<Personelodul> Personeloduls { get; set; }

    public virtual DbSet<Pgreport> Pgreports { get; set; }

    public virtual DbSet<Puantajgunlugu> Puantajgunlugus { get; set; }

    public virtual DbSet<PuantajgunluguDagilim> PuantajgunluguDagilims { get; set; }

    public virtual DbSet<Puantajtipleri> Puantajtipleris { get; set; }

    public virtual DbSet<Segmentfmplan> Segmentfmplans { get; set; }

    public virtual DbSet<Segmentper> Segmentpers { get; set; }

    public virtual DbSet<SelectedSicil> SelectedSicils { get; set; }

    public virtual DbSet<Servisler> Servislers { get; set; }

    public virtual DbSet<Sicil> Sicils { get; set; }

    public virtual DbSet<SicilResim> SicilResims { get; set; }

    public virtual DbSet<Sirketbilgileri> Sirketbilgileris { get; set; }

    public virtual DbSet<TbKapatma> TbKapatmas { get; set; }

    public virtual DbSet<TbKapatmakolon> TbKapatmakolons { get; set; }

    public virtual DbSet<TbSicilTerm> TbSicilTerms { get; set; }

    public virtual DbSet<TbStrTable> TbStrTables { get; set; }

    public virtual DbSet<TelafiCalismasi> TelafiCalismasis { get; set; }

    public virtual DbSet<Tmptmp> Tmptmps { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Yemekparam> Yemekparams { get; set; }

    public virtual DbSet<Yillikizinnot> Yillikizinnots { get; set; }

    public virtual DbSet<Yillikizinparam> Yillikizinparams { get; set; }

    public virtual DbSet<Yillikizinsonuc> Yillikizinsonucs { get; set; }

    public virtual DbSet<Yillikizintarih> Yillikizintarihs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=UZR-YEDEK;Database=PRO02_SBT;Trusted_Connection=False;Encrypt=False;User Id=sa;Password=Uzer.159753");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aylikpuantajtanim>(entity =>
        {
            entity.HasKey(e => e.AptId).IsClustered(false);

            entity.ToTable("AYLIKPUANTAJTANIM");

            entity.Property(e => e.AptId).HasColumnName("APT_ID");
            entity.Property(e => e.Calisma)
                .HasDefaultValue((short)0)
                .HasColumnName("CALISMA");
            entity.Property(e => e.Kisatanim)
                .HasMaxLength(10)
                .HasColumnName("KISATANIM");
            entity.Property(e => e.Ssk)
                .HasDefaultValue((short)0)
                .HasColumnName("SSK");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
            entity.Property(e => e.Tanimid)
                .HasDefaultValue((short)0)
                .HasColumnName("TANIMID");
            entity.Property(e => e.Toplam)
                .HasDefaultValue((short)0)
                .HasColumnName("TOPLAM");
        });

        modelBuilder.Entity<Bolumdepart>(entity =>
        {
            entity.HasKey(e => e.BdId).IsClustered(false);

            entity.ToTable("BOLUMDEPART");

            entity.Property(e => e.BdId).HasColumnName("BD_ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(30)
                .HasColumnName("ADI");
            entity.Property(e => e.Anakod)
                .HasMaxLength(10)
                .HasColumnName("ANAKOD");
            entity.Property(e => e.FOrder)
                .HasDefaultValue(0)
                .HasColumnName("F_ORDER");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .HasColumnName("KODU");
            entity.Property(e => e.Sonkod)
                .HasMaxLength(10)
                .HasColumnName("SONKOD");
            entity.Property(e => e.Tipi)
                .HasMaxLength(1)
                .HasColumnName("TIPI");
        });

        modelBuilder.Entity<BorcIzin>(entity =>
        {
            entity.HasKey(e => e.BiId).IsClustered(false);

            entity.ToTable("BORC_IZIN");

            entity.Property(e => e.BiId).HasColumnName("BI_ID");
            entity.Property(e => e.Ay)
                .HasDefaultValue(0)
                .HasColumnName("AY");
            entity.Property(e => e.Borcsaati)
                .HasDefaultValue(0)
                .HasColumnName("BORCSAATI");
            entity.Property(e => e.Devir)
                .HasDefaultValue(0)
                .HasColumnName("DEVIR");
            entity.Property(e => e.Fazlamesai)
                .HasDefaultValue(0)
                .HasColumnName("FAZLAMESAI");
            entity.Property(e => e.MaxFm)
                .HasDefaultValue(0)
                .HasColumnName("MAX_FM");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Yil)
                .HasDefaultValue(0)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<BorcIzinDevir>(entity =>
        {
            entity.HasKey(e => e.BidId).IsClustered(false);

            entity.ToTable("BORC_IZIN_DEVIR");

            entity.Property(e => e.BidId).HasColumnName("BID_ID");
            entity.Property(e => e.Ay)
                .HasDefaultValue((short)0)
                .HasColumnName("AY");
            entity.Property(e => e.Balanslananay)
                .HasDefaultValue((short)0)
                .HasColumnName("BALANSLANANAY");
            entity.Property(e => e.Borc).HasColumnName("BORC");
            entity.Property(e => e.Deviray)
                .HasDefaultValue((short)0)
                .HasColumnName("DEVIRAY");
            entity.Property(e => e.Fm1).HasColumnName("FM1");
            entity.Property(e => e.Fm1Kod)
                .HasMaxLength(3)
                .HasColumnName("FM1_KOD");
            entity.Property(e => e.Fm2).HasColumnName("FM2");
            entity.Property(e => e.Fm2Kod)
                .HasMaxLength(3)
                .HasColumnName("FM2_KOD");
            entity.Property(e => e.Fm3).HasColumnName("FM3");
            entity.Property(e => e.Fm3Kod)
                .HasMaxLength(3)
                .HasColumnName("FM3_KOD");
            entity.Property(e => e.Fm4).HasColumnName("FM4");
            entity.Property(e => e.Fm4Kod)
                .HasMaxLength(3)
                .HasColumnName("FM4_KOD");
            entity.Property(e => e.Fm5).HasColumnName("FM5");
            entity.Property(e => e.Fm5Kod)
                .HasMaxLength(3)
                .HasColumnName("FM5_KOD");
            entity.Property(e => e.Serbest)
                .HasDefaultValue((short)0)
                .HasColumnName("SERBEST");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Yil)
                .HasDefaultValue((short)0)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<BorcIzinFm>(entity =>
        {
            entity.HasKey(e => e.BifmId).IsClustered(false);

            entity.ToTable("BORC_IZIN_FM");

            entity.Property(e => e.BifmId).HasColumnName("BIFM_ID");
            entity.Property(e => e.Ay)
                .HasDefaultValue((short)0)
                .HasColumnName("AY");
            entity.Property(e => e.Fm1).HasColumnName("FM1");
            entity.Property(e => e.Fm1Kod)
                .HasMaxLength(3)
                .HasColumnName("FM1_KOD");
            entity.Property(e => e.Fm2).HasColumnName("FM2");
            entity.Property(e => e.Fm2Kod)
                .HasMaxLength(3)
                .HasColumnName("FM2_KOD");
            entity.Property(e => e.Fm3).HasColumnName("FM3");
            entity.Property(e => e.Fm3Kod)
                .HasMaxLength(3)
                .HasColumnName("FM3_KOD");
            entity.Property(e => e.Fm4).HasColumnName("FM4");
            entity.Property(e => e.Fm4Kod)
                .HasMaxLength(3)
                .HasColumnName("FM4_KOD");
            entity.Property(e => e.Fm5).HasColumnName("FM5");
            entity.Property(e => e.Fm5Kod)
                .HasMaxLength(3)
                .HasColumnName("FM5_KOD");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Yil)
                .HasDefaultValue((short)0)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<Dislokyemsay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DISLOKYEMSAY");

            entity.Property(e => e.Extranctoplam).HasColumnName("EXTRANCTOPLAM");
            entity.Property(e => e.FLokasyon)
                .HasMaxLength(20)
                .HasColumnName("F_LOKASYON");
            entity.Property(e => e.FOgun).HasColumnName("F_OGUN");
            entity.Property(e => e.FPkId).HasColumnName("F_PK_ID");
            entity.Property(e => e.FSayi).HasColumnName("F_SAYI");
            entity.Property(e => e.FTarih)
                .HasMaxLength(10)
                .HasColumnName("F_TARIH");
            entity.Property(e => e.Fmsaat2).HasColumnName("FMSAAT2");
        });

        modelBuilder.Entity<DosyaAyarlari>(entity =>
        {
            entity.HasKey(e => e.DaId).IsClustered(false);

            entity.ToTable("DOSYA_AYARLARI");

            entity.Property(e => e.DaId).HasColumnName("DA_ID");
            entity.Property(e => e.Dosya)
                .HasMaxLength(60)
                .HasColumnName("DOSYA");
            entity.Property(e => e.Kapilen)
                .HasDefaultValue((short)0)
                .HasColumnName("KAPILEN");
            entity.Property(e => e.Kapistart)
                .HasDefaultValue((short)0)
                .HasColumnName("KAPISTART");
            entity.Property(e => e.Nedenlen)
                .HasDefaultValue((short)0)
                .HasColumnName("NEDENLEN");
            entity.Property(e => e.Nedenstart)
                .HasDefaultValue((short)0)
                .HasColumnName("NEDENSTART");
            entity.Property(e => e.Saatlen)
                .HasDefaultValue((short)0)
                .HasColumnName("SAATLEN");
            entity.Property(e => e.Saatstart)
                .HasDefaultValue((short)0)
                .HasColumnName("SAATSTART");
            entity.Property(e => e.Sicillen)
                .HasDefaultValue((short)0)
                .HasColumnName("SICILLEN");
            entity.Property(e => e.Sicilstart)
                .HasDefaultValue((short)0)
                .HasColumnName("SICILSTART");
            entity.Property(e => e.Tarihid)
                .HasDefaultValue((short)0)
                .HasColumnName("TARIHID");
            entity.Property(e => e.Tarihstart)
                .HasDefaultValue((short)0)
                .HasColumnName("TARIHSTART");
            entity.Property(e => e.Tarihtip)
                .HasMaxLength(25)
                .HasColumnName("TARIHTIP");
            entity.Property(e => e.Tipcikis)
                .HasMaxLength(1)
                .HasColumnName("TIPCIKIS");
            entity.Property(e => e.Tipgiris)
                .HasMaxLength(1)
                .HasColumnName("TIPGIRIS");
            entity.Property(e => e.Tipstart)
                .HasDefaultValue((short)0)
                .HasColumnName("TIPSTART");
        });

        modelBuilder.Entity<DönüştürmeHataları>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dönüştürme Hataları");

            entity.Property(e => e.HataAçıklama)
                .HasColumnType("ntext")
                .HasColumnName("Hata Açıklama");
            entity.Property(e => e.NesneAdı)
                .HasMaxLength(255)
                .HasColumnName("Nesne Adı");
            entity.Property(e => e.NesneTürü)
                .HasMaxLength(255)
                .HasColumnName("Nesne Türü");
        });

        modelBuilder.Entity<DönüştürmeHataları1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dönüştürme Hataları1");

            entity.Property(e => e.HataAçıklama)
                .HasColumnType("ntext")
                .HasColumnName("Hata Açıklama");
            entity.Property(e => e.NesneAdı)
                .HasMaxLength(255)
                .HasColumnName("Nesne Adı");
            entity.Property(e => e.NesneTürü)
                .HasMaxLength(255)
                .HasColumnName("Nesne Türü");
        });

        modelBuilder.Entity<Fazlamesaimasraf>(entity =>
        {
            entity.HasKey(e => e.FmmId).IsClustered(false);

            entity.ToTable("FAZLAMESAIMASRAF");

            entity.Property(e => e.FmmId).HasColumnName("FMM_ID");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
        });

        modelBuilder.Entity<Fazlamesaineden>(entity =>
        {
            entity.HasKey(e => e.FmnId).IsClustered(false);

            entity.ToTable("FAZLAMESAINEDEN");

            entity.Property(e => e.FmnId).HasColumnName("FMN_ID");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
        });

        modelBuilder.Entity<Haftaparam>(entity =>
        {
            entity.HasKey(e => e.HpId).IsClustered(false);

            entity.ToTable("HAFTAPARAM");

            entity.Property(e => e.HpId).HasColumnName("HP_ID");
            entity.Property(e => e.Arti)
                .HasMaxLength(250)
                .HasColumnName("ARTI");
            entity.Property(e => e.Eksi)
                .HasMaxLength(250)
                .HasColumnName("EKSI");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .HasColumnName("KOD");
            entity.Property(e => e.Kolonno)
                .HasMaxLength(250)
                .HasColumnName("KOLONNO");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
            entity.Property(e => e.Ters)
                .HasMaxLength(250)
                .HasColumnName("TERS");
        });

        modelBuilder.Entity<IgdasImport>(entity =>
        {
            entity.HasKey(e => e.IiId).IsClustered(false);

            entity.ToTable("IGDAS_IMPORT");

            entity.Property(e => e.IiId).HasColumnName("II_ID");
            entity.Property(e => e.AlanAdi)
                .HasMaxLength(1)
                .HasColumnName("ALAN_ADI");
            entity.Property(e => e.Pgkodu)
                .HasMaxLength(3)
                .HasColumnName("PGKODU");
        });

        modelBuilder.Entity<IzinPusulasi>(entity =>
        {
            entity.HasKey(e => e.IpId).IsClustered(false);

            entity.ToTable("IZIN_PUSULASI");

            entity.Property(e => e.IpId).HasColumnName("IP_ID");
            entity.Property(e => e.Bol)
                .HasMaxLength(3)
                .HasColumnName("BOL");
            entity.Property(e => e.Boltanim)
                .HasMaxLength(30)
                .HasColumnName("BOLTANIM");
            entity.Property(e => e.Dep)
                .HasMaxLength(3)
                .HasColumnName("DEP");
            entity.Property(e => e.Deptanim)
                .HasMaxLength(30)
                .HasColumnName("DEPTANIM");
            entity.Property(e => e.Gunmuddet)
                .HasMaxLength(4)
                .HasColumnName("GUNMUDDET");
            entity.Property(e => e.Isegiristarihi)
                .HasMaxLength(10)
                .HasColumnName("ISEGIRISTARIHI");
            entity.Property(e => e.Isstartdate)
                .HasMaxLength(10)
                .HasColumnName("ISSTARTDATE");
            entity.Property(e => e.Isstarttime)
                .HasDefaultValue((short)0)
                .HasColumnName("ISSTARTTIME");
            entity.Property(e => e.Izinenddate)
                .HasMaxLength(10)
                .HasColumnName("IZINENDDATE");
            entity.Property(e => e.Izinendtime)
                .HasDefaultValue((short)0)
                .HasColumnName("IZINENDTIME");
            entity.Property(e => e.Izinsebebi)
                .HasMaxLength(100)
                .HasColumnName("IZINSEBEBI");
            entity.Property(e => e.Izinstartdate)
                .HasMaxLength(10)
                .HasColumnName("IZINSTARTDATE");
            entity.Property(e => e.Izinstarttime)
                .HasDefaultValue((short)0)
                .HasColumnName("IZINSTARTTIME");
            entity.Property(e => e.Izintipi)
                .HasMaxLength(20)
                .HasColumnName("IZINTIPI");
            entity.Property(e => e.Onay)
                .HasDefaultValue((short)0)
                .HasColumnName("ONAY");
            entity.Property(e => e.Pgkod)
                .HasMaxLength(3)
                .HasColumnName("PGKOD");
            entity.Property(e => e.Pgtanim)
                .HasMaxLength(30)
                .HasColumnName("PGTANIM");
            entity.Property(e => e.Saatmuddet)
                .HasDefaultValue((short)0)
                .HasColumnName("SAATMUDDET");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<Kapikodlari>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KAPIKODLARI");

            entity.Property(e => e.Kapiadi)
                .HasMaxLength(100)
                .HasColumnName("KAPIADI");
            entity.Property(e => e.Kapikodu)
                .HasMaxLength(10)
                .HasColumnName("KAPIKODU");
            entity.Property(e => e.Yemekhane)
                .HasDefaultValue((short)0)
                .HasColumnName("YEMEKHANE");
        });

        modelBuilder.Entity<Ndataselect>(entity =>
        {
            entity.HasKey(e => e.FPkId).IsClustered(false);

            entity.ToTable("NDATASELECT");

            entity.HasIndex(e => e.FData, "NDATASELECT_F_KOD");

            entity.Property(e => e.FPkId).HasColumnName("F_PK_ID");
            entity.Property(e => e.FData)
                .HasMaxLength(200)
                .HasColumnName("F_DATA");
            entity.Property(e => e.FKey1)
                .HasMaxLength(20)
                .HasColumnName("F_KEY1");
            entity.Property(e => e.FKey2)
                .HasMaxLength(50)
                .HasColumnName("F_KEY2");
            entity.Property(e => e.FKey3)
                .HasMaxLength(100)
                .HasColumnName("F_KEY3");
        });

        modelBuilder.Entity<Ozellikler>(entity =>
        {
            entity.HasKey(e => e.OId).IsClustered(false);

            entity.ToTable("OZELLIKLER");

            entity.Property(e => e.OId).HasColumnName("O_ID");
            entity.Property(e => e.Cumartesicalisir)
                .HasDefaultValue(0)
                .HasColumnName("CUMARTESICALISIR");
            entity.Property(e => e.Gunatlatmasaati)
                .HasDefaultValue((short)0)
                .HasColumnName("GUNATLATMASAATI");
            entity.Property(e => e.Gundegisimsaati)
                .HasDefaultValue((short)0)
                .HasColumnName("GUNDEGISIMSAATI");
            entity.Property(e => e.Gunufarkligiriscikis)
                .HasDefaultValue((short)0)
                .HasColumnName("GUNUFARKLIGIRISCIKIS");
            entity.Property(e => e.Hareketaltsinir)
                .HasDefaultValue((short)0)
                .HasColumnName("HAREKETALTSINIR");
            entity.Property(e => e.Hareketustsinir)
                .HasDefaultValue((short)0)
                .HasColumnName("HAREKETUSTSINIR");
            entity.Property(e => e.Pgharekettenal)
                .HasDefaultValue((short)0)
                .HasColumnName("PGHAREKETTENAL");
            entity.Property(e => e.Sirketkodu)
                .HasMaxLength(10)
                .HasColumnName("SIRKETKODU");
            entity.Property(e => e.Ssk30danduser)
                .HasDefaultValue(0)
                .HasColumnName("SSK30DANDUSER");
            entity.Property(e => e.Yuvarlamayap)
                .HasDefaultValue((short)0)
                .HasColumnName("YUVARLAMAYAP");
        });

        modelBuilder.Entity<Ozluk>(entity =>
        {
            entity.HasKey(e => e.OId).IsClustered(false);

            entity.ToTable("OZLUK");

            entity.HasIndex(e => e.Sicilno, "OZLUK_SICILNO");

            entity.Property(e => e.OId).HasColumnName("O_ID");
            entity.Property(e => e.Aciladisoyadi)
                .HasMaxLength(20)
                .HasColumnName("ACILADISOYADI");
            entity.Property(e => e.Aciladres)
                .HasMaxLength(100)
                .HasColumnName("ACILADRES");
            entity.Property(e => e.Acilceptel)
                .HasMaxLength(15)
                .HasColumnName("ACILCEPTEL");
            entity.Property(e => e.Acilemail)
                .HasMaxLength(100)
                .HasColumnName("ACILEMAIL");
            entity.Property(e => e.Acilevtel)
                .HasMaxLength(15)
                .HasColumnName("ACILEVTEL");
            entity.Property(e => e.Acililce)
                .HasMaxLength(15)
                .HasColumnName("ACILILCE");
            entity.Property(e => e.Acilistel)
                .HasMaxLength(15)
                .HasColumnName("ACILISTEL");
            entity.Property(e => e.Acilpk)
                .HasMaxLength(8)
                .HasColumnName("ACILPK");
            entity.Property(e => e.Acilsehir)
                .HasMaxLength(20)
                .HasColumnName("ACILSEHIR");
            entity.Property(e => e.Acilsemt)
                .HasMaxLength(15)
                .HasColumnName("ACILSEMT");
            entity.Property(e => e.Adres)
                .HasMaxLength(100)
                .HasColumnName("ADRES");
            entity.Property(e => e.Akademikunvan)
                .HasMaxLength(15)
                .HasColumnName("AKADEMIKUNVAN");
            entity.Property(e => e.Allerji)
                .HasMaxLength(50)
                .HasColumnName("ALLERJI");
            entity.Property(e => e.Anaadi)
                .HasMaxLength(20)
                .HasColumnName("ANAADI");
            entity.Property(e => e.Annekizliksoyadi)
                .HasMaxLength(20)
                .HasColumnName("ANNEKIZLIKSOYADI");
            entity.Property(e => e.Askerlikdurumu)
                .HasMaxLength(15)
                .HasColumnName("ASKERLIKDURUMU");
            entity.Property(e => e.Askerlikrutbesi)
                .HasMaxLength(15)
                .HasColumnName("ASKERLIKRUTBESI");
            entity.Property(e => e.Askerliktarihi)
                .HasMaxLength(15)
                .HasColumnName("ASKERLIKTARIHI");
            entity.Property(e => e.Ayakkabino)
                .HasMaxLength(6)
                .HasColumnName("AYAKKABINO");
            entity.Property(e => e.Babaadi)
                .HasMaxLength(20)
                .HasColumnName("BABAADI");
            entity.Property(e => e.Bagkurno)
                .HasMaxLength(20)
                .HasColumnName("BAGKURNO");
            entity.Property(e => e.Bankaadi1)
                .HasMaxLength(20)
                .HasColumnName("BANKAADI1");
            entity.Property(e => e.Bankaadi2)
                .HasMaxLength(20)
                .HasColumnName("BANKAADI2");
            entity.Property(e => e.Bankahesap1)
                .HasMaxLength(20)
                .HasColumnName("BANKAHESAP1");
            entity.Property(e => e.Bankahesap2)
                .HasMaxLength(20)
                .HasColumnName("BANKAHESAP2");
            entity.Property(e => e.Bedenno)
                .HasMaxLength(6)
                .HasColumnName("BEDENNO");
            entity.Property(e => e.Boy)
                .HasMaxLength(6)
                .HasColumnName("BOY");
            entity.Property(e => e.Ceptel)
                .HasMaxLength(15)
                .HasColumnName("CEPTEL");
            entity.Property(e => e.Ciltno)
                .HasMaxLength(15)
                .HasColumnName("CILTNO");
            entity.Property(e => e.Cinsiyeti)
                .HasMaxLength(6)
                .HasColumnName("CINSIYETI");
            entity.Property(e => e.Ckn)
                .HasMaxLength(15)
                .HasColumnName("CKN");
            entity.Property(e => e.Cocuksayisi)
                .HasDefaultValue((short)0)
                .HasColumnName("COCUKSAYISI");
            entity.Property(e => e.Cuzserino)
                .HasMaxLength(15)
                .HasColumnName("CUZSERINO");
            entity.Property(e => e.Dini)
                .HasMaxLength(15)
                .HasColumnName("DINI");
            entity.Property(e => e.Dogumtarihi)
                .HasMaxLength(10)
                .HasColumnName("DOGUMTARIHI");
            entity.Property(e => e.Dogumyeri)
                .HasMaxLength(15)
                .HasColumnName("DOGUMYERI");
            entity.Property(e => e.Ehliyetsinifi)
                .HasMaxLength(5)
                .HasColumnName("EHLIYETSINIFI");
            entity.Property(e => e.Ehliyettarihi)
                .HasMaxLength(10)
                .HasColumnName("EHLIYETTARIHI");
            entity.Property(e => e.Eli)
                .HasMaxLength(8)
                .HasColumnName("ELI");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Emeksanno)
                .HasMaxLength(20)
                .HasColumnName("EMEKSANNO");
            entity.Property(e => e.Ensonbolum)
                .HasMaxLength(20)
                .HasColumnName("ENSONBOLUM");
            entity.Property(e => e.Ensonokul)
                .HasMaxLength(50)
                .HasColumnName("ENSONOKUL");
            entity.Property(e => e.Evtel)
                .HasMaxLength(15)
                .HasColumnName("EVTEL");
            entity.Property(e => e.Firmagorevi)
                .HasMaxLength(25)
                .HasColumnName("FIRMAGOREVI");
            entity.Property(e => e.Firmayagirisi)
                .HasMaxLength(25)
                .HasColumnName("FIRMAYAGIRISI");
            entity.Property(e => e.Gocmen)
                .HasMaxLength(6)
                .HasColumnName("GOCMEN");
            entity.Property(e => e.Gomlekno)
                .HasMaxLength(6)
                .HasColumnName("GOMLEKNO");
            entity.Property(e => e.Gozluk)
                .HasMaxLength(10)
                .HasColumnName("GOZLUK");
            entity.Property(e => e.Hukumlu)
                .HasMaxLength(6)
                .HasColumnName("HUKUMLU");
            entity.Property(e => e.Ilce)
                .HasMaxLength(15)
                .HasColumnName("ILCE");
            entity.Property(e => e.Ilcesi)
                .HasMaxLength(15)
                .HasColumnName("ILCESI");
            entity.Property(e => e.Ili)
                .HasMaxLength(15)
                .HasColumnName("ILI");
            entity.Property(e => e.Istel)
                .HasMaxLength(15)
                .HasColumnName("ISTEL");
            entity.Property(e => e.Kangrubu)
                .HasMaxLength(10)
                .HasColumnName("KANGRUBU");
            entity.Property(e => e.Kilo)
                .HasMaxLength(6)
                .HasColumnName("KILO");
            entity.Property(e => e.Kutukno)
                .HasMaxLength(15)
                .HasColumnName("KUTUKNO");
            entity.Property(e => e.Mahkoy)
                .HasMaxLength(20)
                .HasColumnName("MAHKOY");
            entity.Property(e => e.Medenihali)
                .HasMaxLength(6)
                .HasColumnName("MEDENIHALI");
            entity.Property(e => e.Meslegi)
                .HasMaxLength(25)
                .HasColumnName("MESLEGI");
            entity.Property(e => e.Meslegi2)
                .HasMaxLength(25)
                .HasColumnName("MESLEGI2");
            entity.Property(e => e.Mezuntarihi)
                .HasMaxLength(10)
                .HasColumnName("MEZUNTARIHI");
            entity.Property(e => e.Nakilfirma)
                .HasMaxLength(25)
                .HasColumnName("NAKILFIRMA");
            entity.Property(e => e.Nufusdairesi)
                .HasMaxLength(20)
                .HasColumnName("NUFUSDAIRESI");
            entity.Property(e => e.Ozelilgileri)
                .HasMaxLength(250)
                .HasColumnName("OZELILGILERI");
            entity.Property(e => e.Pk)
                .HasMaxLength(8)
                .HasColumnName("PK");
            entity.Property(e => e.Ref1)
                .HasMaxLength(20)
                .HasColumnName("REF1");
            entity.Property(e => e.Ref2)
                .HasMaxLength(20)
                .HasColumnName("REF2");
            entity.Property(e => e.Ref3)
                .HasMaxLength(20)
                .HasColumnName("REF3");
            entity.Property(e => e.Ref4)
                .HasMaxLength(20)
                .HasColumnName("REF4");
            entity.Property(e => e.Sakatlikderecesi)
                .HasMaxLength(20)
                .HasColumnName("SAKATLIKDERECESI");
            entity.Property(e => e.Sayfano)
                .HasMaxLength(15)
                .HasColumnName("SAYFANO");
            entity.Property(e => e.Sehir)
                .HasMaxLength(20)
                .HasColumnName("SEHIR");
            entity.Property(e => e.Sehityakini)
                .HasMaxLength(6)
                .HasColumnName("SEHITYAKINI");
            entity.Property(e => e.Semt)
                .HasMaxLength(15)
                .HasColumnName("SEMT");
            entity.Property(e => e.Sendika)
                .HasMaxLength(10)
                .HasColumnName("SENDIKA");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Sigara)
                .HasMaxLength(10)
                .HasColumnName("SIGARA");
            entity.Property(e => e.Sigaratarihi)
                .HasMaxLength(10)
                .HasColumnName("SIGARATARIHI");
            entity.Property(e => e.Sosguvno)
                .HasMaxLength(20)
                .HasColumnName("SOSGUVNO");
            entity.Property(e => e.Sskno)
                .HasMaxLength(20)
                .HasColumnName("SSKNO");
            entity.Property(e => e.Tahsil)
                .HasMaxLength(20)
                .HasColumnName("TAHSIL");
            entity.Property(e => e.Tckimlikno)
                .HasMaxLength(20)
                .HasColumnName("TCKIMLIKNO");
            entity.Property(e => e.Uyrugu)
                .HasMaxLength(15)
                .HasColumnName("UYRUGU");
            entity.Property(e => e.Vergigrubu)
                .HasMaxLength(20)
                .HasColumnName("VERGIGRUBU");
            entity.Property(e => e.Vergikarneno)
                .HasMaxLength(20)
                .HasColumnName("VERGIKARNENO");
            entity.Property(e => e.Vergikarnetarihi)
                .HasMaxLength(10)
                .HasColumnName("VERGIKARNETARIHI");
        });

        modelBuilder.Entity<Ozlukaile>(entity =>
        {
            entity.HasKey(e => e.OaId).IsClustered(false);

            entity.ToTable("OZLUKAILE");

            entity.HasIndex(e => e.Sicilno, "OZLUKAILE_SICILNO");

            entity.Property(e => e.OaId).HasColumnName("OA_ID");
            entity.Property(e => e.Adisoyadi)
                .HasMaxLength(20)
                .HasColumnName("ADISOYADI");
            entity.Property(e => e.Calisiyor)
                .HasMaxLength(6)
                .HasColumnName("CALISIYOR");
            entity.Property(e => e.Emekli)
                .HasMaxLength(6)
                .HasColumnName("EMEKLI");
            entity.Property(e => e.Hayatta)
                .HasMaxLength(6)
                .HasColumnName("HAYATTA");
            entity.Property(e => e.Kisi)
                .HasMaxLength(10)
                .HasColumnName("KISI");
            entity.Property(e => e.Kisisicilno)
                .HasMaxLength(30)
                .HasColumnName("KISISICILNO");
            entity.Property(e => e.Meslegi)
                .HasMaxLength(30)
                .HasColumnName("MESLEGI");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Tahsili)
                .HasMaxLength(15)
                .HasColumnName("TAHSILI");
        });

        modelBuilder.Entity<Ozlukcocuk>(entity =>
        {
            entity.HasKey(e => e.OcId).IsClustered(false);

            entity.ToTable("OZLUKCOCUK");

            entity.HasIndex(e => e.Sicilno, "OZLUKCOCUK_SICILNO");

            entity.Property(e => e.OcId).HasColumnName("OC_ID");
            entity.Property(e => e.Adisoyadi)
                .HasMaxLength(20)
                .HasColumnName("ADISOYADI");
            entity.Property(e => e.Dogumtarihi)
                .HasMaxLength(10)
                .HasColumnName("DOGUMTARIHI");
            entity.Property(e => e.Meslegi)
                .HasMaxLength(30)
                .HasColumnName("MESLEGI");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Tahsili)
                .HasMaxLength(20)
                .HasColumnName("TAHSILI");
        });

        modelBuilder.Entity<Ozlukisyeri>(entity =>
        {
            entity.HasKey(e => e.OiId).IsClustered(false);

            entity.ToTable("OZLUKISYERI");

            entity.HasIndex(e => e.Sicilno, "OZLUKISYERI_SICILNO");

            entity.Property(e => e.OiId).HasColumnName("OI_ID");
            entity.Property(e => e.Ayrilmasebebi)
                .HasMaxLength(40)
                .HasColumnName("AYRILMASEBEBI");
            entity.Property(e => e.Ciktar)
                .HasMaxLength(10)
                .HasColumnName("CIKTAR");
            entity.Property(e => e.Firmaadi)
                .HasMaxLength(40)
                .HasColumnName("FIRMAADI");
            entity.Property(e => e.Girtar)
                .HasMaxLength(10)
                .HasColumnName("GIRTAR");
            entity.Property(e => e.Gorevi)
                .HasMaxLength(30)
                .HasColumnName("GOREVI");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
        });

        modelBuilder.Entity<Periyod>(entity =>
        {
            entity.HasKey(e => e.PId).IsClustered(false);

            entity.ToTable("PERIYOD");

            entity.Property(e => e.PId).HasColumnName("P_ID");
            entity.Property(e => e.Dateend)
                .HasMaxLength(10)
                .HasColumnName("DATEEND");
            entity.Property(e => e.Datestart)
                .HasMaxLength(10)
                .HasColumnName("DATESTART");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
        });

        modelBuilder.Entity<PeriyodGunlugu>(entity =>
        {
            entity.HasKey(e => e.PgId).IsClustered(false);

            entity.ToTable("PERIYOD_GUNLUGU");

            entity.Property(e => e.PgId).HasColumnName("PG_ID");
            entity.Property(e => e.Gun)
                .HasDefaultValue((short)0)
                .HasColumnName("GUN");
            entity.Property(e => e.Gunlukid)
                .HasDefaultValue((short)0)
                .HasColumnName("GUNLUKID");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
            entity.Property(e => e.Subkod)
                .HasMaxLength(10)
                .HasColumnName("SUBKOD");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
        });

        modelBuilder.Entity<Personelcikisneden>(entity =>
        {
            entity.HasKey(e => e.PcnId).IsClustered(false);

            entity.ToTable("PERSONELCIKISNEDEN");

            entity.Property(e => e.PcnId).HasColumnName("PCN_ID");
            entity.Property(e => e.Cikisdurumu)
                .HasMaxLength(50)
                .HasColumnName("CIKISDURUMU");
            entity.Property(e => e.Cikisnedeni)
                .HasDefaultValue(0)
                .HasColumnName("CIKISNEDENI");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
        });

        modelBuilder.Entity<Personeldisiplin>(entity =>
        {
            entity.HasKey(e => e.PdId).IsClustered(false);

            entity.ToTable("PERSONELDISIPLIN");

            entity.Property(e => e.PdId).HasColumnName("PD_ID");
            entity.Property(e => e.Karar)
                .HasMaxLength(150)
                .HasColumnName("KARAR");
            entity.Property(e => e.Neden)
                .HasMaxLength(50)
                .HasColumnName("NEDEN");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Tarih)
                .HasMaxLength(10)
                .HasColumnName("TARIH");
            entity.Property(e => e.Veren)
                .HasMaxLength(30)
                .HasColumnName("VEREN");
        });

        modelBuilder.Entity<Personelegitim>(entity =>
        {
            entity.HasKey(e => e.PeId).IsClustered(false);

            entity.ToTable("PERSONELEGITIM");

            entity.Property(e => e.PeId).HasColumnName("PE_ID");
            entity.Property(e => e.Konu)
                .HasMaxLength(100)
                .HasColumnName("KONU");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Sure)
                .HasMaxLength(100)
                .HasColumnName("SURE");
            entity.Property(e => e.Tarih)
                .HasMaxLength(10)
                .HasColumnName("TARIH");
            entity.Property(e => e.Veren)
                .HasMaxLength(100)
                .HasColumnName("VEREN");
        });

        modelBuilder.Entity<Personelkaza>(entity =>
        {
            entity.HasKey(e => e.PkId).IsClustered(false);

            entity.ToTable("PERSONELKAZA");

            entity.Property(e => e.PkId).HasColumnName("PK_ID");
            entity.Property(e => e.Islem)
                .HasMaxLength(150)
                .HasColumnName("ISLEM");
            entity.Property(e => e.Neden)
                .HasMaxLength(20)
                .HasColumnName("NEDEN");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Tarih)
                .HasMaxLength(10)
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Personelodul>(entity =>
        {
            entity.HasKey(e => e.PoId).IsClustered(false);

            entity.ToTable("PERSONELODUL");

            entity.Property(e => e.PoId).HasColumnName("PO_ID");
            entity.Property(e => e.Neden)
                .HasMaxLength(20)
                .HasColumnName("NEDEN");
            entity.Property(e => e.Odul)
                .HasMaxLength(150)
                .HasColumnName("ODUL");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Tarih)
                .HasMaxLength(10)
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Pgreport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PGREPORT");

            entity.Property(e => e.Baslangic).HasColumnName("BASLANGIC");
            entity.Property(e => e.Bitis).HasColumnName("BITIS");
            entity.Property(e => e.Dagilimid).HasColumnName("DAGILIMID");
            entity.Property(e => e.Fmptipi)
                .HasMaxLength(3)
                .HasColumnName("FMPTIPI");
            entity.Property(e => e.Grup).HasColumnName("GRUP");
            entity.Property(e => e.Gunluk1)
                .HasMaxLength(10)
                .HasColumnName("GUNLUK1");
            entity.Property(e => e.Gunluk2)
                .HasMaxLength(10)
                .HasColumnName("GUNLUK2");
            entity.Property(e => e.Gunluk3)
                .HasMaxLength(10)
                .HasColumnName("GUNLUK3");
            entity.Property(e => e.Haksure1).HasColumnName("HAKSURE1");
            entity.Property(e => e.Haksure2).HasColumnName("HAKSURE2");
            entity.Property(e => e.Haktanim1)
                .HasMaxLength(30)
                .HasColumnName("HAKTANIM1");
            entity.Property(e => e.Haktanim2)
                .HasMaxLength(30)
                .HasColumnName("HAKTANIM2");
            entity.Property(e => e.Haktip1)
                .HasMaxLength(10)
                .HasColumnName("HAKTIP1");
            entity.Property(e => e.Haktip2)
                .HasMaxLength(10)
                .HasColumnName("HAKTIP2");
            entity.Property(e => e.Mesaierkencikis).HasColumnName("MESAIERKENCIKIS");
            entity.Property(e => e.Mesaierkengiris).HasColumnName("MESAIERKENGIRIS");
            entity.Property(e => e.Mesaigeccikis).HasColumnName("MESAIGECCIKIS");
            entity.Property(e => e.Mesaigecgiris).HasColumnName("MESAIGECGIRIS");
            entity.Property(e => e.Mesainormalcikis).HasColumnName("MESAINORMALCIKIS");
            entity.Property(e => e.Mesainormalgiris).HasColumnName("MESAINORMALGIRIS");
            entity.Property(e => e.Model).HasColumnName("MODEL");
            entity.Property(e => e.Normalsure).HasColumnName("NORMALSURE");
            entity.Property(e => e.PuantajgunluguDagilimKod)
                .HasMaxLength(10)
                .HasColumnName("PUANTAJGUNLUGU_DAGILIM.KOD");
            entity.Property(e => e.PuantajgunluguKod)
                .HasMaxLength(10)
                .HasColumnName("PUANTAJGUNLUGU.KOD");
            entity.Property(e => e.Subkod)
                .HasMaxLength(10)
                .HasColumnName("SUBKOD");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(30)
                .HasColumnName("TANIMI");
            entity.Property(e => e.Yemekdagilimi).HasColumnName("YEMEKDAGILIMI");
            entity.Property(e => e.Yemeksure).HasColumnName("YEMEKSURE");
        });

        modelBuilder.Entity<Puantajgunlugu>(entity =>
        {
            entity.HasKey(e => e.PgId).IsClustered(false);

            entity.ToTable("PUANTAJGUNLUGU");

            entity.HasIndex(e => e.Haktip1, "PUANTAJGUNLUGU_HAKTIP1");

            entity.Property(e => e.PgId).HasColumnName("PG_ID");
            entity.Property(e => e.Fmptipi)
                .HasMaxLength(3)
                .HasColumnName("FMPTIPI");
            entity.Property(e => e.Grup)
                .HasDefaultValue((short)0)
                .HasColumnName("GRUP");
            entity.Property(e => e.Gunluk1)
                .HasMaxLength(10)
                .HasColumnName("GUNLUK1");
            entity.Property(e => e.Gunluk2)
                .HasMaxLength(10)
                .HasColumnName("GUNLUK2");
            entity.Property(e => e.Gunluk3)
                .HasMaxLength(10)
                .HasColumnName("GUNLUK3");
            entity.Property(e => e.Haksure1)
                .HasDefaultValue((short)0)
                .HasColumnName("HAKSURE1");
            entity.Property(e => e.Haksure2)
                .HasDefaultValue((short)0)
                .HasColumnName("HAKSURE2");
            entity.Property(e => e.Haktanim1)
                .HasMaxLength(30)
                .HasColumnName("HAKTANIM1");
            entity.Property(e => e.Haktanim2)
                .HasMaxLength(30)
                .HasColumnName("HAKTANIM2");
            entity.Property(e => e.Haktip1)
                .HasMaxLength(10)
                .HasColumnName("HAKTIP1");
            entity.Property(e => e.Haktip2)
                .HasMaxLength(10)
                .HasColumnName("HAKTIP2");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
            entity.Property(e => e.Mesaierkencikis)
                .HasDefaultValue((short)0)
                .HasColumnName("MESAIERKENCIKIS");
            entity.Property(e => e.Mesaierkengiris)
                .HasDefaultValue((short)0)
                .HasColumnName("MESAIERKENGIRIS");
            entity.Property(e => e.Mesaigeccikis)
                .HasDefaultValue((short)0)
                .HasColumnName("MESAIGECCIKIS");
            entity.Property(e => e.Mesaigecgiris)
                .HasDefaultValue((short)0)
                .HasColumnName("MESAIGECGIRIS");
            entity.Property(e => e.Mesainormalcikis)
                .HasDefaultValue((short)0)
                .HasColumnName("MESAINORMALCIKIS");
            entity.Property(e => e.Mesainormalgiris)
                .HasDefaultValue((short)0)
                .HasColumnName("MESAINORMALGIRIS");
            entity.Property(e => e.Model)
                .HasDefaultValue((short)0)
                .HasColumnName("MODEL");
            entity.Property(e => e.Normalsure)
                .HasDefaultValue((short)0)
                .HasColumnName("NORMALSURE");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
            entity.Property(e => e.Yemekdagilimi)
                .HasDefaultValue((short)0)
                .HasColumnName("YEMEKDAGILIMI");
            entity.Property(e => e.Yemeksure)
                .HasDefaultValue((short)0)
                .HasColumnName("YEMEKSURE");
        });

        modelBuilder.Entity<PuantajgunluguDagilim>(entity =>
        {
            entity.HasKey(e => e.PgdId).IsClustered(false);

            entity.ToTable("PUANTAJGUNLUGU_DAGILIM");

            entity.HasIndex(e => e.Kod, "PUANTAJGUNLUGU_DAGILIM_KOD");

            entity.Property(e => e.PgdId).HasColumnName("PGD_ID");
            entity.Property(e => e.Baslangic)
                .HasDefaultValue((short)0)
                .HasColumnName("BASLANGIC");
            entity.Property(e => e.Bitis)
                .HasDefaultValue((short)0)
                .HasColumnName("BITIS");
            entity.Property(e => e.Dagilimid)
                .HasDefaultValue((short)0)
                .HasColumnName("DAGILIMID");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
            entity.Property(e => e.Subkod)
                .HasMaxLength(10)
                .HasColumnName("SUBKOD");
            entity.Property(e => e.Tanimi)
                .HasMaxLength(30)
                .HasColumnName("TANIMI");
        });

        modelBuilder.Entity<Puantajtipleri>(entity =>
        {
            entity.HasKey(e => e.PtId).IsClustered(false);

            entity.ToTable("PUANTAJTIPLERI");

            entity.HasIndex(e => e.Formati, "PUANTAJTIPLERI_FORMATI");

            entity.Property(e => e.PtId).HasColumnName("PT_ID");
            entity.Property(e => e.Altlimit)
                .HasDefaultValue((short)0)
                .HasColumnName("ALTLIMIT");
            entity.Property(e => e.Aylikpuantaj)
                .HasMaxLength(10)
                .HasColumnName("AYLIKPUANTAJ");
            entity.Property(e => e.Carpan)
                .HasDefaultValue((short)0)
                .HasColumnName("CARPAN");
            entity.Property(e => e.Deger1)
                .HasDefaultValue((short)0)
                .HasColumnName("DEGER1");
            entity.Property(e => e.Deger2)
                .HasDefaultValue((short)0)
                .HasColumnName("DEGER2");
            entity.Property(e => e.Deger3)
                .HasDefaultValue((short)0)
                .HasColumnName("DEGER3");
            entity.Property(e => e.Eksikpuantaj)
                .HasMaxLength(10)
                .HasColumnName("EKSIKPUANTAJ");
            entity.Property(e => e.Esitpuantaj)
                .HasMaxLength(10)
                .HasColumnName("ESITPUANTAJ");
            entity.Property(e => e.Fazlapuantaj)
                .HasMaxLength(10)
                .HasColumnName("FAZLAPUANTAJ");
            entity.Property(e => e.Formati)
                .HasDefaultValue((short)0)
                .HasColumnName("FORMATI");
            entity.Property(e => e.Gunlukpuantaj)
                .HasMaxLength(10)
                .HasColumnName("GUNLUKPUANTAJ");
            entity.Property(e => e.Ilk1)
                .HasDefaultValue((short)0)
                .HasColumnName("ILK1");
            entity.Property(e => e.Ilk2)
                .HasDefaultValue((short)0)
                .HasColumnName("ILK2");
            entity.Property(e => e.Ilk3)
                .HasDefaultValue((short)0)
                .HasColumnName("ILK3");
            entity.Property(e => e.Isareti)
                .HasMaxLength(5)
                .HasColumnName("ISARETI");
            entity.Property(e => e.Kisatanim)
                .HasMaxLength(10)
                .HasColumnName("KISATANIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
            entity.Property(e => e.Onay)
                .HasDefaultValue((short)0)
                .HasColumnName("ONAY");
            entity.Property(e => e.Onceliksirasi)
                .HasDefaultValue((short)0)
                .HasColumnName("ONCELIKSIRASI");
            entity.Property(e => e.Son1)
                .HasDefaultValue((short)0)
                .HasColumnName("SON1");
            entity.Property(e => e.Son2)
                .HasDefaultValue((short)0)
                .HasColumnName("SON2");
            entity.Property(e => e.Son3)
                .HasDefaultValue((short)0)
                .HasColumnName("SON3");
            entity.Property(e => e.Sure)
                .HasDefaultValue((short)0)
                .HasColumnName("SURE");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
            entity.Property(e => e.Ustlimit)
                .HasDefaultValue((short)0)
                .HasColumnName("USTLIMIT");
        });

        modelBuilder.Entity<Segmentfmplan>(entity =>
        {
            entity.HasKey(e => e.FPkId).IsClustered(false);

            entity.ToTable("SEGMENTFMPLAN");

            entity.Property(e => e.FPkId).HasColumnName("F_PK_ID");
            entity.Property(e => e.FFmneden)
                .HasMaxLength(3)
                .HasColumnName("F_FMNEDEN");
            entity.Property(e => e.FNot)
                .HasMaxLength(150)
                .HasColumnName("F_NOT");
            entity.Property(e => e.FOnay)
                .HasDefaultValue(0)
                .HasColumnName("F_ONAY");
            entity.Property(e => e.FOnaylayan)
                .HasDefaultValue(0)
                .HasColumnName("F_ONAYLAYAN");
            entity.Property(e => e.FOnaysaat)
                .HasDefaultValue(0)
                .HasColumnName("F_ONAYSAAT");
            entity.Property(e => e.FOnaytarih)
                .HasMaxLength(8)
                .HasColumnName("F_ONAYTARIH");
            entity.Property(e => e.FPlanchsaat)
                .HasDefaultValue((short)0)
                .HasColumnName("F_PLANCHSAAT");
            entity.Property(e => e.FPlanchtarih)
                .HasMaxLength(8)
                .HasColumnName("F_PLANCHTARIH");
            entity.Property(e => e.FPlanlayan)
                .HasDefaultValue(0)
                .HasColumnName("F_PLANLAYAN");
            entity.Property(e => e.FPlansaat)
                .HasDefaultValue((short)0)
                .HasColumnName("F_PLANSAAT");
            entity.Property(e => e.FPlantarih)
                .HasMaxLength(8)
                .HasColumnName("F_PLANTARIH");
            entity.Property(e => e.FServis)
                .HasMaxLength(3)
                .HasColumnName("F_SERVIS");
            entity.Property(e => e.FSicilno)
                .HasMaxLength(30)
                .HasColumnName("F_SICILNO");
            entity.Property(e => e.FSure)
                .HasDefaultValue(0)
                .HasColumnName("F_SURE");
            entity.Property(e => e.FTarih)
                .HasMaxLength(8)
                .HasColumnName("F_TARIH");
            entity.Property(e => e.FType)
                .HasDefaultValue((short)0)
                .HasColumnName("F_TYPE");
        });

        modelBuilder.Entity<Segmentper>(entity =>
        {
            entity.HasKey(e => e.FPkId).IsClustered(false);

            entity.ToTable("SEGMENTPERS");

            entity.HasIndex(e => new { e.FBolum, e.FDepartman }, "SEGMENTPERS_BOLDEP");

            entity.HasIndex(e => new { e.FSicilno, e.FBaslangic, e.FBitis }, "SEGMENTPERS_SCBASBIT");

            entity.Property(e => e.FPkId).HasColumnName("F_PK_ID");
            entity.Property(e => e.FBasSaat)
                .HasDefaultValue(0)
                .HasColumnName("F_BAS_SAAT");
            entity.Property(e => e.FBaslangic)
                .HasMaxLength(10)
                .HasColumnName("F_BASLANGIC");
            entity.Property(e => e.FBitSaat)
                .HasDefaultValue(0)
                .HasColumnName("F_BIT_SAAT");
            entity.Property(e => e.FBitis)
                .HasMaxLength(10)
                .HasColumnName("F_BITIS");
            entity.Property(e => e.FBolum)
                .HasMaxLength(3)
                .HasColumnName("F_BOLUM");
            entity.Property(e => e.FDepartman)
                .HasMaxLength(3)
                .HasColumnName("F_DEPARTMAN");
            entity.Property(e => e.FGonderen)
                .HasDefaultValue(0)
                .HasColumnName("F_GONDEREN");
            entity.Property(e => e.FOnaylayan)
                .HasDefaultValue(0)
                .HasColumnName("F_ONAYLAYAN");
            entity.Property(e => e.FOnaysaat)
                .HasDefaultValue(0)
                .HasColumnName("F_ONAYSAAT");
            entity.Property(e => e.FOnaytarih)
                .HasMaxLength(8)
                .HasColumnName("F_ONAYTARIH");
            entity.Property(e => e.FSicilno)
                .HasMaxLength(30)
                .HasColumnName("F_SICILNO");
            entity.Property(e => e.FStatu)
                .HasDefaultValue(0)
                .HasColumnName("F_STATU");
            entity.Property(e => e.FType)
                .HasDefaultValue((short)0)
                .HasColumnName("F_TYPE");
        });

        modelBuilder.Entity<SelectedSicil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SELECTED_SICIL");

            entity.HasIndex(e => e.SessionId, "SELECTED_SICIL_SESSION_ID");

            entity.Property(e => e.SessionId)
                .HasDefaultValue((short)0)
                .HasColumnName("SESSION_ID");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(20)
                .HasColumnName("SICILNO");
        });

        modelBuilder.Entity<Servisler>(entity =>
        {
            entity.HasKey(e => e.SId).IsClustered(false);

            entity.ToTable("SERVISLER");

            entity.Property(e => e.SId).HasColumnName("S_ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(25)
                .HasColumnName("ADI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(10)
                .HasColumnName("KODU");
        });

        modelBuilder.Entity<Sicil>(entity =>
        {
            entity.HasKey(e => e.SId).IsClustered(false);

            entity.ToTable("SICIL");

            entity.HasIndex(e => e.Adisoyadi, "SICIL_ADISOYADI");

            entity.HasIndex(e => e.Cikistarihi, "SICIL_CIKISTARIHI");

            entity.HasIndex(e => e.Kartno, "SICIL_KARTNO");

            entity.HasIndex(e => e.Sicilno, "SICIL_SICILNO");

            entity.HasIndex(e => new { e.Sicilno, e.Kartno }, "SICIL_SK");

            entity.Property(e => e.SId).HasColumnName("S_ID");
            entity.Property(e => e.Adisoyadi)
                .HasMaxLength(30)
                .HasColumnName("ADISOYADI");
            entity.Property(e => e.AracMarka)
                .HasMaxLength(15)
                .HasColumnName("ARAC_MARKA");
            entity.Property(e => e.AracModel)
                .HasMaxLength(15)
                .HasColumnName("ARAC_MODEL");
            entity.Property(e => e.AracPlaka)
                .HasMaxLength(20)
                .HasColumnName("ARAC_PLAKA");
            entity.Property(e => e.AracRenk)
                .HasMaxLength(15)
                .HasColumnName("ARAC_RENK");
            entity.Property(e => e.AracTag)
                .HasMaxLength(50)
                .HasColumnName("ARAC_TAG");
            entity.Property(e => e.Binano)
                .HasMaxLength(20)
                .HasColumnName("BINANO");
            entity.Property(e => e.Bolumadi)
                .HasMaxLength(255)
                .HasColumnName("BOLUMADI");
            entity.Property(e => e.Bolumkodu)
                .HasMaxLength(3)
                .HasColumnName("BOLUMKODU");
            entity.Property(e => e.Cikistarihi)
                .HasMaxLength(10)
                .HasColumnName("CIKISTARIHI");
            entity.Property(e => e.Computername)
                .HasMaxLength(30)
                .HasColumnName("COMPUTERNAME");
            entity.Property(e => e.Computertcpip)
                .HasMaxLength(16)
                .HasColumnName("COMPUTERTCPIP");
            entity.Property(e => e.Computerworkgroup)
                .HasMaxLength(30)
                .HasColumnName("COMPUTERWORKGROUP");
            entity.Property(e => e.Dahilitel)
                .HasMaxLength(15)
                .HasColumnName("DAHILITEL");
            entity.Property(e => e.Departmanadi)
                .HasMaxLength(30)
                .HasColumnName("DEPARTMANADI");
            entity.Property(e => e.Departmankodu)
                .HasMaxLength(3)
                .HasColumnName("DEPARTMANKODU");
            entity.Property(e => e.Esnekcalisma)
                .HasDefaultValue((short)0)
                .HasColumnName("ESNEKCALISMA");
            entity.Property(e => e.Fazlamesai)
                .HasDefaultValue((short)0)
                .HasColumnName("FAZLAMESAI");
            entity.Property(e => e.Fiyat1)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("FIYAT1");
            entity.Property(e => e.Fiyat2)
                .HasDefaultValue(0m)
                .HasColumnType("money")
                .HasColumnName("FIYAT2");
            entity.Property(e => e.Giristarihi)
                .HasMaxLength(10)
                .HasColumnName("GIRISTARIHI");
            entity.Property(e => e.Grupkodu)
                .HasMaxLength(10)
                .HasColumnName("GRUPKODU");
            entity.Property(e => e.Hesapmodeli)
                .HasDefaultValue((short)0)
                .HasColumnName("HESAPMODELI");
            entity.Property(e => e.Hpkkod)
                .HasMaxLength(3)
                .HasColumnName("HPKKOD");
            entity.Property(e => e.Hpktanim)
                .HasMaxLength(30)
                .HasColumnName("HPKTANIM");
            entity.Property(e => e.Hps)
                .HasMaxLength(5)
                .HasColumnName("HPS");
            entity.Property(e => e.Izindevirgunu)
                .HasDefaultValue(0)
                .HasColumnName("IZINDEVIRGUNU");
            entity.Property(e => e.Izindeviryili)
                .HasMaxLength(4)
                .HasColumnName("IZINDEVIRYILI");
            entity.Property(e => e.Izinkidemi)
                .HasDefaultValue((short)0)
                .HasColumnName("IZINKIDEMI");
            entity.Property(e => e.Kartno)
                .HasMaxLength(20)
                .HasColumnName("KARTNO");
            entity.Property(e => e.Kartno2)
                .HasMaxLength(30)
                .HasColumnName("KARTNO2");
            entity.Property(e => e.Kartserino)
                .HasMaxLength(20)
                .HasColumnName("KARTSERINO");
            entity.Property(e => e.Katno)
                .HasMaxLength(10)
                .HasColumnName("KATNO");
            entity.Property(e => e.Legickartno)
                .HasMaxLength(50)
                .HasColumnName("LEGICKARTNO");
            entity.Property(e => e.Mesaiadi)
                .HasMaxLength(30)
                .HasColumnName("MESAIADI");
            entity.Property(e => e.Mesaikodu)
                .HasMaxLength(3)
                .HasColumnName("MESAIKODU");
            entity.Property(e => e.Ncsup)
                .HasDefaultValue((short)0)
                .HasColumnName("NCSUP");
            entity.Property(e => e.Odano)
                .HasMaxLength(10)
                .HasColumnName("ODANO");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(10)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.Servisadi)
                .HasMaxLength(30)
                .HasColumnName("SERVISADI");
            entity.Property(e => e.Serviskodu)
                .HasMaxLength(3)
                .HasColumnName("SERVISKODU");
            entity.Property(e => e.Serviskoltukno)
                .HasMaxLength(10)
                .HasColumnName("SERVISKOLTUKNO");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(20)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Sifre)
                .HasMaxLength(255)
                .HasColumnName("SIFRE");
            entity.Property(e => e.Ucrettipi)
                .HasDefaultValue((short)0)
                .HasColumnName("UCRETTIPI");
            entity.Property(e => e.Unvan)
                .HasMaxLength(50)
                .HasColumnName("UNVAN");
            entity.Property(e => e.Xsira)
                .HasDefaultValue(0)
                .HasColumnName("XSIRA");
            entity.Property(e => e.Yemekparam)
                .HasMaxLength(3)
                .HasColumnName("YEMEKPARAM");
            entity.Property(e => e.Yemekparamtanim)
                .HasMaxLength(30)
                .HasColumnName("YEMEKPARAMTANIM");
            entity.Property(e => e.Yillikizin)
                .HasDefaultValue((short)0)
                .HasColumnName("YILLIKIZIN");
            entity.Property(e => e.Yizinhakedistar)
                .HasMaxLength(10)
                .HasColumnName("YIZINHAKEDISTAR");
        });

        modelBuilder.Entity<SicilResim>(entity =>
        {
            entity.HasKey(e => e.SrId).IsClustered(false);

            entity.ToTable("SICIL_RESIM");

            entity.HasIndex(e => e.Sicilno, "SICIL_RESIM_SICILNO");

            entity.Property(e => e.SrId).HasColumnName("SR_ID");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("RESIM");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
        });

        modelBuilder.Entity<Sirketbilgileri>(entity =>
        {
            entity.HasKey(e => e.SbId).IsClustered(false);

            entity.ToTable("SIRKETBILGILERI");

            entity.Property(e => e.SbId).HasColumnName("SB_ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(50)
                .HasColumnName("ADRES");
            entity.Property(e => e.Arakarakter)
                .HasMaxLength(2)
                .HasColumnName("ARAKARAKTER");
            entity.Property(e => e.Aydonumgunu)
                .HasDefaultValue((short)0)
                .HasColumnName("AYDONUMGUNU");
            entity.Property(e => e.Aysuresi)
                .HasMaxLength(8)
                .HasColumnName("AYSURESI");
            entity.Property(e => e.Bilgitoplama)
                .HasDefaultValue((short)0)
                .HasColumnName("BILGITOPLAMA");
            entity.Property(e => e.DefFm100)
                .HasMaxLength(5)
                .HasColumnName("DEF_FM_100");
            entity.Property(e => e.DefFm125)
                .HasMaxLength(5)
                .HasColumnName("DEF_FM_125");
            entity.Property(e => e.DefFm200)
                .HasMaxLength(5)
                .HasColumnName("DEF_FM_200");
            entity.Property(e => e.DefFm225)
                .HasMaxLength(5)
                .HasColumnName("DEF_FM_225");
            entity.Property(e => e.DefFmGecebaslangic)
                .HasDefaultValue((short)0)
                .HasColumnName("DEF_FM_GECEBASLANGIC");
            entity.Property(e => e.DefFmGecebitis)
                .HasDefaultValue((short)0)
                .HasColumnName("DEF_FM_GECEBITIS");
            entity.Property(e => e.DefFmGrMt)
                .HasMaxLength(200)
                .HasColumnName("DEF_FM_GR_MT");
            entity.Property(e => e.DefFmNcMt)
                .HasMaxLength(200)
                .HasColumnName("DEF_FM_NC_MT");
            entity.Property(e => e.DefFmPlanlama)
                .HasDefaultValue((short)0)
                .HasColumnName("DEF_FM_PLANLAMA");
            entity.Property(e => e.DefFmSaatsiniri)
                .HasDefaultValue((short)0)
                .HasColumnName("DEF_FM_SAATSINIRI");
            entity.Property(e => e.DefFmTakip)
                .HasDefaultValue((short)0)
                .HasColumnName("DEF_FM_TAKIP");
            entity.Property(e => e.DefFmTolerans)
                .HasDefaultValue((short)0)
                .HasColumnName("DEF_FM_TOLERANS");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Esnekcalisma)
                .HasDefaultValue((short)0)
                .HasColumnName("ESNEKCALISMA");
            entity.Property(e => e.Fax1)
                .HasMaxLength(20)
                .HasColumnName("FAX1");
            entity.Property(e => e.Fax2)
                .HasMaxLength(20)
                .HasColumnName("FAX2");
            entity.Property(e => e.Gunsuresi)
                .HasMaxLength(8)
                .HasColumnName("GUNSURESI");
            entity.Property(e => e.KartBasmayanlar)
                .HasMaxLength(100)
                .HasColumnName("KART_BASMAYANLAR");
            entity.Property(e => e.Kisaunvani)
                .HasMaxLength(30)
                .HasColumnName("KISAUNVANI");
            entity.Property(e => e.Kodu)
                .HasMaxLength(4)
                .HasColumnName("KODU");
            entity.Property(e => e.Model)
                .HasDefaultValue((short)0)
                .HasColumnName("MODEL");
            entity.Property(e => e.Opt1)
                .HasDefaultValue((short)0)
                .HasColumnName("OPT1");
            entity.Property(e => e.Pgunlukleri0)
                .HasMaxLength(3)
                .HasColumnName("PGUNLUKLERI0");
            entity.Property(e => e.Pgunlukleri1)
                .HasMaxLength(3)
                .HasColumnName("PGUNLUKLERI1");
            entity.Property(e => e.Pgunlukleri2)
                .HasMaxLength(3)
                .HasColumnName("PGUNLUKLERI2");
            entity.Property(e => e.Pgunlukleri3)
                .HasMaxLength(3)
                .HasColumnName("PGUNLUKLERI3");
            entity.Property(e => e.Pgunlukleri4)
                .HasMaxLength(3)
                .HasColumnName("PGUNLUKLERI4");
            entity.Property(e => e.Pgunlukleri5)
                .HasMaxLength(3)
                .HasColumnName("PGUNLUKLERI5");
            entity.Property(e => e.Pgunlukleri6)
                .HasMaxLength(3)
                .HasColumnName("PGUNLUKLERI6");
            entity.Property(e => e.Pk)
                .HasMaxLength(5)
                .HasColumnName("PK");
            entity.Property(e => e.Ptipi0)
                .HasMaxLength(3)
                .HasColumnName("PTIPI0");
            entity.Property(e => e.Ptipi1)
                .HasMaxLength(3)
                .HasColumnName("PTIPI1");
            entity.Property(e => e.Ptipi2)
                .HasMaxLength(3)
                .HasColumnName("PTIPI2");
            entity.Property(e => e.Ptipi3)
                .HasMaxLength(3)
                .HasColumnName("PTIPI3");
            entity.Property(e => e.Ptipi4)
                .HasMaxLength(3)
                .HasColumnName("PTIPI4");
            entity.Property(e => e.Puantajkolon0)
                .HasDefaultValue((short)0)
                .HasColumnName("PUANTAJKOLON0");
            entity.Property(e => e.Puantajkolon1)
                .HasDefaultValue((short)0)
                .HasColumnName("PUANTAJKOLON1");
            entity.Property(e => e.Sehir)
                .HasMaxLength(20)
                .HasColumnName("SEHIR");
            entity.Property(e => e.Semt)
                .HasMaxLength(20)
                .HasColumnName("SEMT");
            entity.Property(e => e.Sicilsistem)
                .HasDefaultValue((short)0)
                .HasColumnName("SICILSISTEM");
            entity.Property(e => e.Siciluzunlugu)
                .HasMaxLength(50)
                .HasColumnName("SICILUZUNLUGU");
            entity.Property(e => e.Sskdairesi)
                .HasMaxLength(20)
                .HasColumnName("SSKDAIRESI");
            entity.Property(e => e.Ssknumarasi)
                .HasMaxLength(20)
                .HasColumnName("SSKNUMARASI");
            entity.Property(e => e.Tel1)
                .HasMaxLength(20)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(20)
                .HasColumnName("TEL2");
            entity.Property(e => e.Toleranssuresi0)
                .HasDefaultValue((short)0)
                .HasColumnName("TOLERANSSURESI0");
            entity.Property(e => e.Toleranssuresi1)
                .HasDefaultValue((short)0)
                .HasColumnName("TOLERANSSURESI1");
            entity.Property(e => e.Unvan1)
                .HasMaxLength(50)
                .HasColumnName("UNVAN1");
            entity.Property(e => e.Unvan2)
                .HasMaxLength(50)
                .HasColumnName("UNVAN2");
            entity.Property(e => e.Vergidairesi)
                .HasMaxLength(20)
                .HasColumnName("VERGIDAIRESI");
            entity.Property(e => e.Verginumarasi)
                .HasMaxLength(20)
                .HasColumnName("VERGINUMARASI");
            entity.Property(e => e.Web)
                .HasMaxLength(40)
                .HasColumnName("WEB");
            entity.Property(e => e.Yemekkapi)
                .HasMaxLength(50)
                .HasColumnName("YEMEKKAPI");
            entity.Property(e => e.Yili)
                .HasMaxLength(4)
                .HasColumnName("YILI");
            entity.Property(e => e.ZiyaretciTerminaller)
                .HasMaxLength(255)
                .HasColumnName("ZIYARETCI_TERMINALLER");
            entity.Property(e => e.ZzKullan).HasColumnName("ZZ_KULLAN");
        });

        modelBuilder.Entity<TbKapatma>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_KAPATMA");

            entity.Property(e => e.FGercek)
                .HasMaxLength(100)
                .HasColumnName("F_GERCEK");
            entity.Property(e => e.FKapatma)
                .HasColumnType("ntext")
                .HasColumnName("F_KAPATMA");
            entity.Property(e => e.FPkId).HasColumnName("F_PK_ID");
        });

        modelBuilder.Entity<TbKapatmakolon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_KAPATMAKOLON");

            entity.Property(e => e.FApkolon).HasColumnName("F_APKOLON");
            entity.Property(e => e.FIsaret)
                .HasMaxLength(10)
                .HasColumnName("F_ISARET");
            entity.Property(e => e.FPkId).HasColumnName("F_PK_ID");
            entity.Property(e => e.FTmpApkolon).HasColumnName("F_TMP_APKOLON");
        });

        modelBuilder.Entity<TbSicilTerm>(entity =>
        {
            entity.HasKey(e => e.FId).IsClustered(false);

            entity.ToTable("TB_SICIL_TERM");

            entity.Property(e => e.FId).HasColumnName("F_ID");
            entity.Property(e => e.FI1)
                .HasDefaultValue(0)
                .HasColumnName("F_I1");
            entity.Property(e => e.FI2)
                .HasDefaultValue(0)
                .HasColumnName("F_I2");
            entity.Property(e => e.FSicilno)
                .HasMaxLength(15)
                .HasColumnName("F_SICILNO");
            entity.Property(e => e.FT1)
                .HasMaxLength(50)
                .HasColumnName("F_T1");
            entity.Property(e => e.FT2)
                .HasMaxLength(50)
                .HasColumnName("F_T2");
            entity.Property(e => e.FTerm)
                .HasMaxLength(5)
                .HasColumnName("F_TERM");
        });

        modelBuilder.Entity<TbStrTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TB_STR_TABLE");

            entity.Property(e => e.FKey)
                .HasMaxLength(100)
                .HasColumnName("F_KEY");
            entity.Property(e => e.FNumber).HasColumnName("F_NUMBER");
            entity.Property(e => e.FPkId).HasColumnName("F_PK_ID");
            entity.Property(e => e.FText)
                .HasColumnType("ntext")
                .HasColumnName("F_TEXT");
        });

        modelBuilder.Entity<TelafiCalismasi>(entity =>
        {
            entity.HasKey(e => e.TcId).IsClustered(false);

            entity.ToTable("TELAFI_CALISMASI");

            entity.Property(e => e.TcId).HasColumnName("TC_ID");
            entity.Property(e => e.Ay)
                .HasDefaultValue((short)0)
                .HasColumnName("AY");
            entity.Property(e => e.Balanscount)
                .HasDefaultValue((short)0)
                .HasColumnName("BALANSCOUNT");
            entity.Property(e => e.Devirfm1).HasColumnName("DEVIRFM1");
            entity.Property(e => e.Devirfm1kod)
                .HasMaxLength(3)
                .HasColumnName("DEVIRFM1KOD");
            entity.Property(e => e.Devirfm2).HasColumnName("DEVIRFM2");
            entity.Property(e => e.Devirfm2kod)
                .HasMaxLength(3)
                .HasColumnName("DEVIRFM2KOD");
            entity.Property(e => e.Devirfm3).HasColumnName("DEVIRFM3");
            entity.Property(e => e.Devirfm3kod)
                .HasMaxLength(3)
                .HasColumnName("DEVIRFM3KOD");
            entity.Property(e => e.Devirfm4).HasColumnName("DEVIRFM4");
            entity.Property(e => e.Devirfm4kod)
                .HasMaxLength(3)
                .HasColumnName("DEVIRFM4KOD");
            entity.Property(e => e.Devirfm5).HasColumnName("DEVIRFM5");
            entity.Property(e => e.Devirfm5kod)
                .HasMaxLength(3)
                .HasColumnName("DEVIRFM5KOD");
            entity.Property(e => e.Devirserbest).HasColumnName("DEVIRSERBEST");
            entity.Property(e => e.Devirtelafi).HasColumnName("DEVIRTELAFI");
            entity.Property(e => e.Devirtoplamfm).HasColumnName("DEVIRTOPLAMFM");
            entity.Property(e => e.Devredenfm1).HasColumnName("DEVREDENFM1");
            entity.Property(e => e.Devredenfm1kod)
                .HasMaxLength(3)
                .HasColumnName("DEVREDENFM1KOD");
            entity.Property(e => e.Devredenfm2).HasColumnName("DEVREDENFM2");
            entity.Property(e => e.Devredenfm2kod)
                .HasMaxLength(3)
                .HasColumnName("DEVREDENFM2KOD");
            entity.Property(e => e.Devredenfm3).HasColumnName("DEVREDENFM3");
            entity.Property(e => e.Devredenfm3kod)
                .HasMaxLength(3)
                .HasColumnName("DEVREDENFM3KOD");
            entity.Property(e => e.Devredenfm4).HasColumnName("DEVREDENFM4");
            entity.Property(e => e.Devredenfm4kod)
                .HasMaxLength(3)
                .HasColumnName("DEVREDENFM4KOD");
            entity.Property(e => e.Devredenfm5).HasColumnName("DEVREDENFM5");
            entity.Property(e => e.Devredenfm5kod)
                .HasMaxLength(3)
                .HasColumnName("DEVREDENFM5KOD");
            entity.Property(e => e.Devredenserbest).HasColumnName("DEVREDENSERBEST");
            entity.Property(e => e.Devredentelafi).HasColumnName("DEVREDENTELAFI");
            entity.Property(e => e.Devredentoplamfm).HasColumnName("DEVREDENTOPLAMFM");
            entity.Property(e => e.FNumber1)
                .HasDefaultValue(0L)
                .HasColumnName("F_NUMBER1");
            entity.Property(e => e.FNumber2)
                .HasDefaultValue(0L)
                .HasColumnName("F_NUMBER2");
            entity.Property(e => e.FNumber3)
                .HasDefaultValue(0L)
                .HasColumnName("F_NUMBER3");
            entity.Property(e => e.FNumber4)
                .HasDefaultValue(0L)
                .HasColumnName("F_NUMBER4");
            entity.Property(e => e.FNumber5)
                .HasDefaultValue(0L)
                .HasColumnName("F_NUMBER5");
            entity.Property(e => e.FString1)
                .HasMaxLength(30)
                .HasColumnName("F_STRING1");
            entity.Property(e => e.FString2)
                .HasMaxLength(30)
                .HasColumnName("F_STRING2");
            entity.Property(e => e.Fm1).HasColumnName("FM1");
            entity.Property(e => e.Fm1kod)
                .HasMaxLength(3)
                .HasColumnName("FM1KOD");
            entity.Property(e => e.Fm2).HasColumnName("FM2");
            entity.Property(e => e.Fm2kod)
                .HasMaxLength(3)
                .HasColumnName("FM2KOD");
            entity.Property(e => e.Fm3).HasColumnName("FM3");
            entity.Property(e => e.Fm3kod)
                .HasMaxLength(3)
                .HasColumnName("FM3KOD");
            entity.Property(e => e.Fm4).HasColumnName("FM4");
            entity.Property(e => e.Fm4kod)
                .HasMaxLength(3)
                .HasColumnName("FM4KOD");
            entity.Property(e => e.Fm5).HasColumnName("FM5");
            entity.Property(e => e.Fm5kod)
                .HasMaxLength(3)
                .HasColumnName("FM5KOD");
            entity.Property(e => e.Serbest).HasColumnName("SERBEST");
            entity.Property(e => e.Serbestcarpan)
                .HasDefaultValue((short)0)
                .HasColumnName("SERBESTCARPAN");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Telafi).HasColumnName("TELAFI");
            entity.Property(e => e.Toplamfm).HasColumnName("TOPLAMFM");
            entity.Property(e => e.Yil)
                .HasDefaultValue((short)0)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<Tmptmp>(entity =>
        {
            entity.HasKey(e => e.TtId).IsClustered(false);

            entity.ToTable("TMPTMP");

            entity.Property(e => e.TtId).HasColumnName("TT_ID");
            entity.Property(e => e.X1).HasMaxLength(50);
            entity.Property(e => e.X10).HasMaxLength(50);
            entity.Property(e => e.X2).HasMaxLength(50);
            entity.Property(e => e.X3).HasMaxLength(50);
            entity.Property(e => e.X4).HasMaxLength(50);
            entity.Property(e => e.X5).HasMaxLength(50);
            entity.Property(e => e.X6).HasMaxLength(50);
            entity.Property(e => e.X7).HasMaxLength(50);
            entity.Property(e => e.X8).HasMaxLength(50);
            entity.Property(e => e.X9).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.SId).HasColumnName("S_ID");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(20)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Şifre).HasMaxLength(30);
        });

        modelBuilder.Entity<Yemekparam>(entity =>
        {
            entity.HasKey(e => e.YpId).IsClustered(false);

            entity.ToTable("YEMEKPARAM");

            entity.Property(e => e.YpId).HasColumnName("YP_ID");
            entity.Property(e => e.Baslangic)
                .HasDefaultValue((short)0)
                .HasColumnName("BASLANGIC");
            entity.Property(e => e.Bitis)
                .HasDefaultValue((short)0)
                .HasColumnName("BITIS");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .HasColumnName("KOD");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
            entity.Property(e => e.Yemeksayi)
                .HasDefaultValue((short)0)
                .HasColumnName("YEMEKSAYI");
        });

        modelBuilder.Entity<Yillikizinnot>(entity =>
        {
            entity.HasKey(e => e.YinId).IsClustered(false);

            entity.ToTable("YILLIKIZINNOT");

            entity.Property(e => e.YinId).HasColumnName("YIN_ID");
            entity.Property(e => e.Izinnot)
                .HasColumnType("text")
                .HasColumnName("IZINNOT");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Yil)
                .HasDefaultValue((short)0)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<Yillikizinparam>(entity =>
        {
            entity.HasKey(e => e.YipId).IsClustered(false);

            entity.ToTable("YILLIKIZINPARAM");

            entity.Property(e => e.YipId).HasColumnName("YIP_ID");
            entity.Property(e => e.Gun)
                .HasDefaultValue((short)0)
                .HasColumnName("GUN");
            entity.Property(e => e.Ilk)
                .HasDefaultValue((short)0)
                .HasColumnName("ILK");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .HasColumnName("KOD");
            entity.Property(e => e.Son)
                .HasDefaultValue((short)0)
                .HasColumnName("SON");
            entity.Property(e => e.Tanim)
                .HasMaxLength(30)
                .HasColumnName("TANIM");
        });

        modelBuilder.Entity<Yillikizinsonuc>(entity =>
        {
            entity.HasKey(e => e.YisId).IsClustered(false);

            entity.ToTable("YILLIKIZINSONUC");

            entity.Property(e => e.YisId).HasColumnName("YIS_ID");
            entity.Property(e => e.Bakiye)
                .HasDefaultValue((short)0)
                .HasColumnName("BAKIYE");
            entity.Property(e => e.Borcizin)
                .HasDefaultValue((short)0)
                .HasColumnName("BORCIZIN");
            entity.Property(e => e.Degisti)
                .HasDefaultValue((short)0)
                .HasColumnName("DEGISTI");
            entity.Property(e => e.Hakizin)
                .HasDefaultValue((short)0)
                .HasColumnName("HAKIZIN");
            entity.Property(e => e.Kalizin)
                .HasDefaultValue(0)
                .HasColumnName("KALIZIN");
            entity.Property(e => e.Kulizin)
                .HasDefaultValue((short)0)
                .HasColumnName("KULIZIN");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Yil)
                .HasDefaultValue((short)0)
                .HasColumnName("YIL");
        });

        modelBuilder.Entity<Yillikizintarih>(entity =>
        {
            entity.HasKey(e => e.YitId).IsClustered(false);

            entity.ToTable("YILLIKIZINTARIH");

            entity.Property(e => e.YitId).HasColumnName("YIT_ID");
            entity.Property(e => e.Bastar)
                .HasMaxLength(10)
                .HasColumnName("BASTAR");
            entity.Property(e => e.Bittar)
                .HasMaxLength(10)
                .HasColumnName("BITTAR");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(30)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Sure)
                .HasDefaultValue(0)
                .HasColumnName("SURE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
