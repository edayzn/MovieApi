﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Result.CategoryResults
{
     public class GetCategoryByIdQueryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
