using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Yemekparam
{
    public int YpId { get; set; }

    public string? Kod { get; set; }

    public string? Tanim { get; set; }

    public short? Baslangic { get; set; }

    public short? Bitis { get; set; }

    public short? Yemeksayi { get; set; }
}
