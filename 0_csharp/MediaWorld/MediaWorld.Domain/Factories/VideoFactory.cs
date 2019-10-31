using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Factories
{
  public class VideoFactory : IVideoFactory
  {
    public AVideo Create<T>() where T : AVideo, new() 
    {
      return new T();
    }
  }
}
