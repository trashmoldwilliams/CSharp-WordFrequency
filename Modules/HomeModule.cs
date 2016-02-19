using Nancy;
using System.Collections.Generic;
using WordFrequencyFinder;
using System;

namespace WordFrequencyFinder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ =>
      {
        int model = 0;
        return View["index.cshtml", model];
      };

      Post["/"] = _ =>
      {
        return View["index.cshtml", RepeatCounter.CountRepeats(Request.Form["phrase"], Request.Form["word"])];
      };
    }
  }
}
