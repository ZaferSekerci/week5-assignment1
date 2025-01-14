﻿using Northwind.EntityLayer.Concrete.Bases;

#nullable disable

namespace Northwind.EntityLayer.Concrete.Models
{
    public partial class EmployeeTerritory : EntityBase
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
