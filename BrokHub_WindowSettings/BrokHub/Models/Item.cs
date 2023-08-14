
using System;
using System.Windows.Media;

namespace BrokHub_WindowSettings.BrokHub.Models
{
    [Serializable]
    public class Item
    {
        public string? Title { get; set; }
        public string[]? SubContent { get; set; }
        public ImageSource? Source { get; set; }
    }
}
        