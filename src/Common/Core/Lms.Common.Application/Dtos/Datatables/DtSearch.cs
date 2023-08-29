using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Common.Application.Dtos.Datatables
{
    /// <summary>
    /// Represents the search options
    /// </summary>
    public class DtSearch
    {
        /// <summary>
        /// Initialize a new instance of <see cref="DtSearch"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="regex"></param>
        public DtSearch(string value, bool regex)
        {
            Value = value;
            Regex = regex;
        }

        /// <summary>
        /// Global search value. To be applied to all columns which have searchable as true.
        /// search[value]
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// true if the global filter should be treated as a regular expression for advanced searching, false otherwise. Note that normally server-side processing scripts will not perform regular expression searching for performance reasons on large data sets, but it is technically possible and at the discretion of your script.
        /// search[regex]
        /// </summary>
        public bool Regex { get; set; }
    }
}
