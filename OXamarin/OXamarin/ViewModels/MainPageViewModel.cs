using OXamarin.Models;
using Prism.Mvvm;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OXamarin.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        #region フィールド

        private List<Drink> _items;
        private string _selectedItem;

        #endregion

        #region プロパティ

        public List<Drink> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }

        #endregion

        #region コマンド

        public Command<Drink> ItemSelectedCommand { get; }

        #endregion

        #region コンストラクタ

        public MainPageViewModel()
        {
            //ListVIew上に表示させるデータ一覧
            _items = new List<Drink>
            {
                new Drink{DrinkName="コラ・コーラ"},
                new Drink{DrinkName="フェンタ"},
                new Drink{DrinkName="アクエリオンロゴス"},
                new Drink{DrinkName="ポカリスェット"},
                new Drink{DrinkName="綾鷲"},
            };

            //ListViewタップ時に実行されるコマンド
            ItemSelectedCommand = new Command<Drink>(
                x => SelectedItem = x.DrinkName,
                x => x != null);
        }

        #endregion
    }
}