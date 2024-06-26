using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Yillikizinparam
{
    public int YipId { get; set; }

    public string? Kod { get; set; }

    public string? Tanim { get; set; }

    public short? Ilk { get; set; }

    public short? Son { get; set; }

    public short? Gun { get; set; }
}
