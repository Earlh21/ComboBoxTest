using System;
using System.Collections.ObjectModel;
using ComboBoxTest.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ComboBoxTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<TestEnum> EnumValues { get; } = [];
    public ObservableCollection<TestModel> Models { get; } = [];
    
    public MainWindowViewModel()
    {
        foreach (var value in Enum.GetValues<TestEnum>())
        {
            EnumValues.Add(value);
        }

        Models.Add(new() { EnumProperty = TestEnum.EnumValue1 });
    }
}