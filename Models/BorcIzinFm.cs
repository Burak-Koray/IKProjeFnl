using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class BorcIzinFm
{
    public int BifmId { get; set; }

    public string? Sicilno { get; set; }

    public short? Yil { get; set; }

    public short? Ay { get; set; }

    public long? Fm1 { get; set; }

    public long? Fm2 { get; set; }

    public long? Fm3 { get; set; }

    public long? Fm4 { get; set; }

    public long? Fm5 { get; set; }

    public string? Fm1Kod { get; set; }

    public string? Fm2Kod { get; set; }

    public string? Fm3Kod { get; set; }

    public string? Fm4Kod { get; set; }

    public string? Fm5Kod { get; set; }
}
