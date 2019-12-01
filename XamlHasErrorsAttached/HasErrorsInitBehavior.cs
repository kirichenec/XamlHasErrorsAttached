using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace XamlHasErrorsAttached
{
    public class HasErrorsInitBehavior : Behavior<FrameworkElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            Validation.AddErrorHandler(AssociatedObject, (s, args) =>
            {
                if (s is FrameworkElement element)
                {
                    var errorsList = HasErrorsAttached.GetErrorsList(element);
                    if (errorsList == null)
                    {
                        throw new ArgumentException($"Attached {HasErrorsAttached.ErrorsList} is null");
                    }

                    if (args.Action == ValidationErrorEventAction.Added)
                    {
                        errorsList.Add(args.Error);
                    }
                    else
                    {
                        errorsList.Remove(args.Error);
                    }
                    HasErrorsAttached.SetHasErrors(element, errorsList.Any());
                }
            });
        }
    }
}