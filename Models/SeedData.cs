using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBowls.Data;
using System;
using System.Linq;

namespace MvcBowls.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)

        {
            using (var context = new MvcBowlContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBowlContext>>()))
            {
                // Look for any movies.
                if (context.Bowl.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bowl.AddRange(
                    new Bowl
                    {
                        VarietyOfBowls = "Pasta Bowl",
                        Color = "Blue",
                        Material = "Fiber",
                        Uses = "Food Store",
                        Price = 4.50M,
                        Rating = 3.5M
                    },

                    new Bowl
                    {
                        VarietyOfBowls = "Pet Bowl",
                        Color = "Yellow",
                        Material = "Plastic plus Steel",
                        Uses = "Food For Pet",
                        Price = 5.50M,
                        Rating = 4.5M
                    },
                     new Bowl
                     {
                         VarietyOfBowls = "Microwave Bowl",
                         Color = "Black",
                         Material = "Ceramic",
                         Uses = "Reuse food",
                         Price = 3.50M,
                         Rating = 4M
                     },
                      new Bowl
                      {
                          VarietyOfBowls = "Gold Bowl",
                          Color = "Gold",
                          Material = "24 Caret Gold",
                          Uses = "Decoration ",
                          Price = 100.50M,
                          Rating = 5M
                      },

                       new Bowl
                       {
                           VarietyOfBowls = "Ovel Bowl",
                           Color = "Red",
                           Material = "Stainless Steel",
                           Uses = "Plant Growing",
                           Price = 5.0M,
                           Rating = 4.5M
                       },
                        new Bowl
                        {
                            VarietyOfBowls = "Salad Bowl",
                            Color = "White",
                            Material = "Rubber ",
                            Uses = "Lunch Box",
                            Price = 6.50M,
                            Rating = 2.5M
                        },

                         new Bowl
                         {
                             VarietyOfBowls = "Soup Bowl",
                             Color = "Orange",
                             Material = "Ceramic",
                             Uses = "Fruit Storage",
                             Price = 5.50M,
                             Rating = 3.5M
                         },

                          new Bowl
                          {
                              VarietyOfBowls = "Cereal Bowl",
                              Color = "Yellow",
                              Material = "Glass",
                              Uses = "Breakfast",
                              Price = 7.50M,
                              Rating = 5.0M
                          },
                           new Bowl
                           {
                               VarietyOfBowls = "Gym Bowl",
                               Color = "Red",
                               Material = "Silicon",
                               Uses = "Workout Places",
                               Price = 3.50M,
                               Rating = 4.5M
                           },

                            new Bowl
                            {
                                VarietyOfBowls = "Big Bowl",
                                Color = "Green",
                                Material = "Glass",
                                Uses = "Dinner",
                                Price = 10.50M,
                                Rating = 5.0M
                            }
                            );

                context.SaveChanges();


            }
        }
    }
}