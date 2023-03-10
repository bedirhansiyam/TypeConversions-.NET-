namespace TypeConversions;
class Program
{
    static void Main(string[] args)
    {
        // Implicit Conversion (These conversions are performed by C# in a type-safe manner.)

        byte a = 3;
        sbyte b = 5;
        short c = 10;

        int d = a + b + c; // Performed by C#.

        long h = d;

        float i = h;

        string x = "Patika";
        char y = '.';
        object z = x + y;  //Patika.

        // Explicit Conversion (These conversions are done explicitly by users using the pre-defined functions.)

        int num = 10;
        byte bnum = (byte)num ; // Conversion by user.

        // ToString()
        int num1 = 20, num2 = 23;
        Console.WriteLine(num1 + num2);  // 43
        Console.WriteLine(num1.ToString() + num2.ToString());  // 2023
        
        // Convert Method
        string s1 = "25", s2 = "10";
        int num3 = Convert.ToInt32(s1);
        int num4 = Convert.ToInt32(s2);
        int toplam = num3 + num4;       // 35

        // Parse Method
        string text1 = "48", text2 = "23.11";
        int i1 = Int32.Parse(text1);
        double d1 = Double.Parse(text2);         

    }
}
