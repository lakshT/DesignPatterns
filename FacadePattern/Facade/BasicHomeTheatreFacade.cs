using FacadePattern.Components;

namespace FacadePattern.Facade
{
    public class BasicHomeTheatreFacade
    {
        Projector projector;
        SoundBar soundBar;
        PopcornMaker popcornMaker;

        public BasicHomeTheatreFacade(Projector projector, SoundBar soundBar, PopcornMaker popcornMaker)
        {
            this.projector = projector;
            this.soundBar = soundBar;
            this.popcornMaker = popcornMaker;
        }

        public void WatchMovie()
        {
            projector.TurnOn();
            soundBar.TurnOn();
            soundBar.SetVolume(70);
            popcornMaker.TurnOn();
            popcornMaker.MakePopcorn();
        }

        public void EndMovie()
        {
            projector.TurnOff();
            soundBar.TurnOff();
            popcornMaker.TurnOff();
        }
    }
}
