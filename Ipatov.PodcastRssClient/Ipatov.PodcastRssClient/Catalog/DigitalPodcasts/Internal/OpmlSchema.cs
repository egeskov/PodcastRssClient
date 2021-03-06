﻿// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 

// ReSharper disable InconsistentNaming
namespace Ipatov.PodcastRssClient.Catalog.DigitalPodcasts.Internal
{
    using System.Xml.Serialization;

    [XmlRoot("opml")]
    public class OPML
    {
        [XmlAttribute]
        public string version { get; set; }

        [XmlElement]
        public OPMLhead head { get; set; }

        [XmlArray("body")]
        [XmlArrayItem("outline")]
        public OPMLoutline[] body { get; set; }
    }

    public class OPMLhead
    {
        [XmlElement]
        public string title { get; set; }

        [XmlElement]
        public string dateCreated { get; set; }

        [XmlElement]
        public string dateModified { get; set; }

        [XmlElement]
        public string ownerName { get; set; }

        [XmlElement]
        public string ownerEmail { get; set; }

        [XmlElement("format", Namespace = "http://www.digitalpodcast.com/podcastsearchservice/output_specs.html")]
        public string format { get; set; }

        [XmlElement("totalResults", Namespace = "http://www.digitalpodcast.com/podcastsearchservice/output_specs.html")]
        public int totalResults { get; set; }

        [XmlElement("startIndex", Namespace = "http://www.digitalpodcast.com/podcastsearchservice/output_specs.html")]
        public int startIndex { get; set; }

        [XmlElement("itemsPerPage", Namespace = "http://www.digitalpodcast.com/podcastsearchservice/output_specs.html")]
        public int itemsPerPage { get; set; }
    }

    public class OPMLoutline
    {
        [XmlAttribute]
        public string text { get; set; }

        [XmlAttribute]
        public string description { get; set; }

        [XmlAttribute]
        public string xmlUrl { get; set; }

        [XmlAttribute]
        public string htmlUrl { get; set; }
    }
}