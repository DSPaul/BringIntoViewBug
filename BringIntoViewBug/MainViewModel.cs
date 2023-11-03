using System.Collections.ObjectModel;
using System.Linq;

namespace BringIntoViewBug
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Items = new(Enumerable.Range(0, 1000));
        }

        public ObservableCollection<int> Items { get; set; }
    }
}
