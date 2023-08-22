using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Common.Application.Dtos.Datatables
{
    /// <summary>
    /// Represents order in <see cref="DtParameters"/>
    /// </summary>
    public class DtOrder
    {
        public DtOrder()
        {

        }

        /// <summary>
        /// Column to which ordering should be applied. This is an index reference to the columns array of information that is also submitted to the server.
        /// order[i][column]
        /// </summary>
        public int Column { get; set; }

        /// <summary>
        /// Ordering direction for this column. It will be asc or desc to indicate ascending ordering or descending ordering, respectively.
        /// order[i][dir]
        /// </summary>
        public string Dir { get; set; }
    }

    /// <summary>
    /// Sort orders of jQuery DataTables.
    /// </summary>
    public enum DtOrderDir
    {
        Asc,
        Desc
    }
}
