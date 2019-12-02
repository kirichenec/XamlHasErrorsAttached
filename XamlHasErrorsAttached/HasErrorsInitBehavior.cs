using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace XamlHasErrorsAttached
{
    public class HasErrorsInitBehavior : Behavior<FrameworkElement>
    {
        private readonly IList<ValidationError> _errorsList = new ObservableCollection<ValidationError>();

        protected override void OnAttached()
        {
            base.OnAttached();
            HasErrorsAttached.SetErrorsList(AssociatedObject, _errorsList);
            Validation.AddErrorHandler(AssociatedObject, (s, args) =>
            {
                if (s is FrameworkElement element)
                {
                    if (args.Action == ValidationErrorEventAction.Added)
                    {
                        _errorsList.Add(args.Error);
                    }
                    else
                    {
                        _errorsList.Remove(args.Error);
                    }
                    HasErrorsAttached.SetHasErrors(element, _errorsList.Any());
                }
            });
        }
    }
}