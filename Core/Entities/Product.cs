﻿using System.Text.Json.Serialization;

namespace Core.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; } 
    public int Amount { get; set; }
    public decimal Temperature { get; set; }
    public ICollection<Store> Stores { get; set; } = new HashSet<Store>();
    public ICollection<StoreProducts> StoreProducts { get; set; }

}
