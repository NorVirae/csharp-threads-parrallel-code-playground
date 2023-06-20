// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;


public class LetsThreadIt
{
    public static void ThreadProcess()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("ThreadProcL {0}, ThreadProc {1}", i, i+1);

            Thread.Sleep(1000);

        }
    }


    public static void Main()
    {
        int actionCount = 0;
        bool continueRunning = true;
        Thread runThread = new Thread(new ThreadStart(ThreadProcess));

        runThread.Start();


        while (continueRunning)
        {
            Console.WriteLine("Action count: {0}", actionCount);

            actionCount++;
            Thread.Sleep(1000);
            if(actionCount > 10)
            {
                break;
            }
        }

        Console.WriteLine("Thread is about to be Terminated");
        runThread.Join();
        continueRunning  = false;
        Console.WriteLine("Thread Terminated");

    }

}