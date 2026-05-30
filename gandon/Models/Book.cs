using System;
using System.Collections.Generic;

namespace gandon.Models;

public partial class Book
{
    public int Idbook { get; set; }

    public string Name { get; set; } = null!;

    public int AuthorId { get; set; }

    public decimal Cena { get; set; }

    public virtual Author Author { get; set; } = null!;
}
