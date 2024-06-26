using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class IzinPusulasi
{
    public int IpId { get; set; }

    public string? Sicilno { get; set; }

    public string? Bol { get; set; }

    public string? Dep { get; set; }

    public string? Boltanim { get; set; }

    public string? Deptanim { get; set; }

    public string? Isegiristarihi { get; set; }

    public string? Izinsebebi { get; set; }

    public string? Gunmuddet { get; set; }

    public short? Saatmuddet { get; set; }

    public string? Pgkod { get; set; }

    public string? Pgtanim { get; set; }

    public string? Izintipi { get; set; }

    public string? Izinstartdate { get; set; }

    public short? Izinstarttime { get; set; }

    public string? Izinenddate { get; set; }

    public short? Izinendtime { get; set; }

    public string? Isstartdate { get; set; }

    public short? Isstarttime { get; set; }

    public string? Username { get; set; }

    public short? Onay { get; set; }
}
