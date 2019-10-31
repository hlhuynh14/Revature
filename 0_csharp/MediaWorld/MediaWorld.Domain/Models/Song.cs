using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public class Song : AAudio
  {
    public Song()
    {
      Initialize();
    }

    private void Initialize(string title="Untitled", TimeSpan duration=new TimeSpan(), int bitRate=256)
    {
      Title = title;
      Duration = duration;
      BitRate = bitRate;
    }
  }
}
