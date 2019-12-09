using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ComponentService
    {
        public Task<List<Component>> GetComponentsAsync()
        {
            string benchPath = Globals.BenchPath;
            ComponentsReader componentsReader = new ComponentsReader();
            componentsReader.ReadAllComponents(benchPath);
            return Task.FromResult(componentsReader.allDevices);

        }

        async public Task<List<Component>> GetComponentAsync(string name)
        {
            List<Component> listOfComponentsFiltered = await GetComponentsAsync();
            //return Task.FromResult(listOfComponents);
            return listOfComponentsFiltered.Where(i => i.Name.ToLower().Contains(name.ToLower())).ToList();
        }

    }
}
