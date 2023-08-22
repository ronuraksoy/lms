using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Common.Application.Dtos.Datatables
{
    /// <summary>
    /// Represents a datatable column
    /// </summary>
    public class DtColumn
    {
        public DtColumn()
        {

        }

        /// <summary>
        /// Column's data source, as defined by columns.data.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Column's name, as defined by columns.name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag to indicate if this column is searchable (true) or not (false). This is controlled by columns.searchable.
        /// </summary>
        public bool Searchable { get; set; }

        /// <summary>
        /// Flag to indicate if this column is orderable (true) or not (false). This is controlled by columns.orderable.
        /// </summary>
        public bool Orderable { get; set; }

        /// <summary>
        /// Search value to apply to this specific column.
        /// </summary>
        public string SearchValue { get; set; }

        /// <summary>
        /// Flag to indicate if the search term for this column should be treated as regular expression (true) or not (false). 
        /// As with global search, normally server-side processing scripts will not perform regular expression searching for performance reasons on large data sets, but it is technically possible and at the discretion of your script.
        /// </summary>
        public bool SearchRegEx { get; set; }
    }
}
