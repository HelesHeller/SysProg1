using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace SysProg1
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, String s, String c, uint m);
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////
            MessageBox(new IntPtr(0), "Здесь содержится информация о соискателе:\nперейти на следующую страницу", "Резюме", 0);
            MessageBox(new IntPtr(0), "Белянский Дмитрий Антонович\n11.12.1999\nг. Одесса", "Резюме", 0);
            MessageBox(new IntPtr(0), "Закончить просмотр?", "Резюме", 0);

            ///////////////////////////////////////////////////////////////////////////////////
            Random rand = new Random();
            while (MessageBox(new IntPtr(0), $"{rand.Next(1, 101)}", "Вы загадали это число?", 1) != 1 ? true : false) ;
        }
    }
}
