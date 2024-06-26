using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Ozellikler
{
    public int OId { get; set; }

    public short? Hareketustsinir { get; set; }

    public short? Hareketaltsinir { get; set; }

    public short? Gunufarkligiriscikis { get; set; }

    public short? Gunatlatmasaati { get; set; }

    public short? Gundegisimsaati { get; set; }

    public string? Sirketkodu { get; set; }

    public short? Pgharekettenal { get; set; }

    public short? Yuvarlamayap { get; set; }

    public int? Ssk30danduser { get; set; }

    public int? Cumartesicalisir { get; set; }
}
