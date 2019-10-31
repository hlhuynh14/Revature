using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Factories;
using MediaWorld.Domain.Models;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storing.Repositories;

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
    private static void Main()
    {
      Play();
    }

    private static void Play()
    {
      var mediaPlayer = MediaPlayerSingleton.Instance;

      foreach (var item in _repository.MediaLibrary)
      {
        mediaPlayer.Execute(item.Play);
      }
    }
  }
}
