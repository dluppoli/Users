using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsersAsp.ViewModels
{
    public class PaginatedDataViewModel<T>
    {
        public int Page { get; set; }
        public int Pages { get; set; }
        public List<T> Data { get; set; }
    }
}