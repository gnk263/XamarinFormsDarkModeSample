﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DarkModeSample.Resources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DarkTheme : ResourceDictionary
    {
        public DarkTheme()
        {
            InitializeComponent();
        }
    }
}