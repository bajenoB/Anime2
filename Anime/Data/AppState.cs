namespace Anime.Data
{
    public class AppState
    {
        private bool _userRoot = false;
        public string _userName = "Вход";
        public bool _isLoged = false;
        public event Action OnChange;
        public bool UserRoot
        {
            get { return _userRoot; }
            set
            {
                if (_userRoot != value)
                {
                    _userRoot = value;
                    NotifyStateChanged();
                }
            }
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    NotifyStateChanged();
                }
            }
        }

        public bool IsLoged
        {
            get { return _isLoged; }
            set
            {
                if (_isLoged != value)
                {
                    _isLoged = value;
                    NotifyStateChanged();
                }
            }
        }
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
