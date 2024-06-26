using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class BorcIzin
{
    public int BiId { get; set; }

    public string? Sicilno { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public int? Borcsaati { get; set; }

    public int? Fazlamesai { get; set; }

    public int? Devir { get; set; }

    public int? MaxFm { get; set; }
}
