using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Puantajtipleri
{
    public int PtId { get; set; }

    public string? Kod { get; set; }

    public string? Tanim { get; set; }

    public string? Kisatanim { get; set; }

    public short? Carpan { get; set; }

    public short? Sure { get; set; }

    public string? Isareti { get; set; }

    public short? Onay { get; set; }

    public string? Fazlapuantaj { get; set; }

    public string? Eksikpuantaj { get; set; }

    public string? Esitpuantaj { get; set; }

    public short? Ilk1 { get; set; }

    public short? Ilk2 { get; set; }

    public short? Ilk3 { get; set; }

    public short? Son1 { get; set; }

    public short? Son2 { get; set; }

    public short? Son3 { get; set; }

    public short? Deger1 { get; set; }

    public short? Deger2 { get; set; }

    public short? Deger3 { get; set; }

    public short? Altlimit { get; set; }

    public short? Ustlimit { get; set; }

    public string? Gunlukpuantaj { get; set; }

    public string? Aylikpuantaj { get; set; }

    public short? Formati { get; set; }

    public short? Onceliksirasi { get; set; }
}
