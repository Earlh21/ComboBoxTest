using CommunityToolkit.Mvvm.ComponentModel;

namespace ComboBoxTest.Models;

public partial class TestModelString : ObservableObject
{
    [ObservableProperty] private string stringProperty;
}