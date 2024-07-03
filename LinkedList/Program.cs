namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model.LinkedList<int> list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.AppendHead(12);
            list.Clear();
            list.InsertAfter(2, 14);
            foreach (var i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
