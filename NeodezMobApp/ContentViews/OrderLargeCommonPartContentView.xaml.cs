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
            $"������ - {square.Text}, \n" +
            $"���������� ������ - {roomsNumber.Text}, \n" +
            $"���� �� �������� �������� - {(petsCheckBox.IsChecked ? "����" : "���")}, \n" +
            $"��������� ����� - {nearestStation.Text}, \n" +
            $"�������������� ����� - {dateTimePicker.SelectedItem},\n" +
            $"��� ��������� - {customerName.Text}, \n" +
            $"������� - {customerPhone.Text}, \n" +
            $"�������� �� ��������� ������ - {(agreementCheckBox.IsChecked ? "����" : "���")}, \n" +
            $"���������� - {comments.Text}";

        }
    }
}