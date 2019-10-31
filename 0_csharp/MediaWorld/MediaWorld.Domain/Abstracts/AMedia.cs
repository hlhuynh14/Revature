using System;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Abstracts
{
  public abstract class AMedia : IControl
  {
    public string Title { get; set; }
    public TimeSpan Duration { get; set; }

    public abstract bool Forward();

    public virtual bool Pause()
    {
      throw new System.NotImplementedException();
    }

    public virtual bool Play()
    {
      throw new System.NotImplementedException();
    }

    public abstract bool Rewind();

    public bool Stop()
    {
      throw new System.NotImplementedException();
    }

    public override string ToString()
    {
      return $"{this}";
    }
  }
}
