﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DarkModeSample.Resources
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LightTheme : ResourceDictionary
    {
        public LightTheme()
        {
            InitializeComponent();
        }
    }
}