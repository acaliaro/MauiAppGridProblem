using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppGridProblem
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<int> valori;

        public MainViewModel()
        {

            Valori = new ObservableCollection<int>();

            for(int i = 1; i< 100; i++)
            {
                Valori.Add(i);
            }
        }
    }
}
