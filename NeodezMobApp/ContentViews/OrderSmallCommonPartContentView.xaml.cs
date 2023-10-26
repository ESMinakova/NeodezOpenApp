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
            $"������ - {square.Text}, \n" +
            $"�������������� ����� - {dateTimePicker.SelectedItem},\n" +
            $"��� ��������� - {customerName.Text}, \n" +
            $"������� - {customerPhone.Text}, \n" +
            $"�������� �� ��������� ������ - {(agreementCheckBox.IsChecked ? "����" : "���")}, \n" +
            $"���������� - {comments.Text}";

        }
    }
}