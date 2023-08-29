using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Common.Application.Dtos.Datatables
{
    public interface IPagedRequest
    {
        /// <summary>
        /// Paging first record indicator. This is the start point in the current data set (0 index based - i.e. 0 is the first record).
        /// </summary>
        int Start { get; set; }

        /// <summary>
        /// Number of records that the table can display in the current draw. It is expected that the number of records returned will be equal to this number, unless the server has fewer records to return. Note that this can be -1 to indicate that all records should be returned (although that negates any benefits of server-side processing!)
        /// </summary>
        int Length { get; set; }
    }

    /// <summary>
    /// Represents a datatable request for serverSide request
    /// </summary>    
    public interface IDtParameters : IPagedRequest
    {
        /// <summary>
        /// Draw counter. This is used by DataTables to ensure that the Ajax returns from server-side processing requests are drawn in sequence by DataTables (Ajax requests are asynchronous and thus can return out of sequence). This is used as part of the draw return parameter (see below).
        /// </summary>
        int Draw { get; set; }

        /// <summary>
        /// Global search value. To be applied to all columns which have searchable as true.
        /// </summary>
        DtSearch Search { get; set; }

        /// <summary>
        /// Column to which ordering should be applied. This is an index reference to the columns array of information that is also submitted to the server.
        /// </summary>
        IEnumerable<DtOrder> Orders { get; set; }
        //IDictionary<int, DtOrder> Orders { get; set; }

        ///// <summary>
        ///// Column's data source
        ///// </summary>
        IEnumerable<DtColumn> Columns { get; set; }
        //IDictionary<int, DtColumn> Columns { get; set; }
    }

    public class PagedRequest : IPagedRequest
    {
        /// <summary>
        /// Paging first record indicator. This is the start point in the current data set (0 index based - i.e. 0 is the first record).
        /// </summary>
        public int Start { get; set; }

        /// <summary>
        /// Number of records that the table can display in the current draw. It is expected that the number of records returned will be equal to this number, unless the server has fewer records to return. Note that this can be -1 to indicate that all records should be returned (although that negates any benefits of server-side processing!)
        /// </summary>
        public int Length { get; set; }
    }

    /// <summary>
    /// Represents a datatable request for serverSide request
    /// </summary>
    public class DtParameters : PagedRequest
    {
        /// <summary>
        /// Draw counter. This is used by DataTables to ensure that the Ajax returns from server-side processing requests are drawn in sequence by DataTables (Ajax requests are asynchronous and thus can return out of sequence). This is used as part of the draw return parameter (see below).
        /// </summary>
        public int Draw { get; set; }

        /// <summary>
        /// Global search value. To be applied to all columns which have searchable as true.
        /// </summary>
        public DtSearch Search { get; set; }

        /// <summary>
        /// Column to which ordering should be applied. This is an index reference to the columns array of information that is also submitted to the server.
        /// </summary>
        //public IDictionary<int, DtOrder> Orders { get; set; }

        public IEnumerable<DtOrder> Orders { get; set; }

        ///// <summary>
        ///// Column's data source
        ///// </summary>
        public IEnumerable<DtColumn> Columns { get; set; }

        //public IDictionary<int, DtColumn> Columns { get; set; }

        public DtParameters()
        {

        }
    }
}
