using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndToEnd.Data.EndToEnd
{
    public partial class Memories
    {
        public int Id { get; set; }
        public DateTime? memDate { get; set; }
        public string memType { get; set; }
        public string memText { get; set; }
        public string UserName { get; set; }

    }
}
