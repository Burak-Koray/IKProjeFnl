using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Segmentfmplan
{
    public int FPkId { get; set; }

    public string? FTarih { get; set; }

    public string? FSicilno { get; set; }

    public int? FSure { get; set; }

    public string? FFmneden { get; set; }

    public int? FOnay { get; set; }

    public string? FOnaytarih { get; set; }

    public int? FOnaysaat { get; set; }

    public int? FOnaylayan { get; set; }

    public int? FPlanlayan { get; set; }

    public string? FServis { get; set; }

    public string? FPlantarih { get; set; }

    public short? FPlansaat { get; set; }

    public string? FPlanchtarih { get; set; }

    public short? FPlanchsaat { get; set; }

    public string? FNot { get; set; }

    public short? FType { get; set; }
}
