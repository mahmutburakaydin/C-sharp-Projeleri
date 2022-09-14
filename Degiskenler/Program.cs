namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = 5;            //1 byte
            sbyte sb = 5;          //1 byte

            short s = 5;           //2 byte
            ushort us = 5;         //2 byte

            int i = 5;             //4 byte
            Int16 i16 = 5;         //2 byte
            Int32 i32 = 5;         //4 byte
            Int64 i64 = 5;         //8 byte
            uint ui = 5;           //4 byte

            long l = 5;            //8 byte
            ulong ul = 5;          //8 byte

            float f = 5;           //4 byte
            double d = 5;          //8 byte
            decimal dc = 5;        //16 byte

            char ch = 'c';         //2 byte
            string str = "ac";     //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "a";
            object o2 = 'c';
            object o3 = 2;
            object o4 = 4.2;

            //string ifadeler 

            string str1 = string.Empty;
            str1 = "Mahmut Burak Aydın";
            string ad = "Mahmut Burak";
            string soyad = "Aydın";
            string isim = ad+" "+soyad;


            //integer tanımlama çeşitleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1*integer2;


            //boolean

            bool bl1 = 10>3;

            // Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeni_deger = str20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // çıktı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // çıktı40

            int int22 = int20+ int.Parse(str20); // çıktı 40

            // Datetime

            string Datetim = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(Datetime);

            string Datetime2 = Datetime2.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(Datetime2);

            //saat

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine("hour");
        }
    }
}