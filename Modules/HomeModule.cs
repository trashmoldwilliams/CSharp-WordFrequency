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
    Get["/"] = _ => View["index.cshtml"];
    }
  }
}
