using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Personelkaza
{
    public int PkId { get; set; }

    public string? Sicilno { get; set; }

    public string? Tarih { get; set; }

    public string? Neden { get; set; }

    public string? Islem { get; set; }
}
