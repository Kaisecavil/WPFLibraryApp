using NovikovWPFLibraryApp.Infrastructure.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovikovWPFLibraryApp.Infrastructure.Commands
{
    internal class LambdaCommand : Command
    {

        public LambdaCommand(Action<object> Execute, Func<object,bool> CanExecute = null)
        {
            _execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _canExecute = CanExecute ?? throw new ArgumentNullException(nameof(CanExecute));
        }

        private readonly Action<object> _execute;
        private readonly Func<object, bool> _canExecute;

        public override bool CanExecute(object? parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        public override void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
