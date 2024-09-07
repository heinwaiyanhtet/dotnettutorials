namespace MainProgam
{
    public class CalsCalculator
    {
        
        // With Genrics

        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

     


        // public static bool AreEqual(int value1,int value2)  {
        //     return value1 == value2;
        // }

        // public static bool AreEqual(string value1,string value2) {
        //     return value1 == value2;
        // } 


        // public static bool AreEqual(double value1,double value2) {
        //     return value1 == value2;
        // }

    }
}