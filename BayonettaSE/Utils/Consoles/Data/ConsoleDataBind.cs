using System.Collections.Generic;
using BayonettaSE.GlobalEnums;
using BayonettaSE.Utils.Data;
using BayonettaSE.Utils.Hex;

namespace BayonettaSE.Utils.Consoles.Data
{
    public class ConsoleDataBind: DataBind // At least Wii U and PS3
    {
        protected override Dictionary<DataType, HexDataInfo> DataBindings { get; set; } = new Dictionary<DataType, HexDataInfo>
        {
            {DataType.Halos, new HexDataInfo {Offset = 0xEF54, Size = 0x4, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Difficulty, new HexDataInfo {Offset = 0x33, Size = 0x4, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Compound_Green, new HexDataInfo {Offset = 0xEF7C, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Compound_Yellow, new HexDataInfo {Offset = 0xEF78, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Compound_Red, new HexDataInfo {Offset = 0xEF80, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Green_Herb, new HexDataInfo {Offset = 0xEF84, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Mega_Green_Herb, new HexDataInfo {Offset = 0xEF88, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Purple_Magic, new HexDataInfo {Offset = 0xEF8C, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Mega_Purple_Magic, new HexDataInfo {Offset = 0xEF90, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Bloody_Rose, new HexDataInfo {Offset = 0xEF94, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Mega_Bloody_Rose, new HexDataInfo {Offset = 0xEF98, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Yellow_Moon, new HexDataInfo {Offset = 0xEF9C, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Mega_Yellow_Moon, new HexDataInfo {Offset = 0xEFA0, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Broken_Heart, new HexDataInfo {Offset = 0xEFA4, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Broken_Pearl, new HexDataInfo {Offset = 0xEFA8, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Arcade_Bullet, new HexDataInfo {Offset = 0xEFAC, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},
            {DataType.Red_Hot_Shot, new HexDataInfo {Offset = 0xEFB0, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}},  
            {DataType.Magic_Flute, new HexDataInfo {Offset = 0xEFB4, Size = 0x2, ToSaveFileValue = FieldConversions.FromSimpleDecimal, ToHumanReadableValue = FieldConversions.ToSimpleDecimal}}
        };
    }
}