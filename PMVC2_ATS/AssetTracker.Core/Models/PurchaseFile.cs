﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class PurchaseFile
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int PurchaseOrderId { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
