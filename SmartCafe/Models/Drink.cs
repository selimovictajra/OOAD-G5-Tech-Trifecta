﻿using System.ComponentModel.DataAnnotations;

namespace TheSmartCafe.Model
{
    public class Drink
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        
        public Drink() { }
    }
}
