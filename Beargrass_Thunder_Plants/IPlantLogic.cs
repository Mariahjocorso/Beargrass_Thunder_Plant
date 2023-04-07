using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeargrassThunderPlants
{
    internal interface IPlantLogic
    {
        public void AddPlant(Plants plant);

        public List<Plants> GetAllPlants();

        public Flowers GetFlowersByName(string name);

        public List<string> GetOnlyInStockPlants();
    }
}