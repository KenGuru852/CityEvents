using Events.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace Events.Models
{
    public class EventParser
    {
        public static ObservableCollection<CityEvent> Parse(string xmlFilePath)
        {
            var AllEvents = new ObservableCollection<CityEvent>();

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            var eventNodes = xmlDoc.SelectNodes("//CityEvent");

            foreach (XmlNode eventNode in eventNodes)
            {
                var cityEvent = new CityEvent();
                cityEvent.Header = eventNode.SelectSingleNode("Header")?.InnerText;
                cityEvent.Description = eventNode.SelectSingleNode("Description")?.InnerText;
                if(cityEvent.Description.Length > 135)
                {
                    cityEvent.Description = cityEvent.Description.Substring(0, 131);
                    cityEvent.Description += "...";
                }
                cityEvent.ImagePath = eventNode.SelectSingleNode("Image")?.InnerText;
                cityEvent.Date = eventNode.SelectSingleNode("EventDate")?.InnerText;
                cityEvent.Categories = new List<string>();
                var categoryNodes = eventNode.SelectNodes("Category/CategoryItem");
                foreach (XmlNode categoryNode in categoryNodes)
                {
                    cityEvent.Categories.Add(categoryNode.InnerText);
                }
                cityEvent.Price = eventNode.SelectSingleNode("Price")?.InnerText;

                AllEvents.Add(cityEvent);
            }

            return AllEvents;
        }
    }
}