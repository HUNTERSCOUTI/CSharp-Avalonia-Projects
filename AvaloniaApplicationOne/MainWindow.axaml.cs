using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplicationOne
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        void buttonClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Content = "Clicked";
        }
        
        void titleChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem comboBoxItem = comboBox.SelectedItem as ComboBoxItem;

            this.Title = comboBoxItem.Content.ToString();
        }

        void calChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar cal = (Calendar)sender;
            if(cal.SelectedDates.Count >= 5) 
            {
                cal.IsVisible = false;
            }
        }

        void changeFontFromText(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            if (int.TryParse(textBox.Text, out int font))
            {
                FontBox.FontSize = font;
            }
        }
        
        void onMathiasClick(object sender, MyButtonClickArgs e) 
        {
            Title = "Mathias Is Gay";
        }
    }
}