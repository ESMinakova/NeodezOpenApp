namespace NeodezMobApp.ContentViews
{
    public partial class OrderCommonPartContentView : ContentView
    {
        public OrderCommonPartContentView()
        {
            InitializeComponent();
        }

        public async Task<string> ToOrderDescriptionAsync()            
        {
            await Task.Delay(0);
            return
            $"метраж - {square.Text}, \n" +
            $"Количество комнат - {roomsNumber.Text}, \n" +
            $"есть ли домашние животные - {(petsCheckBox.IsChecked ? "есть" : "нет")}, \n" +
            $"Ближайшее метро - {nearestStation.Text}, \n" +
            $"Предпочитаемое время - {dateTimePicker.SelectedItem},\n" +
            $"Имя заказчика - {customerName.Text}, \n" +
            $"Телефон - {customerPhone.Text}, \n" +
            $"Согласие на обработку данных - {(agreementCheckBox.IsChecked ? "есть" : "нет")}, \n" +
            $"Дополнение - {comments.Text}";

        }
    }
}