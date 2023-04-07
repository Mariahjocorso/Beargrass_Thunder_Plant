using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeargrassThunderPlants
{
    internal class PlantLogic
    {
        private List<Plants> _plants;
        private Dictionary<string, Flowers> _flowers;
        private Dictionary<string, Grasses> _grasses;

        public PlantLogic()
        {
            _plants = new List<Plants>();
            { 
                 new Flowers
                 {
                     Description = "Spring effemeral, starts in stock.",
                     Height = 6,
                     Color = "Blue",
                     Name = "Blue Bells",
                     Price = 10.00m,
                     Quantity = 5
                 };
                 new Flowers
                 {
                     Quantity = 20,
                     Price = 5.00m,
                     Name = "Columbine",
                     Description = "Red blooms, attacts humminbirds, in stock in seeds",
                     Height = 10,
                    Color = "Red"
                   };
                new Grasses
                {
                    Quantity = 5,
                    Price = 10.00m,
                    Name = "Upland Bent Grass",
                    Description = "Native grass, water loving, in stock in seeds",
                    Color = "Green",
                    Height = 78
                    };
            }

            _plants = new List<Plants>();
            _flowers = new Dictionary<string, Flowers>();
            _grasses = new Dictionary<string, Grasses>();
        }

        public void AddPlant(Plants plant)
        {
            if (plant is Flowers)
            {
                _flowers.Add(plant.Name, plant as Flowers);
            }
            if (plant is Grasses)
            {
                _grasses.Add(plant.Name, plant as Grasses);
            }
            _plants.Add(plant);
        }

        public List<Plants> GetAllPlants()
        {
            return _plants;
        }

        public Flowers GetFlowersByName(string name)
        {
            try
            {
                return _flowers[name];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<string> GetOnlyInStockProducts()
        {
            return _plants.Where(x => x.Quantity > 0).Select(x => x.Name).ToList();
        }
    }
}