using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject
{
  class Result
  {
    public string WrapperType{ get; set; }
    public string Kind { get; set; }
    public int ArtistId { get; set; }
    public int CollectionId { get; set; }
    public int TrackId { get; set; }
    public string ArtistName { get; set; }
    public string CollectionName  { get; set; }
    public string TrackName { get; set; }
    public string CollectionCensoredName { get; set; }
    public string TrackCensoredName  { get; set; }
    public string ArtistViewUrl { get; set; }
    public string CollectionViewUrl  { get; set; }
    public string TrackViewUrl { get; set; }
    public string previewUrl { get; set; }
    public string artworkUrl30  { get; set; }
    public string artworkUrl60 { get; set; }
    public string artworkUrl100 { get; set; }
    public int collectionPrice { get; set; }
    public int trackPrice { get; set; }
    public DateTime releaseDate { get; set; }
    public string collectionExplicitness { get; set; }
    public string trackExplicitness { get; set; }
    public int discCount { get; set; }
    public int discNumber { get; set; }
    public int trackCount { get; set; }
    public int trackNumber { get; set; }
    public int trackTimeMillis { get; set; }
    public string country { get; set; }
    public string currency { get; set; }
    public string primaryGenreName { get; set; }
    public bool isStreamable { get; set; }
    




  }
}
