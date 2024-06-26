using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Aylikpuantajtanim
{
    public int AptId { get; set; }

    public short? Tanimid { get; set; }

    public string? Tanim { get; set; }

    public string? Kisatanim { get; set; }

    public short? Ssk { get; set; }

    public short? Calisma { get; set; }

    public short? Toplam { get; set; }
}
