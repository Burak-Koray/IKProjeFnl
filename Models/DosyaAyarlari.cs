using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class DosyaAyarlari
{
    public int DaId { get; set; }

    public string? Dosya { get; set; }

    public short? Tarihstart { get; set; }

    public string? Tarihtip { get; set; }

    public short? Saatstart { get; set; }

    public short? Saatlen { get; set; }

    public short? Sicilstart { get; set; }

    public short? Sicillen { get; set; }

    public short? Tipstart { get; set; }

    public string? Tipgiris { get; set; }

    public string? Tipcikis { get; set; }

    public short? Nedenstart { get; set; }

    public short? Nedenlen { get; set; }

    public short? Kapistart { get; set; }

    public short? Kapilen { get; set; }

    public short? Tarihid { get; set; }
}
