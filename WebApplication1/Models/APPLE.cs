using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class APPLE
{
    public string? NAME { get; set; }

    public int? LOCK_VERSION { get; set; }

    /// <summary>
    /// 不重複流水號
    /// </summary>
    public string GID { get; set; } = null!;
}
