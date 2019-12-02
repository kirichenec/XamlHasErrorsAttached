using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace XamlHasErrorsAttached
{
    public static class HasErrorsAttached
    {
        #region ErrorsList
        public const string ErrorsList = nameof(ErrorsList);

        public static IList<ValidationError> GetErrorsList(DependencyObject obj)
        {
            return (IList<ValidationError>)obj.GetValue(ErrorsListProperty);
        }

        public static void SetErrorsList(DependencyObject obj, IList<ValidationError> value)
        {
            obj.SetValue(ErrorsListProperty, value);
        }

        public static readonly DependencyProperty ErrorsListProperty =
            DependencyProperty.RegisterAttached(
                ErrorsList,
                typeof(IList<ValidationError>),
                typeof(HasErrorsAttached),
                new PropertyMetadata(new ObservableCollection<ValidationError>()));
        #endregion

        #region HasErrors
        public const string HasErrors = nameof(HasErrors);

        public static bool GetHasErrors(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasErrorsProperty);
        }

        public static void SetHasErrors(DependencyObject obj, bool value)
        {
            obj.SetValue(HasErrorsProperty, value);
        }

        public static readonly DependencyProperty HasErrorsProperty =
            DependencyProperty.RegisterAttached(
                HasErrors,
                typeof(bool),
                typeof(HasErrorsAttached),
                new PropertyMetadata(false));
        #endregion
    }
}