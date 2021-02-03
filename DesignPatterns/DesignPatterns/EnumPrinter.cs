using System;

namespace DesignPatterns
{
    public static class EnumPrinter
    {
        public static void EnumerateEnumToString(Type enumType)
        {
            foreach (int currentEnum in Enum.GetValues(enumType))
                Console.WriteLine($"{currentEnum} - {Enum.GetName(enumType, currentEnum)}");
        }
    }
}
