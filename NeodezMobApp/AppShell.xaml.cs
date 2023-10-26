namespace NeodezMobApp;

public partial class AppShell : Shell
{
    private Stack<ShellNavigationState> Uri { get; set; } // Navigation stack.  
   
    public AppShell()
	{
		InitializeComponent();
        Uri = new Stack<ShellNavigationState>();
    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);
        var b = args;
        if (Uri != null && args.Previous != null)
        {
            Uri.Push(args.Previous);
        }
    }

    protected override bool OnBackButtonPressed()
    {
        if (Uri.Count > 0)
        {
            Current.GoToAsync(Uri.Pop());
            return true;
        }
        else
        {
            return false;
        }
    }



}
