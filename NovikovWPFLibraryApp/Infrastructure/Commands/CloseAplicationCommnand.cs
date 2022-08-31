using NovikovWPFLibraryApp.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovikovWPFLibraryApp.Infrastructure.Commands
{
    internal class CloseAplicationCommnand : Command
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            
            Application.Current.Shutdown();
        }
    }
}
