namespace MauiApp5
{
    public partial class MainPage : ContentPage
    {
        public int count = 0;

        public MainPage()
        {
            InitializeComponent();
            mygw.EndInteraction += Mygw_EndInteraction;  //mygw is the Name of the GraphicsView in the MainPage xaml
            mygw.StartInteraction += Mygw_StartInteraction;
            mygw.DragInteraction += Mygw_DragInteraction;
        }

        private void Mygw_EndInteraction(object? sender, TouchEventArgs e) // Problem 1:  when i release one fingger, there are stil two touchPoints
        {
            count = 0;
        }

        private void Mygw_DragInteraction(object? sender, TouchEventArgs e)
        {
        }

        private void Mygw_StartInteraction(object? sender, TouchEventArgs e)
        {

        }

        private void Button_IncreaseScale(object sender, EventArgs e)
        {
            mygw.Scale+=1; //Problem 2:  when is Increase the Scale (for zooming purpose e.g., then the Mygw_DragInteraction event fires very late. 
        }

        private void Button_ReduceScale(object sender, EventArgs e)
        {
            mygw.Scale -=1;
        }
    }

}
