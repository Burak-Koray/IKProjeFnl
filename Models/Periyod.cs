using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Periyod
{
    public int PId { get; set; }

    public string? Kod { get; set; }

    public string? Tanim { get; set; }

    public string? Datestart { get; set; }

    public string? Dateend { get; set; }
}
