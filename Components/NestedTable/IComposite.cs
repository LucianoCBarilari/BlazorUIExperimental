using System.Collections.Generic;

namespace BlazorUIExperimental.Components.NestedTable
{
    public interface IComposite
    {
        void Select();
        void Deselect();
        IEnumerable<int> GetSelectedIds();
        bool IsSelected { get; }
    }
}
