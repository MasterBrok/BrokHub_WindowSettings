using BrokHub_WindowSettings.BrokHub.Commands;
using BrokHub_WindowSettings.BrokHub.Data;
using BrokHub_WindowSettings.Controls;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Input;

namespace BrokHub_WindowSettings.BrokHub.ViewModels
{
    public partial class SettingViewModel
    {
        private ICommand cmdAddChilder;

        public ICommand AddChildren
        {
            get
            {
                if (cmdAddChilder == null)
                    cmdAddChilder = new BaseCommands(AddChildren_Loaded, CanAddChildren_Loaded);
                return cmdAddChilder;
            }
        }


        private ICommand? _getPage;

        public ICommand? GetPage
        {
            get
            {
                if (_getPage is null)
                    _getPage = new BaseCommands(GetPahe_Click, CanGetPage_Click);
                return _getPage;
            }
        }




    }
}
