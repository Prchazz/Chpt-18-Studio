﻿using System;
namespace RestaurantMenu
{
    public class MenuItem


    {
        public string Food { get; set; }
        public string FoodDescription { get; set; }
        public double FoodPrice { get; set; }
        public MenuItem(string afood, string afoodDescription, double afoodPrice)
        {
            Food = afood;
            FoodDescription = afoodDescription;
            FoodPrice = afoodPrice;

        }


    }
        
        
    
  
}
