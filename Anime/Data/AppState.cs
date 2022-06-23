﻿namespace Anime.Data
{
    public class AppState
    {
        private bool _userRoot = false;
        public string _userName = "Вход";
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
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
