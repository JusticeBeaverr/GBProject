﻿using GadgetBlitzPZ.Models.Smartphone;
using System.Collections.ObjectModel;

namespace GadgetBlitzPZ.ViewModels.Smartphone
{
    public interface ISmartphoneViewModel
    {
        ObservableCollection<SmartphoneModel> Smartphones { get; }
        void LoadSmartphones();
        void AddSmartphone(SmartphoneModel smartphone);
        void UpdateSmartphone(SmartphoneModel smartphone);
        void DeleteSmartphone(int id);
    }
}
