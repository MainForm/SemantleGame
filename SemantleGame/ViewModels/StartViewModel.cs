using System;
using System.Collections.Generic;
using System.Text;

namespace SemantleGame.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        private readonly MainWindowViewModel _mainViewMode;
        
        public StartViewModel(MainWindowViewModel mainViewMode)
        {
            _mainViewMode = mainViewMode;
        }

    }
}
