using Xamarin.Forms;

namespace SQLiteSample007
{
    public partial class SQLiteSamplePage007 : ContentPage
    {
        /*public SQLiteSamplePage007()
        {
            InitializeComponent();

            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            //Userテーブルに適当なデータを追加する
            UserModel007.insertUser("鈴木");
            UserModel007.insertUser("田中");
            UserModel007.insertUser("斎藤");

            //Userテーブルの行データを取得
            var query = UserModel007.selectUser();

            foreach (var user in query)
            {

                //Userテーブルの名前列をLabelに書き出す
                layout.Children.Add(new Label { Text = user.Name });
            }

            Content = layout;
        }*///おかしくなったら下のソース消してこれのコメントアウトを解呪する!

        public SQLiteSamplePage007()
        {
            InitializeComponent();

            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            //Userテーブルに適当なデータを追加する
            UserModel007.insertUser("鈴木");
            UserModel007.insertUser("田中");
            UserModel007.insertUser("斎藤");

            var buttonAdd = new Button
            {
                WidthRequest = 60,
                TextColor = Color.White,
                Text = "Add"
            };


            //Userテーブルの行データを取得
            var query = UserModel007.selectUser();

            foreach (var user in query)
            {

                //Userテーブルの名前列をLabelに書き出す
                layout.Children.Add(new Label { Text = user.Name });
            }

            Content = layout;
        }



    }
}