using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class PuantajgunluguDagilim
{
    public int PgdId { get; set; }

    public string? Subkod { get; set; }

    public short? Dagilimid { get; set; }

    public string? Kod { get; set; }

    public string? Tanimi { get; set; }

    public short? Baslangic { get; set; }

    public short? Bitis { get; set; }
}
