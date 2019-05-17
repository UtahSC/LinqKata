using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public static class DataHelper
    {
        private static List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        private static Random random = new Random();
        public static List<int> GetIntList()
        {
            return intList.OrderBy(x => random.Next()).ToList();
        }

        public static List<Planet> GetPlanets()
        {
            return planets.OrderBy(x => random.Next()).ToList();
        }

        private static List<Planet> planets = new List<Planet>{
            new Planet {
                Name="Mercury",
                Ordinal=1,
                Mass=2.1,
                IsHabitable=false
            },
            new Planet {
                Name="Venus",
                Ordinal=2,
                Mass=20.1,
                IsHabitable=false
            },
            new Planet {
                Name="Earth",
                Ordinal=3,
                Mass=20.1,
                IsHabitable=true
            },
            new Planet {
                Name="Mars",
                Ordinal=4,
                Mass=10.1,
                IsHabitable=false
            },
            new Planet {
                Name="Jupiter",
                Ordinal=5,
                Mass=500.1,
                IsHabitable=false
            },
            new Planet {
                Name="Saturn",
                Ordinal=6,
                Mass=200.1,
                IsHabitable=false
            },
            new Planet {
                Name="Uranus",
                Ordinal=7,
                Mass=100.1,
                IsHabitable=false
            },
            new Planet {
                Name="Neptune",
                Ordinal=8,
                Mass=100.1,
                IsHabitable=false
            },
            new Planet {
                Name="Pluto - Totally still a planet!",
                Ordinal=9,
                Mass=1.1,
                IsHabitable=false
            },
        };
    }

    public class Planet
    {
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public double Mass { get; set; }
        public bool IsHabitable { get; set; }
    }
}