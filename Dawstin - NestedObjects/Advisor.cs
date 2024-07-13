using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dawstin___NestedObjects
{
    /// <summary>
    /// Represents the college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// The legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The advisors work email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Building and room number of the office
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}
