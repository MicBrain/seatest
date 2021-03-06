using System;
using System.Collections.ObjectModel;

namespace SeaTest
{
    public class Test : Observable
    {
        public string Name { get; set; }
        public ObservableCollection<TestResult> Results { get; set; }

        private bool _hasRun;
        public bool HasRun
        {
            get { return _hasRun; }
            set { _hasRun = value; OnPropertyChanged("HasRun");}
        }

        private bool _passed = false;
        public bool Passed
        {
            get { return _passed; }
            set { _passed = value; OnPropertyChanged("Passed");}
        }

        public Fixture Fixture { get; set; }
    }
}
