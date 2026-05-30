using System;
using System.Collections.Generic;

namespace gandon.Models;

public partial class Author
{
    public int Idauthor { get; set; }

    public string AuthorName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();

    public override string ToString()
    {
        return AuthorName;
    }
}
