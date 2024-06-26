using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Personeldisiplin
{
    public int PdId { get; set; }

    public string? Sicilno { get; set; }

    public string? Tarih { get; set; }

    public string? Veren { get; set; }

    public string? Neden { get; set; }

    public string? Karar { get; set; }
}
