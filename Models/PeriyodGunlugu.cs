using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class PeriyodGunlugu
{
    public int PgId { get; set; }

    public string? Subkod { get; set; }

    public short? Gunlukid { get; set; }

    public string? Kod { get; set; }

    public string? Tanim { get; set; }

    public short? Gun { get; set; }
}
