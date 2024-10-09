using CommunityToolkit.Mvvm.ComponentModel;

namespace ComboBoxTest.Models;

public partial class TestModel : ObservableObject
{
    [ObservableProperty] private TestEnum enumProperty;
}