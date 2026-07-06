using System;
using System.Collections.Generic;
using BayonettaSE.GlobalEnums;
using BayonettaSE.Utils.Hex;

namespace BayonettaSE.Utils.Data
{
    public abstract class DataBind
    {
        public HexDataInfo GetDataBinding(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Halos:
                    return DataBindings[DataType.Halos];
                case DataType.Compound_Green:
                    return DataBindings[DataType.Compound_Green];
                case DataType.Compound_Yellow:
                    return DataBindings[DataType.Compound_Yellow];
                case DataType.Compound_Red:
                    return DataBindings[DataType.Compound_Red];
                case DataType.Green_Herb:
                    return DataBindings[DataType.Green_Herb];
                case DataType.Mega_Green_Herb:
                    return DataBindings[DataType.Mega_Green_Herb];
                case DataType.Purple_Magic:
                    return DataBindings[DataType.Purple_Magic];
                case DataType.Mega_Purple_Magic:
                    return DataBindings[DataType.Mega_Purple_Magic];
                case DataType.Bloody_Rose:
                    return DataBindings[DataType.Bloody_Rose];
                case DataType.Mega_Bloody_Rose:
                    return DataBindings[DataType.Mega_Bloody_Rose];
                case DataType.Yellow_Moon:
                    return DataBindings[DataType.Yellow_Moon];
                case DataType.Mega_Yellow_Moon:
                    return DataBindings[DataType.Mega_Yellow_Moon];
                case DataType.Broken_Heart:
                    return DataBindings[DataType.Broken_Heart];
                case DataType.Broken_Pearl:
                    return DataBindings[DataType.Broken_Pearl];
                case DataType.Arcade_Bullet:
                    return DataBindings[DataType.Arcade_Bullet];
                case DataType.Red_Hot_Shot:
                    return DataBindings[DataType.Red_Hot_Shot];
                case DataType.Magic_Flute:
                    return DataBindings[DataType.Magic_Flute];
                default:
                    throw new ArgumentOutOfRangeException(nameof(dataType), dataType, null);
            }
            throw new KeyNotFoundException($"Data binding for {dataType} not found.");
        }
        
        // abstract Dictionary<DataType, HexDataInfo> DataBindings;
        protected abstract Dictionary<DataType, HexDataInfo> DataBindings { get; set; }
    }
}