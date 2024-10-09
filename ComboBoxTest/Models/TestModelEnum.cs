using CommunityToolkit.Mvvm.ComponentModel;

namespace ComboBoxTest.Models;

public partial class TestModelEnum : ObservableObject
{
    [ObservableProperty] private TestEnum enumProperty;
}