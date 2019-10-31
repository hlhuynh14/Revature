using System;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public class Book : AAudio
  {
    public Book()
    {
      Initialize();
    }

    public Book(string title, TimeSpan duration, int frameRate)
    {
      Initialize(title, duration, frameRate);
    }

    private void Initialize(string title="Untitled", TimeSpan duration=new TimeSpan(), int bitRate=256)
    {
      Title = title;
      Duration = duration;
      BitRate = bitRate;
    }
  }
}
