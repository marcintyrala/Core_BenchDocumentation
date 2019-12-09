using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Core_BenchDocumentation.Models.BenchModels
{

    [XmlRoot(ElementName = "QuantityConstant")]
    public class QuantityConstant
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "Flag")]
        public string Flag { get; set; }
        [XmlAttribute(AttributeName = "ValueRequired")]
        public string ValueRequired { get; set; }
        [XmlAttribute(AttributeName = "Parameter")]
        public string Parameter { get; set; }
        [XmlAttribute(AttributeName = "ParameterBlock")]
        public string ParameterBlock { get; set; }
        [XmlAttribute(AttributeName = "FilterType")]
        public string FilterType { get; set; }
        [XmlAttribute(AttributeName = "DefaultValue")]
        public string DefaultValue { get; set; }
        [XmlAttribute(AttributeName = "ConstantType")]
        public string ConstantType { get; set; }
        [XmlAttribute(AttributeName = "Format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "Min")]
        public string Min { get; set; }
        [XmlAttribute(AttributeName = "Max")]
        public string Max { get; set; }
        [XmlAttribute(AttributeName = "Unit")]
        public string Unit { get; set; }
    }

    [XmlRoot(ElementName = "Scaling")]
    public class Scaling
    {
        [XmlAttribute(AttributeName = "ScalingType")]
        public string ScalingType { get; set; }
        [XmlAttribute(AttributeName = "a")]
        public string A { get; set; }
        [XmlAttribute(AttributeName = "b")]
        public string B { get; set; }
    }

    [XmlRoot(ElementName = "QuantityMeasurement")]
    public class QuantityMeasurement
    {
        [XmlElement(ElementName = "Scaling")]
        public Scaling Scaling { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "Flag")]
        public string Flag { get; set; }
        [XmlAttribute(AttributeName = "ValueRequired")]
        public string ValueRequired { get; set; }
        [XmlAttribute(AttributeName = "Parameter")]
        public string Parameter { get; set; }
        [XmlAttribute(AttributeName = "ParameterBlock")]
        public string ParameterBlock { get; set; }
        [XmlAttribute(AttributeName = "FilterType")]
        public string FilterType { get; set; }
        [XmlAttribute(AttributeName = "FilterParam")]
        public string FilterParam { get; set; }
        [XmlAttribute(AttributeName = "ChannelGroupsMask")]
        public string ChannelGroupsMask { get; set; }
        [XmlAttribute(AttributeName = "Format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "Min")]
        public string Min { get; set; }
        [XmlAttribute(AttributeName = "Max")]
        public string Max { get; set; }
        [XmlAttribute(AttributeName = "Unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "Frequency")]
        public string Frequency { get; set; }
        [XmlAttribute(AttributeName = "PhysicalChannel")]
        public string PhysicalChannel { get; set; }
        [XmlAttribute(AttributeName = "SaveInSimpleContext")]
        public string SaveInSimpleContext { get; set; }
        [XmlAttribute(AttributeName = "DefaultValue")]
        public string DefaultValue { get; set; }
        [XmlAttribute(AttributeName = "Persistent")]
        public string Persistent { get; set; }
        [XmlAttribute(AttributeName = "RestoreValue")]
        public string RestoreValue { get; set; }
    }

    [XmlRoot(ElementName = "QuantityString")]
    public class QuantityString
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "Flag")]
        public string Flag { get; set; }
        [XmlAttribute(AttributeName = "ValueRequired")]
        public string ValueRequired { get; set; }
        [XmlAttribute(AttributeName = "Parameter")]
        public string Parameter { get; set; }
        [XmlAttribute(AttributeName = "ParameterBlock")]
        public string ParameterBlock { get; set; }
        [XmlAttribute(AttributeName = "FilterType")]
        public string FilterType { get; set; }
        [XmlAttribute(AttributeName = "FilterParam")]
        public string FilterParam { get; set; }
        [XmlAttribute(AttributeName = "DefaultValue")]
        public string DefaultValue { get; set; }
        [XmlAttribute(AttributeName = "Min")]
        public string Min { get; set; }
        [XmlAttribute(AttributeName = "Max")]
        public string Max { get; set; }
        [XmlAttribute(AttributeName = "ChannelGroupsMask")]
        public string ChannelGroupsMask { get; set; }
        [XmlAttribute(AttributeName = "PhysicalChannel")]
        public string PhysicalChannel { get; set; }
        [XmlAttribute(AttributeName = "Persistent")]
        public string Persistent { get; set; }
    }

    [XmlRoot(ElementName = "QuantityTable")]
    public class QuantityTable
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "Flag")]
        public string Flag { get; set; }
        [XmlAttribute(AttributeName = "ValueRequired")]
        public string ValueRequired { get; set; }
        [XmlAttribute(AttributeName = "Parameter")]
        public string Parameter { get; set; }
        [XmlAttribute(AttributeName = "ParameterBlock")]
        public string ParameterBlock { get; set; }
        [XmlAttribute(AttributeName = "FilterType")]
        public string FilterType { get; set; }
        [XmlAttribute(AttributeName = "TypeOfInit")]
        public string TypeOfInit { get; set; }
        [XmlAttribute(AttributeName = "MaxLine")]
        public string MaxLine { get; set; }
        [XmlAttribute(AttributeName = "MaxColumn")]
        public string MaxColumn { get; set; }
        [XmlAttribute(AttributeName = "InitValue")]
        public string InitValue { get; set; }
        [XmlAttribute(AttributeName = "InitFile")]
        public string InitFile { get; set; }
        [XmlAttribute(AttributeName = "PhysicalChannel")]
        public string PhysicalChannel { get; set; }
        [XmlAttribute(AttributeName = "Persistent")]
        public string Persistent { get; set; }
    }

    [XmlRoot(ElementName = "QuantityFormula")]
    public class QuantityFormula
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "Flag")]
        public string Flag { get; set; }
        [XmlAttribute(AttributeName = "ValueRequired")]
        public string ValueRequired { get; set; }
        [XmlAttribute(AttributeName = "Parameter")]
        public string Parameter { get; set; }
        [XmlAttribute(AttributeName = "ParameterBlock")]
        public string ParameterBlock { get; set; }
        [XmlAttribute(AttributeName = "ChannelGroupsMask")]
        public string ChannelGroupsMask { get; set; }
        [XmlAttribute(AttributeName = "Format")]
        public string Format { get; set; }
        [XmlAttribute(AttributeName = "Min")]
        public string Min { get; set; }
        [XmlAttribute(AttributeName = "Max")]
        public string Max { get; set; }
        [XmlAttribute(AttributeName = "Unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "Frequency")]
        public string Frequency { get; set; }
        [XmlAttribute(AttributeName = "CheckAntiAliasing")]
        public string CheckAntiAliasing { get; set; }
        [XmlAttribute(AttributeName = "UnknownQuantityInFormula")]
        public string UnknownQuantityInFormula { get; set; }
        [XmlAttribute(AttributeName = "FormulaString")]
        public string FormulaString { get; set; }
    }

    [XmlRoot(ElementName = "QuantityReference")]
    public class QuantityReference
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "Flag")]
        public string Flag { get; set; }
        [XmlAttribute(AttributeName = "ValueRequired")]
        public string ValueRequired { get; set; }
        [XmlAttribute(AttributeName = "Parameter")]
        public string Parameter { get; set; }
        [XmlAttribute(AttributeName = "ParameterBlock")]
        public string ParameterBlock { get; set; }
        [XmlAttribute(AttributeName = "RestoreValue")]
        public string RestoreValue { get; set; }
        [XmlAttribute(AttributeName = "FilterType")]
        public string FilterType { get; set; }
        [XmlAttribute(AttributeName = "FilterParam")]
        public string FilterParam { get; set; }
        [XmlAttribute(AttributeName = "Unit")]
        public string Unit { get; set; }
        [XmlAttribute(AttributeName = "ChannelGroupsMask")]
        public string ChannelGroupsMask { get; set; }
        [XmlAttribute(AttributeName = "DefaultValue")]
        public string DefaultValue { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "ReadOnly")]
        public string ReadOnly { get; set; }
        [XmlAttribute(AttributeName = "UnknownReferencedChannel")]
        public string UnknownReferencedChannel { get; set; }
        [XmlAttribute(AttributeName = "SavedInContext")]
        public string SavedInContext { get; set; }
    }

    [XmlRoot(ElementName = "List")]
    public class List
    {
        [XmlElement(ElementName = "QuantityConstant")]
        public List<QuantityConstant> QuantityConstant { get; set; }
        [XmlElement(ElementName = "QuantityMeasurement")]
        public List<QuantityMeasurement> QuantityMeasurement { get; set; }
        [XmlElement(ElementName = "QuantityString")]
        public List<QuantityString> QuantityString { get; set; }
        [XmlElement(ElementName = "QuantityTable")]
        public List<QuantityTable> QuantityTable { get; set; }
        [XmlElement(ElementName = "QuantityFormula")]
        public List<QuantityFormula> QuantityFormula { get; set; }
        [XmlElement(ElementName = "QuantityReference")]
        public List<QuantityReference> QuantityReference { get; set; }
    }

    [XmlRoot(ElementName = "Quantities")]
    public class Quantities
    {
        [XmlElement(ElementName = "List")]
        public List List { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "UnitCheck")]
        public string UnitCheck { get; set; }
        [XmlAttribute(AttributeName = "FileVersion")]
        public string FileVersion { get; set; }
    }

}
