

namespace listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<string> listaAlumnos = new List<string>();

            listaAlumnos.Add("yiyi");
            listaAlumnos.Add("yaya");
            listaAlumnos.Add("yoyo");

            List<string> listaAlumnos2 = new List<string>()
            {
                "yey",
                "yuyu",
                "yeye"
            };

            foreach (string a in listaAlumnos)
            {
                Console.WriteLine(a);
            }
            listaAlumnos.RemoveAt(1);
            listaAlumnos.Insert(1, "yayiu");
            Console.WriteLine();

            foreach (string a2 in listaAlumnos)
            {
                Console.WriteLine(a2);
            }
            Console.WriteLine();
            for (int i = 0; i < listaAlumnos2.Count;i++)
            {
                Console.WriteLine(listaAlumnos2[i]);
            }




        }
    }
}
