namespace Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <string> queue = new Queue<string>();

            queue.Enqueue("Pablo");
            queue.Enqueue("Adrian");
            queue.Enqueue("Pedro");

            for (int i = 0; i <= queue.Count+1; i++)
            {
                Console.WriteLine($"El siguiente en la fila es: {queue.Dequeue()}");
            } 

        }
    }
}
