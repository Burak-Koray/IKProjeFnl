using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Bolumdepart
{
    public int BdId { get; set; }

    public string? Kodu { get; set; }

    public string? Adi { get; set; }

    public string? Tipi { get; set; }

    public string? Anakod { get; set; }

    public string? Sonkod { get; set; }

    public int? FOrder { get; set; }
}
