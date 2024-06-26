using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class Puantajgunlugu
{
    public int PgId { get; set; }

    public string? Kod { get; set; }

    public string? Tanim { get; set; }

    public short? Grup { get; set; }

    public short? Model { get; set; }

    public short? Normalsure { get; set; }

    public short? Yemeksure { get; set; }

    public short? Mesaierkengiris { get; set; }

    public short? Mesaierkencikis { get; set; }

    public short? Mesainormalgiris { get; set; }

    public short? Mesainormalcikis { get; set; }

    public short? Mesaigecgiris { get; set; }

    public short? Mesaigeccikis { get; set; }

    public string? Haktip1 { get; set; }

    public short? Haksure1 { get; set; }

    public string? Haktip2 { get; set; }

    public short? Haksure2 { get; set; }

    public string? Gunluk1 { get; set; }

    public string? Gunluk2 { get; set; }

    public string? Gunluk3 { get; set; }

    public string? Fmptipi { get; set; }

    public short? Yemekdagilimi { get; set; }

    public string? Haktanim1 { get; set; }

    public string? Haktanim2 { get; set; }
}
