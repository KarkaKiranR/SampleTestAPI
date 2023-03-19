using System.Collections.Generic;
using WebAPI.Modal;

namespace WebAPI.Repository
{
    public class RetentionRepository
    {
        /// <summary>
        /// RetentionRepository class to use to connect with database for data manipulation or read
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Retention> GetList()
        {
            List<Retention> retentions = new List<Retention>() {
            new Retention { RequestID = "CR001", SiteURL ="https://xyz.sharepoint.com/sites" , RequestorName="Kiran", RequestStatus="Submitted", Department="Tax", Segment="0001a"  },
            new Retention{ RequestID = "CR002", SiteURL ="https://xyz.sharepoint.com/apps" , RequestorName="Suushma", RequestStatus="InProgess", Department="Legal", Segment="0001r"  },
            new Retention{ RequestID = "CR003", SiteURL ="https://xyz.sharepoint.com/inventories" , RequestorName="Sandeep", RequestStatus="Completed 5 Years", Department="Regulatory", Segment="0001c"  }
            };
            return retentions;
    }
}
}
