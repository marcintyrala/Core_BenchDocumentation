using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BlazorApp1.Data
{
    class ComponentsReader
    {

        public List<Component> allDevices { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public ComponentsReader()
        {
            allDevices = new List<Component>();
        }


        /// <summary>
        /// Read single component
        /// </summary>
        /// <param name="path">component .xdev file path</param>
        /// <returns>Returns single component instance</returns>
        public Component ReadComponent(string path)
        {

            Component device = null;

            XmlSerializer serializer = new XmlSerializer(typeof(Component));
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    device = (Component)serializer.Deserialize(reader);
                }
                return device;
            }
            catch(Exception e)
            {
                Console.WriteLine("Component blocked, trying to deobfuscate... "); 
            }

            //If component is blocked
            Deobfuscator deobfuscator = new Deobfuscator();
            string deobfuscatedContent =deobfuscator.Deobfuscate(path);
            using (var reader = new StringReader(deobfuscatedContent))
            {
                device = (Component)serializer.Deserialize(reader);
            }

            return device;
        }


        /// <summary>
        /// Read all components in bench/components by default
        /// </summary>
        /// <param name="benchPath">General path to all components</param>
        /// <returns>List of all components deserialized</returns>
        public void ReadAllComponents(string benchPath = @"C:\bench_backup_22-11-2019\Components")
        {
            List<String> listOfxdevInCurrentDir = SearchXDEVFileInCurrentDirectory(benchPath);
            List<String> listOfFoldersInCurrentDir;

            //List<String> allfiles2 = Directory.GetFiles(benchPath, "*.xdev", SearchOption.AllDirectories).ToList<String>();


            foreach (var filePath in listOfxdevInCurrentDir)
            {
                var device = ReadComponent(filePath);

                if (device != null)
                {
                    allDevices.Add(device);
                    device.ComponentPath =  System.IO.Directory.GetParent(filePath).FullName;
                    device.Path = filePath;
                    device.FatherComponent = CheckParentComponentName(filePath);
                }
                else
                {
                    allDevices.Add(new Component() { Name = "Protected component :(" });
                    Console.WriteLine("Error on path: " + filePath);
                }
            }


            //f ((listOfFoldersInCurrentDir = SearchFoldersInCurrentDirectory(benchPath)).Count != 0);
            listOfFoldersInCurrentDir = SearchFoldersInCurrentDirectory(benchPath);
            foreach (var dir in listOfFoldersInCurrentDir)
                ReadAllComponents(dir);



        }

        /// <summary>
        /// Search .xdev file in directory
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public List<String> SearchXDEVFileInCurrentDirectory(string folderPath) => Directory.GetFiles(folderPath, "*.xdev", SearchOption.TopDirectoryOnly).ToList<String>();

        /// <summary>
        /// List all folders in directory
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public List<String> SearchFoldersInCurrentDirectory(string directoryPath) => Directory.GetDirectories(directoryPath).ToList<String>();

        /// <summary>
        /// Return parent component name or "-" if there is no father component
        /// </summary>
        /// <param name="xdevPath"></param>
        /// <returns></returns>
        public string CheckParentComponentName(string xdevPath)
        {
            var parentFullName = System.IO.Directory.GetParent(xdevPath).FullName;
            var grandParentFullPath = System.IO.Directory.GetParent(parentFullName);
            var grandParentFullName = grandParentFullPath.FullName;
            List<String> countxdevFilesInGrandParentDir = SearchXDEVFileInCurrentDirectory(grandParentFullName);
            if (countxdevFilesInGrandParentDir.Count == 0) return "-";
            
            return grandParentFullPath.Name;

        }
    }
}

