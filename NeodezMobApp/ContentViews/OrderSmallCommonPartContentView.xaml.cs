namespace NeodezMobApp.ContentViews
{
    public partial class OrderSmallCommonPartContentView : ContentView
    {
        public OrderSmallCommonPartContentView()
        {
            InitializeComponent();
        }

        public async Task<string> ToOrderDescriptionAsync()
        {
            await Task.Delay(0);
            return
            $"метраж - {square.Text}, \n" +
            $"Предпочитаемое время - {dateTimePicker.SelectedItem},\n" +
            $"Имя заказчика - {customerName.Text}, \n" +
            $"Телефон - {customerPhone.Text}, \n" +
            $"Согласие на обработку данных - {(agreementCheckBox.IsChecked ? "есть" : "нет")}, \n" +
            $"Дополнение - {comments.Text}";

        }
    }
}