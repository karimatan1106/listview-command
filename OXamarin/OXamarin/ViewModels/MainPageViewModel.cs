using Prism.Mvvm;
using System.Collections.Generic;

namespace OXamarin.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private List<string> _items;
        public List<string> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public MainPageViewModel()
        {
            _items = new List<string>
            {
                "コラ・コーラ",
                "フェンタ",
                "アクエリオンロゴス",
                "ポカリスェット",
                "綾鷲",
            };
        }
    }
}