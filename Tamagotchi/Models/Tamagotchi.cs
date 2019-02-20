using System;
using System.Collections.Generic;

namespace Tamagotchi.Models {

    public class Tam
    {
      private int _feed;
      private int _play;
      private int _sleep;

      public Tam (int feed, int play, int sleep)
      {
        _feed = feed;
        _play = play;
        _sleep = sleep;
      }

      public int GetFeed()
      {
        return _feed;
      }
      public int GetPlay()
      {
        return _play;
      }
      public int GetSleep()
      {
        return _sleep;
      }

      public void SetFeed(int newFeed)
      {
        _feed = newFeed;
      }

      public void SetPlay(int newPlay)
      {
        _play = newPlay;
      }

      public void SetSleep(int newSleep)
      {
        _sleep = newSleep;
      }

    }
}
