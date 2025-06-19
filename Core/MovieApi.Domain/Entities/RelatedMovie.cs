using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entities
{
    public class RelatedMovie
    {
        public int RelatedId { get; set; }
        public int MoviId { get; set; }
        public int UserId { get; set; }
        public bool IsWatch { get; set; }

    }
}
