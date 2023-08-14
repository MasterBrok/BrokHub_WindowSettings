

using BrokHub_WindowSettings.BrokHub.Commands;
using BrokHub_WindowSettings.BrokHub.Data;
using BrokHub_WindowSettings.Controls;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace BrokHub_WindowSettings.BrokHub.ViewModels
{
    public partial class SettingViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void Notify(string TargetName)
        {
            if (PropertyChanged is not null)
                PropertyChanged(this, new PropertyChangedEventArgs(TargetName));
        }



        private bool CanAddChildren_Loaded(object obj)
        {
            return BrokCollection.DataContextButtons != null;
        }
        private void AddChildren_Loaded(object obj)
        {
            WrapPanel? panel = obj as WrapPanel;
            foreach (var item in BrokCollection.DataContextButtons)
            {
                ccButton? ccButton = new ccButton()
                {
                    DataContext = item,
                    Tag = item.Title,
                    Command = GetPage,
                };
                ccButton.CommandParameter = ccButton;
                panel.Children.Add(ccButton);
                Thread.Sleep(100);
            }
        }
        private bool CanGetPage_Click(object obj)
        {
            return true;
        }

        private void GetPahe_Click(object obj)
        {
            ccButton? cc = (obj as ccButton);
            MessageBox.Show(cc.SubTitle1);
        }
    }
}
