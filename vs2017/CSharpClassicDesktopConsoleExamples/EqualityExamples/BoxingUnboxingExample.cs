using System;

namespace CSharpClassicDesktopConsoleExamples.EqualityExamples
{
    public class BoxingUnboxingExample : IExample
    {
        public void DoExample()
        {
            object objInt1 = 10;
            object objInt2 = 10;

            Console.WriteLine();
            Console.WriteLine("================================================================");
            Console.WriteLine("Comparing boxed object values.");
            Console.WriteLine("================================================================");

            Type t1 = objInt1.GetType();
            Type t2 = objInt2.GetType();

            if (t1 == t2)
            {
                Console.WriteLine("objInt1 and objInt2 are the same type.");
                if (t1.IsPrimitive == true)
                {
                    if (ComparePrimitiveValue(objInt1, objInt2) == true)
                    {
                        Console.WriteLine("objInt1 and objInt2 are the same value.");
                    }
                    else
                    {
                        Console.WriteLine("objInt1 and objInt2 are NOT the same value.");
                    }

                    string str1 = Convert.ToString(objInt1);
                    string str2 = Convert.ToString(objInt2);
                    if (str1 == str2)
                    {
                        Console.WriteLine("objInt1 and objInt2 are the same value.");
                    }
                    else
                    {
                        Console.WriteLine("objInt1 and objInt2 are NOT the same value.");
                    }
                }
            }
            else
            {
                Console.WriteLine("objInt1 and objInt2 are NOT the same type.");
            }
            
            object objFloat1 = 10.0;
            Type t3 = objFloat1.GetType();
            if (t1 == t3)
            {
                Console.WriteLine("objInt1 and objFloat1 are the same type.");
            }
            else
            {
                Console.WriteLine("objInt1 and objFloat1 are NOT the same type.");
            }

            Console.WriteLine();
        }

        private bool ComparePrimitiveValue(object obj1, object obj2)
        {
            IConvertible ic = obj1 as IConvertible;
            switch (ic.GetTypeCode())
            {
                case TypeCode.Boolean:
                    return ((bool)obj1 == (bool)obj2);

                case TypeCode.Byte:
                    return ((byte)obj1 == (byte)obj2);

                case TypeCode.Char:
                    return ((char)obj1 == (char)obj2);

                case TypeCode.DateTime:
                    return ((DateTime)obj1 == (DateTime)obj2);

                //case TypeCode.DBNull:

                case TypeCode.Decimal:
                    return ((decimal)obj1 == (decimal)obj2);

                case TypeCode.Double:
                    return ((double)obj1 == (double)obj2);

                case TypeCode.Int16:
                    return ((Int16)obj1 == (Int16)obj2);

                case TypeCode.Int32:
                    return ((Int32)obj1 == (Int32)obj2);

                case TypeCode.Int64:
                    return ((Int64)obj1 == (Int64)obj2);

                case TypeCode.SByte:
                    return ((sbyte)obj1 == (sbyte)obj2);

                case TypeCode.Single:
                    return ((float)obj1 == (float)obj2);

                case TypeCode.String:
                    return ((string)obj1 == (string)obj2);

                case TypeCode.UInt16:
                    return ((UInt16)obj1 == (UInt16)obj2);

                case TypeCode.UInt32:
                    return ((UInt32)obj1 == (UInt32)obj2);

                case TypeCode.UInt64:
                    return ((UInt64)obj1 == (UInt64)obj2);
            }

            return false;
        }
    }
}
