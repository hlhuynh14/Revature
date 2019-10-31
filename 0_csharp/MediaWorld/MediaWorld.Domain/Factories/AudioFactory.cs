using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Factories
{
  public class AudioFactory : IAudioFactory
  {
    public AAudio Create<T>() where T : AAudio, new() 
    {
      return new T();
    }
  }
}
