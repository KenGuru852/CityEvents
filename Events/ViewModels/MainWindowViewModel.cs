using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using DynamicData;
using DynamicData.Kernel;
using Events.Models;
using ReactiveUI;
using System.Linq;
using Avalonia.Controls.Selection;
using System.IO;

namespace Events.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static MainWindowViewModel? inst;
        private ObservableCollection<CityEvent> _All_Events = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> All_Events
        {
        get { return _All_Events; }
            set => this.RaiseAndSetIfChanged(ref _All_Events, value);
        }

        private ObservableCollection<CityEvent> _For_Kids = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> For_Kids
        {
            get { return _For_Kids; }
            set => this.RaiseAndSetIfChanged(ref _For_Kids, value);
        }

        private ObservableCollection<CityEvent> _Sport = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Sport
        {
            get { return _Sport; }
            set => this.RaiseAndSetIfChanged(ref _Sport, value);
        }

        private ObservableCollection<CityEvent> _Culture = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Culture
        {
            get { return _Culture; }
            set => this.RaiseAndSetIfChanged(ref _Culture, value);
        }

        private ObservableCollection<CityEvent> _Adventures = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Adventures
        {
            get { return _Adventures; }
            set => this.RaiseAndSetIfChanged(ref _Adventures, value);
        }

        private ObservableCollection<CityEvent> _Life_hobby = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Life_Hobby
        {
            get { return _Life_hobby; }
            set => this.RaiseAndSetIfChanged(ref _Life_hobby, value);
        }

        private ObservableCollection<CityEvent> _Tusa = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Tusa
        {
            get { return _Tusa; }
            set => this.RaiseAndSetIfChanged(ref _Tusa, value);
        }

        private ObservableCollection<CityEvent> _Tuduz = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Tuduz
        {
            get { return _Tuduz; }
            set => this.RaiseAndSetIfChanged(ref _Tuduz, value);
        }

        private ObservableCollection<CityEvent> _Education = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Education
        {
            get { return _Education; }
            set => this.RaiseAndSetIfChanged(ref _Education, value);
        }

        private ObservableCollection<CityEvent> _Online = new ObservableCollection<CityEvent>();
        public ObservableCollection<CityEvent> Online
        {
            get { return _Online; }
            set => this.RaiseAndSetIfChanged(ref _Online, value);
        }

        public MainWindowViewModel()
        {
            All_Events = EventParser.Parse("../../../All_Events_XML.xml"); 
            foreach(CityEvent e in All_Events)
            {
                if (e.Categories.Contains("for_kids"))
                {
                    For_Kids.Add(e);
                }
                if (e.Categories.Contains("sport"))
                {
                    Sport.Add(e);
                }
                if(e.Categories.Contains("culture"))
                {
                    Culture.Add(e);
                }
                if(e.Categories.Contains("education"))
                {
                    Education.Add(e);
                }
                if(e.Categories.Contains("adventures"))
                {
                    Adventures.Add(e);
                }
                if(e.Categories.Contains("tusa"))
                {
                    Tusa.Add(e);
                }
                if(e.Categories.Contains("tuduz"))
                {
                    Tuduz.Add(e);
                }
                if(e.Categories.Contains("online"))
                {
                    Online.Add(e);
                }
                if(e.Categories.Contains("life_hobby"))
                {
                    Life_Hobby.Add(e);
                }
            }
        }
    }
}
