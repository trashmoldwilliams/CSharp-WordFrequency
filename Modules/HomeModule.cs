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
        return View["index.cshtml"];
      };

      Post["/results"] = _ =>
      {
        return View["results.cshtml", RepeatCounter.CountRepeats(Request.Form["phrase"], Request.Form["word"])];
      };
    }
  }
}
