using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(1000,MinimumLength =3)]
        [Required]
        public string Title { get; set; }
        [MaxLength(10000)]
        public string Content { get; set; }
        [MaxLength(10)]
        public string Tag { get; set; }
        
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
