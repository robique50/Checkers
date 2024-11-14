using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MAP_Tema2_Checkers.Utils
{
    public static class Extensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> col)
        {
            return new ObservableCollection<T>(col);
        }
    }
}
