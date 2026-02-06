using System;
using System.Collections.Generic;

namespace BlazorUIExperimental.Components.NestedTable
{
    public static class CompositeMockData
    {
        public static List<Organismo> CreateOrganismos()
        {
            return new List<Organismo>
            {
                new() { OrganismoID = 1, Mnemonico = "ORG-A", Nombre = "Organization Alpha", FDesde = DateTime.Today.AddYears(-10) },
                new() { OrganismoID = 2, Mnemonico = "ORG-B", Nombre = "Organization Beta", FDesde = DateTime.Today.AddYears(-8) },
                new() { OrganismoID = 3, Mnemonico = "ORG-C", Nombre = "Organization Gamma", FDesde = DateTime.Today.AddYears(-5) }
            };
        }

        public static List<Escalafon> CreateEscalafones()
        {
            return new List<Escalafon>
            {
                new() { EscalafonID = 101, OrganismoID = 1, Mnemonico = "ITEM-1", Nombre = "Item 1" },
                new() { EscalafonID = 102, OrganismoID = 1, Mnemonico = "ITEM-2", Nombre = "Item 2" },
                new() { EscalafonID = 201, OrganismoID = 2, Mnemonico = "ITEM-3", Nombre = "Item 3" },
                new() { EscalafonID = 202, OrganismoID = 2, Mnemonico = "ITEM-4", Nombre = "Item 4" },
                new() { EscalafonID = 301, OrganismoID = 3, Mnemonico = "ITEM-5", Nombre = "Item 5" }
            };
        }
    }
}
