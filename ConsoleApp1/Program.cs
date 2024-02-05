

using System.Diagnostics.Metrics;

Console.WriteLine("App Start");

Task t1 = Task.Factory.StartNew(() => SmartMetode(1, 8000, 1));
Task t2 = Task.Factory.StartNew(() => SmartMetode(2, 5000, 1));
Task t3 = Task.Factory.StartNew(() => SmartMetode(3, 2000, 1));
Task t4 = Task.Factory.StartNew(() => SmartMetode(4, 1100, 1));
Task t5 = Task.Factory.StartNew(() => SmartMetode(5, 1000, 1));

//Task.WaitAll();

t3.Wait();

Console.WriteLine("App end");
//Console.ReadLine();
void SmartMetode(int id, int sleep, int counter)
{
    for (int i = 0; i < counter; i++)
    {
        Thread.Sleep(sleep);
        Console.WriteLine($"Task med id: {id} er færdig");
    }
}




