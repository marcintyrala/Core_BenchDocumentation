using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class QuantitiesService  
    {


        async public Task<Quantities> GetQuantitiesAsync(Component component)
        {
            
            QuantitiesReader quantitiesReader = new QuantitiesReader();
            return quantitiesReader.ReadQuantities<Quantities>(component);
        }
    }
}
