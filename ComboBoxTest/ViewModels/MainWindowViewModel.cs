using System;
using System.Collections.ObjectModel;
using ComboBoxTest.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ComboBoxTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private TestModel modelProperty;
    
    public ObservableCollection<TestEnum> EnumValues { get; } = [];
    public ObservableCollection<TestModel> Models { get; } = [];
    
    public MainWindowViewModel()
    {
        foreach (var value in Enum.GetValues<TestEnum>())
        {
            EnumValues.Add(value);
        }
        
        ModelProperty = new() { EnumProperty = TestEnum.EnumValue1 };
        Models.Add(new() { EnumProperty = TestEnum.EnumValue1 });
    }

    [RelayCommand]
    private void AddModel()
    {
        Models.Add(new() { EnumProperty = TestEnum.EnumValue1 });
    }
}