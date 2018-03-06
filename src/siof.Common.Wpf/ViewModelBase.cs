using System.Runtime.CompilerServices;

namespace siof.Common.Wpf
{
    public class ViewModelBase : NotifyObject
    {
        private bool _isLoading;

        public bool IsLoading
        {
            get => _isLoading;

            set
            {
                if (_isLoading != value)
                {
                    _isLoading = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _isLoadingInfoText;

        public string IsLoadingInfoText
        {
            get => _isLoadingInfoText;

            set
            {
                if (_isLoadingInfoText != value)
                {
                    _isLoadingInfoText = value;
                    OnPropertyChanged();
                }
            }
        }

        protected new void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }
    }
}
