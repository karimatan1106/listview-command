using Xamarin.Forms;

namespace OXamarin.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// コードビハインドにItemTappedイベント発火時のコードを書く必要がある
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            entry.Text = e.Item.ToString();
        }
    }
}
