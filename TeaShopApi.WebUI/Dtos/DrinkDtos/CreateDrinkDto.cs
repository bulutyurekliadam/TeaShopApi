﻿namespace TeaShopApi.WebUI.Dtos.DrinkDtos
{
    public class CreateDrinkDto
    {
        public string drinkName { get; set; }
        public decimal drinkPrice { get; set; }
        public string drinkImageUrl { get; set; }
    }
}
