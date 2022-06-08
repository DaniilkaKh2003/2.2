using System;
namespace Sample6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint UDAYS = 0;
            uint DAYS = 0;
            uint[] DAY = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            uint[] VDAY = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            Console.Write("Введите дату по юлианскому календарю (например: 10.07.2003): ");
            var DATA = Console.ReadLine().ToString().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            uint a = Convert.ToUInt32(DATA[0]);
            uint b = Convert.ToUInt32(DATA[1]);
            uint c = Convert.ToUInt32(DATA[2]);
            for (int i = 0; i < c - 1; i++)
            {
                if ((i + 1) % 4 == 0) UDAYS = UDAYS + 366;
                else UDAYS = UDAYS + 365;
            }
            if (c % 4 == 0)
            {
                for (int i = 0; i < b - 1; i++) { UDAYS = UDAYS + VDAY[i]; }
            }
            else { for (int i = 0; i < b - 1; i++) { UDAYS = UDAYS + DAY[i]; } }
            UDAYS = UDAYS + a;
            for (int i = 0; i < c - 1; i++)
            {
                if (((i + 1) % 4 == 0 && (i + 1) % 100 != 0) || ((i + 1) % 400 == 0)) DAYS = DAYS + 366;
                if (((i + 1) % 4 != 0) || ((i + 1) % 100 == 0 && (i + 1) % 400 != 0)) DAYS = DAYS + 365;
            }
            if ((c % 4 == 0 && c % 100 != 0) || (c % 400 == 0))
            {
                for (int i = 0; i < b - 1; i++) { DAYS = DAYS + VDAY[i]; }
            }
            if ((c % 4 != 0) || (c % 100 == 0 && c % 400 != 0))
            {
                for (int i = 0; i < b - 1; i++) { DAYS = DAYS + DAY[i]; }
            }
            DAYS = DAYS + a;
            uint A, B, C;
            uint x = a + UDAYS - DAYS - 2;
            Console.Write("Дата по современному календарю: ");
            if ((c % 4 == 0 && c % 100 != 0) || (c % 400 == 0))
            {
                if (x > VDAY[b - 1])
                {
                    A = x - VDAY[b - 1];
                    B = b + 1;
                    if (B > 12) { B = 1; C = c + 1; }
                    else C = c;
                }
                else { A = x; B = b; C = c; }
                if (A < 10) Console.Write($"0{A}.");
                else Console.Write($"{A}.");
                if (B < 10) Console.Write($"0{B}.");
                else Console.Write($"{B}.");
                if (C < 10) Console.Write($"000{C}\n");
                if (C < 100 && C > 9) Console.Write($"00{C}\n");
                if (C < 1000 && C > 99) Console.Write($"0{C}\n");
                if (C > 999) Console.Write($"{C}\n");
            }
            if ((c % 4 != 0) || (c % 100 == 0 && c % 400 != 0))
            {
                if (x > DAY[b - 1])
                {
                    A = x - DAY[b - 1];
                    B = b + 1;
                    if (B > 12) { B = 1; C = c + 1; }
                    else C = c;
                }
                else { A = x; B = b; C = c; }
                if (A < 10) Console.Write($"0{A}.");
                else Console.Write($"{A}.");
                if (B < 10) Console.Write($"0{B}.");
                else Console.Write($"{B}.");
                if (C < 10) Console.Write($"000{C}\n");
                if (C < 100 && C > 9) Console.Write($"00{C}\n");
                if (C < 1000 && C > 99) Console.Write($"0{C}\n");
                if (C > 999) Console.Write($"{C}\n");
            }
        }
    }
}
