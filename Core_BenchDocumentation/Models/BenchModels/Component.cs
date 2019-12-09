using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Core_BenchDocumentation.Models.BenchModels
{
    /// <summary>
    /// Component Xml Model 
    /// </summary>
    [XmlRoot(ElementName = "Device")]
    public class Component
    {
        // Path added as extra field
        public string Path { get; set; }
        public string FatherComponent { get; set; }
        public string ComponentPath { get; set; }


        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Version")]
        public string Version { get; set; }

        [System.Xml.Serialization.XmlElement("Description")]
        public string Description { get; set; }
        [System.Xml.Serialization.XmlElement("Links")]
        public Links Links { get; set; }
        [XmlElement(ElementName = "Methods")]
        public Methods Methods { get; set; }


    }

    #region Xml document elements description

    [XmlRoot(ElementName = "Links")]
    public class Links
    {
        [XmlElement("Link")]
        public List<Link> Link { get; set; }
    }
    [XmlRoot(ElementName = "Link")]
    public class Link
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Reference")]
        public string Reference { get; set; }
        [XmlAttribute(AttributeName = "Optional")]
        public string Optional { get; set; }
    }
    [XmlRoot(ElementName = "Method")]
    public class Method
    {

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Visibility")]
        public string Visibility { get; set; }
        [XmlAttribute(AttributeName = "Reference")]
        public string Reference { get; set; }
        [XmlAttribute(AttributeName = "VisibleInScript")]
        public string VisibleInScript { get; set; }
        [XmlAttribute(AttributeName = "Precompile")]
        public string Precompile { get; set; }
    }
    [XmlRoot(ElementName = "Methods")]
    public class Methods
    {

        [XmlElement(ElementName = "Method")]
        public List<Method> Method { get; set; }
    }

    #endregion

}
