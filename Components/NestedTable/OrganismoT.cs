using System.Collections.Generic;
using System.Linq;

namespace BlazorUIExperimental.Components.NestedTable
{
    public class OrganismoT : IComposite
    {
        public long OrganismoID { get; set; }
        public string Mnemonico { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public DateTime FDesde { get; set; }
        public DateTime? FHasta { get; set; }

        public List<EscalafonesT> Children { get; } = new();

        public bool IsSelected
        {
            get => Children.Any(child => child.IsSelected);
            set
            {
                if (value)
                {
                    Select();
                }
                else
                {
                    Deselect();
                }
            }
        }

        public void Select()
        {
            foreach (var child in Children)
            {
                child.Select();
            }
        }

        public void Deselect()
        {
            foreach (var child in Children)
            {
                child.Deselect();
            }
        }

        public IEnumerable<int> GetSelectedIds()
        {
            return Children.SelectMany(child => child.GetSelectedIds());
        }
    }
}
