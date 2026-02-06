using System;
using System.Collections.Generic;

namespace BlazorUIExperimental.Components.NestedTable
{
    public class EscalafonesT : IComposite
    {
        public long EscalafonID { get; set; }
        public long OrganismoID { get; set; }
        public string Mnemonico { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
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
            _isSelected = true;
        }

        public void Deselect()
        {
            _isSelected = false;
        }

        public IEnumerable<int> GetSelectedIds()
        {
            return IsSelected ? new[] { (int)EscalafonID } : Array.Empty<int>();
        }
    }
}
