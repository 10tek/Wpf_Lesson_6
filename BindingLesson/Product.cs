using System;
using System.Collections.Generic;
using System.Text;

namespace BindingLesson
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
