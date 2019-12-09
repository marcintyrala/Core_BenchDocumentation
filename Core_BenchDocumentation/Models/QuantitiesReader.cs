using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlazorApp1.Data
{
    public class QuantitiesReader
    {
   

        public T ReadQuantities<T>(Component componentName)
        {

            T quantities = default(T) ; 

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                using (StreamReader reader = new StreamReader(componentName.ComponentPath+"\\Quantities.xcfm"))
                {
                    quantities = (T)serializer.Deserialize(reader);
                }
            
            }
            catch (Exception e)
            {
                Console.WriteLine("Quantities deserialization error... " + e);

            }

            return (T)Convert.ChangeType(quantities, typeof(T));
        }

    }
}
