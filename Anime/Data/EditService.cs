namespace Anime.Data
{
    public class EditService
    {
        public int id = 0; 
        public event Action OnChange;

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    NotifyStateChanged1();
                }
            }
        }
        private void NotifyStateChanged1() => OnChange?.Invoke();
    }
}
