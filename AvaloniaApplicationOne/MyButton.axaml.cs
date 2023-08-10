using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using Avalonia.Input;

namespace AvaloniaApplicationOne;

public partial class MyButton : UserControl
{
    public event MyButtonEventHandler MyButtonClick;

    public MyButton()
    {
        InitializeComponent();
        PointerReleased += MyButton_PointerReleased;
    }

    private void MyButton_PointerReleased(object sender, PointerReleasedEventArgs e)
    {
        MyButtonClickArgs buttonClickArgs = new();
        switch(e.InitialPressMouseButton)
        {
            case MouseButton.Left:
                buttonClickArgs.ButtonNumber = 1;
                break;
            case MouseButton.Right:
                buttonClickArgs.ButtonNumber = 2;
                break;
            case MouseButton.Middle:
                buttonClickArgs.ButtonNumber = 3;
                break;
        }

        MyButtonClick.Invoke(this, buttonClickArgs);
    }
}

public class MyButtonClickArgs : EventArgs
{
    public int ButtonNumber { get; set; }
}

public delegate void MyButtonEventHandler(object sender, MyButtonClickArgs e);