using System;

namespace BayonettaSE.Utils.Hex
{
    public struct HexDataInfo
    {
        public int Offset { get; set; }
        public int Size { get; set; }
        public Func<int, int> ToSaveFileValue { get; set; }
        public Func<int, int> ToHumanReadableValue { get; set; }
    }
}