namespace EsercitazionePadel;

public class Lezione6
{
    public string LeggiFile(string path)
    {
        using var stream = new StreamReader(path);
        return stream.ReadToEnd();
    }

    public async Task<string> LeggiFileAsync(string path)
    {
        using var stream = new StreamReader(path);
        await Task.Delay(10000);
        return await stream.ReadToEndAsync();
    }


    //var t1= new Thread(new ThreadStart(FaiQualcosa));
    //t1.Start();
    //var t2 = new Thread(new ThreadStart(FaiQualcosa));
    //t2.Start();
    //var t3 = new Thread(new ThreadStart(FaiQualcosa));
    //t3.Start();


    //Console.WriteLine($"Thread applicazione: {Thread.CurrentThread.ManagedThreadId}");
    //Console.WriteLine(Thread.CurrentThread.IsBackground);
    //for (int i = 0; i < 5; i++)
    //{
    //    ThreadPool.QueueUserWorkItem(new WaitCallback(FaiQualcosa!), total);
    //}




    //var httpRequest = HttpWebRequest.CreateHttp("http://www.google.it");
    //if(httpRequest != null)
    //{
    //    var httpResponse = httpRequest.GetResponse();

    //    if(httpResponse != null)
    //    {
    //        var data = httpResponse.GetResponseStream();
    //        using (var reader = new System.IO.StreamReader(data))
    //        {
    //            var html = reader.ReadToEnd();
    //            Console.WriteLine(html);
    //        }
    //    }
    //}



    //var httpRequest = HttpWebRequest.CreateHttp("http://www.google.it");
    //if(httpRequest != null)
    //{
    //    Task<WebResponse> taskWebResponse = httpRequest.GetResponseAsync();
    //    Task continuation = taskWebResponse.ContinueWith(LeggiResponse,
    //        TaskContinuationOptions.OnlyOnRanToCompletion);

    //    Task.WaitAll(taskWebResponse, continuation);

    //}


    // async await
    //var httpRequest = HttpWebRequest.CreateHttp("http://www.google.it");
    //var responseWeb = await httpRequest.GetResponseAsync();
    //await LeggiResponse2(responseWeb);



    //async Task LeggiResponse2(WebResponse response)
    //{
    //    var data = response.GetResponseStream();
    //    using (var reader = new System.IO.StreamReader(data))
    //    {
    //        var html = reader.ReadToEnd();
    //        Console.WriteLine(html);
    //    }
    //}


    //void LeggiResponse(Task<WebResponse> response){
    //    var data = response.Result.GetResponseStream();
    //    using (var reader = new System.IO.StreamReader(data))
    //    {
    //        var html = reader.ReadToEnd();
    //        Console.WriteLine(html);
    //    }
    //}

    //var lezione6 = new Lezione6();
    //var testo = lezione6.LeggiFile("E:\\costituzione.txt");
    //var testo = await lezione6.LeggiFileAsync("E:\\costituzione.txt");
    //var testo2 = await lezione6.LeggiFileAsync("E:\\prova.json");
    //Console.WriteLine(testo);
    //Console.WriteLine(testo2);


    //Console.WriteLine("Fine esecuzione del programma");


    //void FaiQualcosa2()
    //{
    //    // Thread.Sleep(r.Next(1000, 10000));
    //    var id = Thread.CurrentThread.ManagedThreadId;
    //    Console.WriteLine(Thread.CurrentThread.IsBackground);

    //    // var x = total;
    //    Console.WriteLine($"Ho iniziato a fare qualcosa: {id}");
    //    Thread.Sleep(r.Next(1000,2000));
    //    //  total = x + 1;
    //    Console.WriteLine($"Ho finito di fare qualcosa Thread id: {id}");

    //}

    //void FaiQualcosa(object state)
    //{
    //    var total = (int)state;
    //    // Thread.Sleep(r.Next(1000, 10000));
    //    var id = Thread.CurrentThread.ManagedThreadId;
    //    Console.WriteLine(Thread.CurrentThread.IsBackground);

    //    // var x = total;
    //    Console.WriteLine($"Ho iniziato a fare qualcosa: {id}");
    //    //  Thread.Sleep(r.Next(1000,2000));
    //    //  total = x + 1;
    //    Console.WriteLine($"Ho finito di fare qualcosa Thread id: {id}");

    //}



    //var t1 = new Task(FaiQualcosa2);
    //t1.Start();
    //t1.Wait();

    //var t2 = new Task(() => { Console.WriteLine("Task anonimo t2"); });
    //t2.Start();



    // var t3 = t2.ContinueWith((tx) => Console.WriteLine("Task anonimo t3"));


    //t2.Wait();
    //t3.Wait();

    //Task.WaitAll(t3, t2);


    #region carrello
    class Carrello
    {
        public Carrello()
        {
            // var Prodotti = new List<Prodotto>();
        }
    }
    #endregion

}
