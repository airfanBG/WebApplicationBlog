using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
