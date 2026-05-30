using System;
using System.Collections.Generic;

namespace gandon.Models;

public partial class Librarian
{
    public int Idlibrarian { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
