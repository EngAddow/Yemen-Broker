﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yemen_Broker.Models;

namespace Yemen_Broker.ViewModels
{
    public class AdIndexViewModel
    {
        public IEnumerable<Ad> Ads { get; set; }
        public string SearchString { get; set; }
        public string City { get; set; }
        public double From { get; set; }
        public double To { get; set; }
        public Pager Pager { get; set; }
    }
}