using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeDataLib
{
    public class AwesomeThing
    {
        [Key]
        public virtual long AwesomeThingId { get; set; }
        [MaxLength(200)]
        public virtual string Name { get; set; }
        [MaxLength(1000)]
        public virtual string Description { get; set; }
        [MaxLength(500)]
        public virtual string URL { get; set; }
        public virtual long Rating { get; set; }
        public virtual long PositiveVotes { get; set; }
        public virtual long NegativeVotes { get; set; }
    }
}
