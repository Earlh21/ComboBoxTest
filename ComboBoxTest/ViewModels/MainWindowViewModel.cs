using System;
using System.Collections.ObjectModel;
using ComboBoxTest.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ComboBoxTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private TestModelEnum modelEnumProperty;
    
    public ObservableCollection<TestEnum> EnumValues { get; } = [];
    public ObservableCollection<TestModelEnum> EnumModels { get; } = [];

    public ObservableCollection<string> StringValues { get; } = ["a", "b", "c"];
    public ObservableCollection<TestModelString> StringModels { get; } = [];
    
    public MainWindowViewModel()
    {
        foreach (var value in Enum.GetValues<TestEnum>())
        {
            EnumValues.Add(value);
        }
        
        ModelEnumProperty = new() { EnumProperty = TestEnum.EnumValue1 };
        EnumModels.Add(new() { EnumProperty = TestEnum.EnumValue1 });
        StringModels.Add(new() { StringProperty = StringValues[0] });
    }

    [RelayCommand]
    private void AddModel()
    {
        EnumModels.Add(new() { EnumProperty = TestEnum.EnumValue1 });
    }
}