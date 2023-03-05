using Avalonia.Media;
using DynamicData.Diagnostics;
using Events.ViewModels;
using ReactiveUI;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Events.Models
{
    public class CityEvent
    {
        public CityEvent() { }

        private string _Header { get; set; }
        public string Header { get => _Header; set { _Header = value; } }

        private string _Description { get; set; }
        public string Description { get => _Description;
            set
            {
                _Description = value;
            }
            }

        private string _ImagePath { get; set; }
        public string ImagePath { get => _ImagePath; set { _ImagePath = value; } }

        private string _Date { get; set; }

        public string Date { get => _Date; set { _Date = value; } }

        private string _Price { get; set; }

        public string Price { get => _Price; set { _Price = value; } }

        private List<string> _Categories { get; set; }
        public List<string> Categories
        {
            get => _Categories;
            set { _Categories = value; }
        }

       /* public CityEvent(string head, string desc, string iPath, string date, string price)
        {
            _Header = head;
            _Description = desc;
            _ImagePath = iPath;
            _Date = date;
            _Price = price;
        }*/
    }
}
