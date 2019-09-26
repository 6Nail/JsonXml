using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject.Example01
{
  class Earthquare
  {
    public int Id { get; set; }
    Discription Discription { get; set; }
    Origin Origin { get; set; }
    OriginUncertainty originUncertainty { get; set; }
    Quality Quality { get; set; }
    CreationInfo CreationInfo { get; set; }
    Magnitude Magnitude { get; set; }
    Event Event { get; set; }

  }
}
