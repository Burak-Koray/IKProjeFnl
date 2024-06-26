using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class SicilResim
{
    public int SrId { get; set; }

    public string? Sicilno { get; set; }

    public byte[]? Resim { get; set; }
}
