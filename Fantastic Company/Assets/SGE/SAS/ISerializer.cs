using UnityEngine;
using System.Collections;

namespace SGE
{
    namespace SAS
    {
        public interface ISerializer
        {
            byte AddByte(string name, byte b);
            sbyte AddSbyte(string name, sbyte s);
            short AddShort(string name, short s);
            ushort AddUShort(string name, ushort u);
            int AddInt(string name, int i);
            uint AddUInt(string name, uint u);
            long AddLong(string name, long l);
            ulong AddULong(string name, ulong u);
            float AddFloat(string name, float f);
            double AddDouble(string name, double d);
            decimal AddDecimal(string name, decimal d);
            char AddChar(string name, char c);
            T[] AddArray<T>(string name, T[] array);
            T Add<T>(string name, T obj);


        }
    }
}