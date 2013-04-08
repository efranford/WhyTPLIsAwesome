using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeDataLib
{
    public class AwesomeComment
    {
        [Key]
        public virtual long AwesomeCommentId { get; set; }
        [MaxLength(2000)]
        public virtual string CommentText { get; set; }

        [ForeignKey("ResponseToCommentId")]
        public virtual AwesomeComment ResponseToComment { get; set; }
        public virtual long? ResponseToCommentId { get; set; }
    }
}
