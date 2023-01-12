using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressStore.Modules.ActivityLog.Models
{
    public class MostViewEntityDto
    {
        public long EntityId { get; set; }

        public string EntityTypeId { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int ViewedCount { get; set; }
    }
}
