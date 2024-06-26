using System;
using System.Collections.Generic;

namespace IKProje.Models;

public partial class TbStrTable
{
    public int FPkId { get; set; }

    public string? FKey { get; set; }

    public string? FText { get; set; }

    public double? FNumber { get; set; }
}
