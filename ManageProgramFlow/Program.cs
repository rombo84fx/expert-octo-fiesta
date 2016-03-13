using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManageProgramFlow
{
    class Program
    {
        #region Thread Class
        //public static void ThreadMethod(object o)
        //{
        //    for (int i = 0; i < (int)o; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    bool stopped = false;

        //    Thread t = new Thread(new ThreadStart(() =>
        //    {
        //        while (!stopped)
        //        {
        //            Console.WriteLine("Running...");
        //            Thread.Sleep(1000);
        //        }
        //    }));

        //    t.Start();
        //    Console.WriteLine("Press any key to exit");
        //    Console.ReadKey();
        //    stopped = true;
        //    t.Join();
        //}

        //[ThreadStatic]
        //public static int _field;

        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread A: {0}", _field);
        //        }
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            _field++;
        //            Console.WriteLine("Thread B: {0}", _field);
        //        }
        //    }).Start();

        //    Console.ReadKey();
        //}

        //public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        //{
        //    return Thread.CurrentThread.ManagedThreadId;
        //});

        //public static void Main()
        //{
        //    new Thread(() =>
        //    {
        //        for (int i = 0; i < _field.Value; i++)
        //        {
        //            Console.WriteLine("Thread A: {0}", i);
        //        }
        //    }).Start();

        //    new Thread(() =>
        //    {
        //        for (int i = 0; i < _field.Value; i++)
        //        {
        //            Console.WriteLine("Thread B: {0}", i);
        //        }
        //    }).Start();

        //    Console.ReadKey();
        //}
        #endregion

        #region ThreadPool Class
        ////public static void Main()
        ////{
        ////    ThreadPool.QueueUserWorkItem((s) =>
        ////    {
        ////        Console.WriteLine("Working on a thread from threadpool");
        ////    });
        ////    Console.ReadLine();
        ////}
        #endregion

        #region Task
        //public static void Main()
        //{
        //    Task t = Task.Run(() =>
        //    {
        //        for (int i = 0; i < 100; i++)
        //        {
        //            Console.Write("*");
        //        }
        //    });

        //    t.Wait();
        //}
        #endregion

        #region Task<T>
        //public static void Main()
        //{
        //    Task<int> t = Task.Run(() =>
        //    {
        //        return 42;
        //    });

        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Canceled");
        //    }, TaskContinuationOptions.OnlyOnCanceled);

        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Faulted");
        //    }, TaskContinuationOptions.OnlyOnFaulted);

        //    var completedTask = t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("Completed");
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);

        //    completedTask.Wait();
        //}
        #endregion

        #region Child Tasks
        //public static void Main()
        //{
        //    Task<Int32[]> parent = Task.Run(() =>
        //    {
        //        var results = new Int32[3];
        //        new Task(() => results[0] = 0,
        //            TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => results[1] = 1,
        //            TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => results[2] = 2,
        //            TaskCreationOptions.AttachedToParent).Start();

        //        return results;
        //    });

        //    var finalTask = parent.ContinueWith(
        //        parentTask =>
        //        {
        //            foreach (var i in parentTask.Result)
        //            {
        //                Console.WriteLine(i);
        //            }
        //        });

        //    finalTask.Wait();
        //}
        #endregion

        #region Task Factory
        //public static void Main()
        //{
        //    Task<Int32[]> parent = Task.Run(() =>
        //    {
        //        var results = new Int32[3];

        //        TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
        //            TaskContinuationOptions.ExecuteSynchronously);

        //        tf.StartNew(() => results[0] = 0);
        //        tf.StartNew(() => results[1] = 1);
        //        tf.StartNew(() => results[2] = 2);

        //        return results;
        //    });

        //    var finalTask = parent.ContinueWith((parentTask) =>
        //    {
        //        foreach (var i in parentTask.Result)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });

        //    finalTask.Wait();
        //}
        #endregion

        #region Task.WaitAll
        //public static void Main()
        //{
        //    Task[] tasks = new Task[3];

        //    tasks[0] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("1");
        //        return 1;
        //    });

        //    tasks[1] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("2");
        //        return 2;
        //    });

        //    tasks[2] = Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("3");
        //        return 3;
        //    });

        //    Task.WaitAll(tasks);
        //}
        #endregion

        #region TaskWaitAny
        //public static void Main()
        //{
        //    Task<int>[] tasks = new Task<int>[3];

        //    tasks[0] = Task.Run(() => { Thread.Sleep(1000); return 1; });
        //    tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
        //    tasks[2] = Task.Run(() => { Thread.Sleep(1000); return 3; });

        //    while (tasks.Length > 0)
        //    {
        //        int i = Task.WaitAny(tasks);
        //        Task<int> completedTask = tasks[i];

        //        Console.WriteLine(completedTask.Result);

        //        var temp = tasks.ToList();
        //        temp.RemoveAt(i);
        //        tasks = temp.ToArray();
        //    }
        //}
        #endregion

        #region Parallel Class
        //public static void Main()
        //{
        //    Parallel.For(0, 10, i =>
        //    {
        //        Thread.Sleep(1000);
        //    });

        //    var numbers = Enumerable.Range(0, 10);
        //    Parallel.ForEach(numbers, i =>
        //    {
        //        Thread.Sleep(1000);
        //    });

        //    ParallelLoopResult result = Parallel.
        //        For(0, 1000, (int i, ParallelLoopState loopState) =>
        //        {
        //            if (i == 500)
        //            {
        //                Console.WriteLine("Breaking loop");
        //                loopState.Break();
        //            }
        //            return;
        //        });
        //}
        #endregion

        #region async and await
        //public static void Main()
        //{
        //    string result = DownloadContent().Result;
        //    Console.WriteLine(result);
        //}

        //public static async Task<string> DownloadContent()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        string result = await client.GetStringAsync("http://www.microsoft.com");
        //        return result;
        //    }
        //}
        #endregion

        #region Scalability versus responsiveness
        //public Task SleepAsyncA(int millisecondsTimeout)
        //{
        //    return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        //}

        //public Task SleepAsyncB(int millisecondsTimeout)
        //{
        //    TaskCompletionSource<bool> tcs = null;
        //    var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
        //    tcs = new TaskCompletionSource<bool>(t);
        //    t.Change(millisecondsTimeout, -1);
        //    return tcs.Task;
        //}
        #endregion

        #region Parallel query
        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 10);
        //    var parallelResult = numbers.AsParallel().AsOrdered()
        //        .Where(i => i % 2 == 0)
        //        .ToArray();

        //    foreach (int i in parallelResult)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region Making a parallel query sequential
        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 20);

        //    var parallelResult = numbers.AsParallel().AsOrdered()
        //        .Where(i => i % 2 == 0).AsSequential();

        //    foreach (int i in parallelResult.Take(5))
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region Using For All
        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 20);

        //    var parallelResult = numbers.AsParallel()
        //        .Where(i => i % 2 == 0);

        //    parallelResult.ForAll(i => Console.WriteLine(i));
        //}
        #endregion

        #region Catching Aggregate Exception
        //public static void Main()
        //{
        //    var numbers = Enumerable.Range(0, 20);

        //    try
        //    {
        //        var parallelResult = numbers.AsParallel()
        //            .Where(i => IsEven(i));

        //        parallelResult.ForAll(e => Console.WriteLine(e));
        //    }
        //    catch (AggregateException e)
        //    {
        //        Console.WriteLine("There were {0} exceptions",
        //            e.InnerExceptions.Count);
        //    }
        //}

        //public static bool IsEven(int i)
        //{
        //    if (i % 10 == 0)
        //    {
        //        throw new ArgumentException("i");
        //    }
        //    return i % 2 == 0;
        //}
        #endregion

        #region Using BlockingCollection<T>, Using GetConsumingEnumerable
        //public static void Main()
        //{
        //    BlockingCollection<string> col = new BlockingCollection<string>();
        //    Task read = Task.Run(() =>
        //    {
        //        foreach (var s in col.GetConsumingEnumerable())
        //        {
        //            Console.WriteLine(s);
        //        }
        //    });

        //    Task write = Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            string s = Console.ReadLine();
        //            if (string.IsNullOrWhiteSpace(s))
        //            {
        //                break;
        //            }
        //            col.Add(s);
        //        }
        //    });

        //    write.Wait();
        //}
        #endregion

        #region Using a ConcurrentBag
        //static void Main(string[] args)
        //{
        //    ConcurrentBag<int> bag = new ConcurrentBag<int>();

        //    bag.Add(42);
        //    bag.Add(21);

        //    int result;

        //    if (bag.TryTake(out result))
        //    {
        //        Console.WriteLine(result);
        //    }

        //    if (bag.TryPeek(out result))
        //    {
        //        Console.WriteLine("There is a next item: {0}", result);
        //    }
        //}
        #endregion

        #region Enumerating a ConcurrentBag
        //static void Main(string[] args)
        //{
        //    ConcurrentBag<int> bag = new ConcurrentBag<int>();
        //    Task.Run(() =>
        //    {
        //        bag.Add(42);
        //        Thread.Sleep(1000);
        //        bag.Add(21);
        //    });

        //    Task.Run(() =>
        //    {
        //        foreach (int i in bag)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }).Wait();
        //}
        #endregion

        #region Using a ConcurrentStack
        //static void Main(string[] args)
        //{
        //    ConcurrentStack<int> stack = new ConcurrentStack<int>();

        //    stack.Push(42);

        //    int result;
        //    if (stack.TryPop(out result))
        //    {
        //        Console.WriteLine("Popped: {0}", result);
        //    }

        //    stack.PushRange(new int[] { 1, 2, 3 });

        //    int[] values = new int[2];
        //    stack.TryPopRange(values);

        //    foreach (int i in values)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region Using ConcurrentQueue
        //static void Main(string[] args)
        //{
        //    ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
        //    queue.Enqueue(42);

        //    int result;
        //    if (queue.TryDequeue(out result))
        //    {
        //        Console.WriteLine("Dequeued: {0}", result);
        //    }
        //}
        #endregion

        #region Using a ConcurrentDictionary
        //static void Main(string[] args)
        //{
        //    var dict = new ConcurrentDictionary<string, int>();
        //    if (dict.TryAdd("k1", 42))
        //    {
        //        Console.WriteLine("Added");
        //    }

        //    if (dict.TryUpdate("k1", 21, 42))
        //    {
        //        Console.WriteLine("42 updated to 21");
        //    }

        //    dict["k1"] = 42;

        //    int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
        //    int r2 = dict.GetOrAdd("k2", 3);
        //}
        #endregion
    }
}

