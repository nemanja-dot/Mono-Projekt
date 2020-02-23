﻿using System;
using System.Collections.Generic;

namespace Project.Service.Model
{
    public class PagingDataList<T> : List<T>, IEnumerable<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PagingDataList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 0);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages - 1);
            }
        }
    }
}