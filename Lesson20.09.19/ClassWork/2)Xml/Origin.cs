using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject.Example01
{
  public class Origin
  {
    public Time Time { get; set; }
    public Longitude Longitude { get; set; }
    public Latitude Latitude { get; set; }
    public Depth Depth { get; set; }
    public OriginUncertainty OriginUncertainty { get; set; }
    public Quality Quality { get; set; }
    public string EvaluationMode { get; set; }
    public CreationInfo CreationInfo { get; set; }
    public string Datasource { get; set; }
    public string Dataid { get; set; }
    public string Eventsource { get; set; }
    public string Eventid { get; set; }
    public string PublicID { get; set; }
  }
}
