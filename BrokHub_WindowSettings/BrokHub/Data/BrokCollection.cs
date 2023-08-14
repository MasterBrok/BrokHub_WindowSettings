

using BrokHub_WindowSettings.BrokHub.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace BrokHub_WindowSettings.BrokHub.Data
{
    public class BrokCollection
    {
        public static readonly List<Item> DataContextButtons = new List<Item>()
        {
            new()
            {
                Title = "System",
                SubContent = new[]{"Display","Sound","Power"},
                Source = Application.Current.FindResource("Laptop") as ImageSource
            },
             new()
            {
                Title = "Apps",
                SubContent = new[]{"Uninstall,","Options,","Features,"},
                Source = Application.Current.FindResource("Apps") as ImageSource
            },
              new()
            {
                Title = "Search",
                SubContent = new[]{"Find me files,","permissions,",string.Empty},
                Source = Application.Current.FindResource("Search") as ImageSource
            },
               new()
            {
                Title = "Devices",
                SubContent = new[]{"Bluetooth,","Printers,","Mouse,"},
                Source = Application.Current.FindResource("Devices") as ImageSource
            },
               new()
            {
                Title = "Account",
                SubContent = new[]{"Your Account,","Email,","family"},
                Source = Application.Current.FindResource("Account") as ImageSource
            }
                 ,
               new()
            {
                Title = "Cortana",
                SubContent = new[]{"Cortana Language,","Permissons,",string.Empty},
                Source = Application.Current.FindResource("Cortana") as ImageSource
            }
                 ,
               new()
            {
                Title = "Time & Language",
                SubContent = new[]{"Speech,","region,",string.Empty},
                Source = Application.Current.FindResource("TimeAndLanguage") as ImageSource
            }
                 ,
               new()
            {
                Title = "Privacy",
                SubContent = new[]{"Location,","Camera,","mouse"},
                Source = Application.Current.FindResource("Privacy") as ImageSource
            }
                 ,
               new()
            {
                Title = "NetWork & Internet",
                SubContent = new[]{"Wi-fi,","airplane mode,","VPN"},
                Source = Application.Current.FindResource("Gameing") as ImageSource
            },
               new()
            {
                Title = "Gameing",
                SubContent = new[]{"Gamebar,","capture,","brodcasting"},
                Source = Application.Current.FindResource("Gameing") as ImageSource
            }
               ,
               new()
            {
                Title = "Update & Security",
                SubContent = new[]{"Windwos update,","recovery,","backup"},
                Source = Application.Current.FindResource("Updates") as ImageSource
            }
        };
    }
}
