using System;
using System.Collections.Generic;
using System.Linq;
using Lyukikuki.Data.Interfaces;
using Lyukikuki.Data.Models;

namespace Lyukikuki.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        ProductId = 0,
                        Name = "Birds Eye 2 Original Chicken Chargrills 170G",
                        Price = 2.00M,
                        InStock = true,
                        ImageUrl =
                            "https://img.tesco.ie/Groceries/pi/756/5000116111756/IDShot_225x225.jpg",
                        Category = _categoryRepository.Categories.First(),
                        ProductDetails = "Portions of chicken formed from marinated chunks of chicken breast, prefried, seared and glazed.\r\n\r\nFor more visit birdseye.co.uk\r\n\r\nMumsnet Rated\r\nFor more information please visit www.birdseye.co.uk/mumsnet\r\n\r\nOur Chicken Chargrills will always be made with 100% chicken breast, using just a few simple ingredients & nothing more.\r\nThat\'s the difference with Birds Eye: You get our finest chicken, tasty & tender, raised responsibly by farmers we know & trust.\r\n\r\nWhy does it say made with 100% chicken breast if it\'s 75% chicken breast?\r\nMade with 100% chicken breast means we use only chicken breast meat in our range. The other 25% relates to the other tasty ingredients such as the coating.\r\n\r\nForever Food Together\r\nWe are passionate about our sustainability programme to provide you with tasty and nutritious food that is responsibly sourced and prepared - forever.\r\n\r\nMade with 100% chicken breast\r\nNo artificial colours, flavours or preservatives",
                        EnergyKj = 595,
                        EnergyKcal = 142,
                        Fat = 7.4,
                        Saturates = 1.8,
                        Carbohydrate = 4.6,
                        Sugars = 0.5,
                        Protein = 18,
                        Salt = 0.93,
                    },
                    new Product
                    {
                        ProductId = 1,
                        Name = "Goodfella's Stone Baked Thin Pepperoni Pizza 340G",
                        Price = 2.50M,
                        InStock = true,
                        ImageUrl =
                            "https://img.tesco.ie/Groceries/pi/501/5011003046501/IDShot_225x225.jpg",
                        Category = _categoryRepository.Categories.First(),
                        ProductDetails = "A Stone Baked Thin Pizza Base Topped with Tomato Sauce, Mozzarella Cheese and Smoke Flavoured Pepperoni.\r\n\r\nJoin the conversation on Facebook & Twitter\r\n\r\nMade with dough that\'s well rested and baked on Italian Stone, topped with our signature tomato sauce (with no artificial colours or flavours), loaded with cheese and our meatiest pepperoni. Our pizzas are then immediately frozen to lock in the freshness and flavour. Goodfella\'s... delicious Italian American style pizza from the original frozen pizza people.\r\n\r\nFinger lickin\' pepperoni\r\nMelting mozzarella\r\nLight \'n\' crispy base",
                        EnergyKj = 1138,
                        EnergyKcal = 271,
                        Fat = 12,
                        Saturates = 4.8,
                        Carbohydrate = 27,
                        Sugars = 2.9,
                        Protein = 13,
                        Salt = 1.2,
                    },
                    new Product
                    {
                        ProductId = 2,
                        Name = "Goodfella's Stone Baked Thin Margherita Pizza 345G",
                        Price = 2.50M,
                        InStock = true,
                        ImageUrl =
                            "https://img.tesco.ie/Groceries/pi/389/5011003046389/IDShot_225x225.jpg",
                        Category = _categoryRepository.Categories.First(),
                        ProductDetails = "A Stone Baked Thin Pizza Base Topped with Tomato Sauce, Mozzarella Cheese and Smoke Flavoured Pepperoni.\r\n\r\nJoin the conversation on Facebook & Twitter\r\n\r\nMade with dough that\'s well rested and baked on Italian Stone, topped with our signature tomato sauce (with no artificial colours or flavours), loaded with cheese and our meatiest pepperoni. Our pizzas are then immediately frozen to lock in the freshness and flavour. Goodfella\'s... delicious Italian American style pizza from the original frozen pizza people.\r\n\r\nFinger lickin\' pepperoni\r\nMelting mozzarella\r\nLight \'n\' crispy base",
                        EnergyKj = 1138,
                        EnergyKcal = 271,
                        Fat = 12,
                        Saturates = 4.8,
                        Carbohydrate = 27,
                        Sugars = 2.9,
                        Protein = 13,
                        Salt = 1.2,
                    },
                    new Product
                    {
                        ProductId = 3,
                        Name = "Tropicana Orange Juice Smooth 950 Ml",
                        Price = 2.50M,
                        InStock = true,
                        ImageUrl =
                            "https://digitalcontent.api.tesco.com/v1/media/ghs/composite/fcbfc3d0-6322-4e33-b397-2fd8dae35d3f.jpeg?h=540&w=540",
                        Category = _categoryRepository.Categories.Last(),
                        ProductDetails = "Smooth Orange Juice\r\n\r\nEnjoy Tropicana as part of a varied and balanced diet and healthy lifestyle.\r\n\r\nFind out more at tropicana.co.uk\r\n\r\n- Delicious Tropicana Orange Juice is made with 100% pure pressed fruit\r\n- Not from concentrate, Tropicana contains only pure juices and purees\r\n- Each 150ml serving contains 45% of the recommended daily Vitamin C, which contributes to the reduction of tiredness and fatigue\r\n- Just one serving of juice provides 1 of your 5 daily portions of fruit and veg\r\n- Rise and shine with a glass of Tropicana at breakfast\r\n\r\nWe\'ve been making juice for over 70 years and still bring the same passion to the process as when we first started. The Tropicana story began with Anthony T. Rossi, who arrived in the U.S. with just $25 in his pocket. He founded Tropicana in 1947 with the mission of making the goodness of the finest fruit accessible to everyone. No matter how hard you look, you won\'t find anything but 100% pure fruit, vegetables and vitamins in Tropicana juices. We never add sugar, so you can rest assured that all that deliciousness is 100% pure and natural, straight from the fruit, and counts as 1 of your 5 a day.\r\n\r\nAt Tropicana we are obsessed by juice. We are also driven by the desire to deliver great nutrition to everyone who drinks Tropicana. Have you tried the new Tropicana Essentials range? Tropicana\'s new range of Essentials juices is packed full of fruits, vitamins and veg - each flavour designed with your everyday health and wellness needs in mind.\r\n\r\n100% pure pressed fruit\r\nNot from concentrate",
                        EnergyKj = 172,
                        EnergyKcal = 41,
                        Fat = 0,
                        Saturates = 0,
                        Carbohydrate = 9.3,
                        Sugars = 8.4,
                        Protein = 0.8,
                        Salt = 0,
                    },
                         new Product
                    {
                        ProductId = 4,
                        Name = "Tropicana Orange Juice Smooth 950 Ml",
                        Price = 2.50M,
                        InStock = true,
                        ImageUrl =
                            "https://digitalcontent.api.tesco.com/v1/media/ghs/composite/fcbfc3d0-6322-4e33-b397-2fd8dae35d3f.jpeg?h=540&w=540",
                        Category = _categoryRepository.Categories.Last(),
                        ProductDetails = "Smooth Orange Juice\r\n\r\nEnjoy Tropicana as part of a varied and balanced diet and healthy lifestyle.\r\n\r\nFind out more at tropicana.co.uk\r\n\r\n- Delicious Tropicana Orange Juice is made with 100% pure pressed fruit\r\n- Not from concentrate, Tropicana contains only pure juices and purees\r\n- Each 150ml serving contains 45% of the recommended daily Vitamin C, which contributes to the reduction of tiredness and fatigue\r\n- Just one serving of juice provides 1 of your 5 daily portions of fruit and veg\r\n- Rise and shine with a glass of Tropicana at breakfast\r\n\r\nWe\'ve been making juice for over 70 years and still bring the same passion to the process as when we first started. The Tropicana story began with Anthony T. Rossi, who arrived in the U.S. with just $25 in his pocket. He founded Tropicana in 1947 with the mission of making the goodness of the finest fruit accessible to everyone. No matter how hard you look, you won\'t find anything but 100% pure fruit, vegetables and vitamins in Tropicana juices. We never add sugar, so you can rest assured that all that deliciousness is 100% pure and natural, straight from the fruit, and counts as 1 of your 5 a day.\r\n\r\nAt Tropicana we are obsessed by juice. We are also driven by the desire to deliver great nutrition to everyone who drinks Tropicana. Have you tried the new Tropicana Essentials range? Tropicana\'s new range of Essentials juices is packed full of fruits, vitamins and veg - each flavour designed with your everyday health and wellness needs in mind.\r\n\r\n100% pure pressed fruit\r\nNot from concentrate",
                        EnergyKj = 172,
                        EnergyKcal = 41,
                        Fat = 0,
                        Saturates = 0,
                        Carbohydrate = 9.3,
                        Sugars = 8.4,
                        Protein = 0.8,
                        Salt = 0,
                    },
                         new Product
                    {
                        ProductId = 5,
                        Name = "Tropicana Orange Juice Smooth 950 Ml",
                        Price = 2.50M,
                        InStock = true,
                        ImageUrl =
                            "https://digitalcontent.api.tesco.com/v1/media/ghs/composite/fcbfc3d0-6322-4e33-b397-2fd8dae35d3f.jpeg?h=540&w=540",
                        Category = _categoryRepository.Categories.Last(),
                        ProductDetails = "Smooth Orange Juice\r\n\r\nEnjoy Tropicana as part of a varied and balanced diet and healthy lifestyle.\r\n\r\nFind out more at tropicana.co.uk\r\n\r\n- Delicious Tropicana Orange Juice is made with 100% pure pressed fruit\r\n- Not from concentrate, Tropicana contains only pure juices and purees\r\n- Each 150ml serving contains 45% of the recommended daily Vitamin C, which contributes to the reduction of tiredness and fatigue\r\n- Just one serving of juice provides 1 of your 5 daily portions of fruit and veg\r\n- Rise and shine with a glass of Tropicana at breakfast\r\n\r\nWe\'ve been making juice for over 70 years and still bring the same passion to the process as when we first started. The Tropicana story began with Anthony T. Rossi, who arrived in the U.S. with just $25 in his pocket. He founded Tropicana in 1947 with the mission of making the goodness of the finest fruit accessible to everyone. No matter how hard you look, you won\'t find anything but 100% pure fruit, vegetables and vitamins in Tropicana juices. We never add sugar, so you can rest assured that all that deliciousness is 100% pure and natural, straight from the fruit, and counts as 1 of your 5 a day.\r\n\r\nAt Tropicana we are obsessed by juice. We are also driven by the desire to deliver great nutrition to everyone who drinks Tropicana. Have you tried the new Tropicana Essentials range? Tropicana\'s new range of Essentials juices is packed full of fruits, vitamins and veg - each flavour designed with your everyday health and wellness needs in mind.\r\n\r\n100% pure pressed fruit\r\nNot from concentrate",
                        EnergyKj = 172,
                        EnergyKcal = 41,
                        Fat = 0,
                        Saturates = 0,
                        Carbohydrate = 9.3,
                        Sugars = 8.4,
                        Protein = 0.8,
                        Salt = 0,
                    },
                };
            }
        }
    }
}
