﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int? SalesRepID { get; set; }

        public int? CustomerID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? PaymentDueDate { get; set; }

        public decimal? Freight { get; set; }

        public bool Shipped { get; set; }

        [Required, StringLength(40, ErrorMessage = "Shipment Name is restricted to 40 characters")]
        public string ShipName { get; set; }

        public int? ShipAddressID { get; set; }

        [StringLength(250, ErrorMessage = "Comments is restricted to 250 characters")]
        public string Comments { get; set; }
    }
}
