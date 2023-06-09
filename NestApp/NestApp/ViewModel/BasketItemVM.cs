﻿namespace NestApp.ViewModel
{
    public class BasketItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal SellPrice { get; set; }
        public decimal? Rating { get; set; }
        public int Count { get; set; }
        public string Image { get; set; }
    }
}
