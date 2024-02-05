using System.Diagnostics.Metrics;
using System.Reflection;
/*
Task<int>.Run(() => MinMetode(50)).ContinueWith(t => { Console.WriteLine(t.Result); });
Task<int>.Run(() => MinMetode(40)).ContinueWith(t => { Console.WriteLine(t.Result); });
Task<int>.Run(() => MinMetode(30)).ContinueWith(t => { Console.WriteLine(t.Result); });
Task<int>.Run(() => MinMetode(20)).ContinueWith(t => { Console.WriteLine(t.Result); });
Task<int>.Run(() => MinMetode(10)).ContinueWith(t => { Console.WriteLine(t.Result); });
*/
Task<int> t1 = Task<int>.Run(() => { return MinMetode(10); });
Task<int> t2 = Task<int>.Run(() => { return MinMetode(20); });
Task<int> t3 = Task<int>.Run(() => { return MinMetode(30); });
Task<int> t4 = Task<int>.Run(() => { return MinMetode(40); });
Task<int> t5 = Task<int>.Run(() => { return MinMetode(50); });




Task.WaitAll(t1,t2,t3,t4,t5);
//Console.WriteLine("Done");
Console.ReadLine();

int MinMetode(int ta)
{
    int sum = 0;
    for (int i = 0; i <= ta; i++)
    {
        sum += i;

    }
    Thread.Sleep(3000);
    return sum;
}
