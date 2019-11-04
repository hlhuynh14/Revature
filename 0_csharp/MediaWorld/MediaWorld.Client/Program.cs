using System;
using System.Threading;
using System.Threading.Tasks;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Factories;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storing.Repositories;
using Serilog;

namespace MediaWorld.Client
{
  /// <summary>
  /// contains the starting method
  /// </summary>
  internal class Program
  {
    private static MediaRepository _repository = new MediaRepository();
    
    /// <summary>
    /// starts the application
    /// </summary>
    private static async Task Main()
    {
      //(new Program()).ApplicationStart();
      //Play();
      await MagicAsync();
      
      Console.WriteLine("end of code");
      //Thread.Sleep(1000);
      //Log.Warning("end of Main Method");
    }

    private void ApplicationStart()
    {
      Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.Console()
        .WriteTo.File("log.txt")
        .CreateLogger();
    }

    private static void Play()
    {
      Log.Information("Play Method");
      var mediaPlayer = MediaPlayerSingleton.Instance;

      foreach (var item in _repository.MediaLibrary)
      {
        Log.Debug("{@one} {second}", item.Title, item.Duration);
        mediaPlayer.Execute(item.Play, item);
      }
    }

    private static void MagicThread()
    {
      var t1 = new Thread(() => { Run("A"); });
      var t2 = new Thread(() => { t1.Start(); });

      t1.Start();
      t2.Start();

      t1.Join();
      t2.Join();
    }

    private static void MagicTask()
    {
      var t1 = new Task(() => { Run("A"); });
      var t2 = new Task(() => { Run("B"); });

      t1.Start();
      t2.Start();

      Task.WaitAll(new Task[] {t1, t2}, 1000);
    }

    private static async Task MagicAsync()
    {
      await Task.Run(() => { Run("C"); });
      await Task.Run(() => { Run("D"); });
    }

    private static void Run(string s)
    {
        for (var x = 0; x < 1000; x += 1)
        {
          Console.Write(s);
        }
    }
  }
}
