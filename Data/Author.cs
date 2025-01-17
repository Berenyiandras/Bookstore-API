﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookstore_API.Data
{
    [Table( "Authors" )]
    public partial class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string bio { get; set; }

        public virtual IList<Book> Books { get; set; }
    }
}