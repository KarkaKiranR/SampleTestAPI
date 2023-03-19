using System.Collections.Generic;
using WebAPI.Repository;

namespace WebAPI.Modal
{

    /// <summary>
    /// Retention Class holds the properties to hold the data 
    /// </summary>
    public class Retention
    {
        /// <summary>
        /// RequestID
        /// </summary>
        public string RequestID { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string SiteURL { get; set; }

        /// <summary>
        /// RequestorName
        /// </summary>
        public string RequestorName { get; set; }

        /// <summary>
        /// RequestStatus
        /// </summary>
        public string RequestStatus { get; set; }

        /// <summary>
        /// Segment
        /// </summary>
        public string Segment { get; set; }

        /// <summary>
        /// Department
        /// </summary>
        public string Department { get; set; }



    }
    /// <summary>
    /// Retention Modal class used to do business logic and communicate with repository for data.
    /// </summary>
    public class RetentionModal
    {
        /// <summary>
        /// GetList method to return the Retention List values to controller
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Retention> GetList()
        {
            RetentionRepository retentionRepository = new RetentionRepository();
            return retentionRepository.GetList();
        }
    }

}