using System.Collections.Generic;

namespace BlazorUIExperimental.Components.NestedTable
{
    public static class CompositeFactory
    {
        public static List<OrganismoT> BuildTree()
        {
            var organismos = CompositeMockData.CreateOrganismos();
            var escalafones = CompositeMockData.CreateEscalafones();

            var index = new Dictionary<long, OrganismoT>();
            var result = new List<OrganismoT>();

            foreach (var item in organismos)
            {
                var org = new OrganismoT
                {
                    OrganismoID = item.OrganismoID,
                    Mnemonico = item.Mnemonico,
                    Nombre = item.Nombre,
                    FDesde = item.FDesde,
                    FHasta = item.FHasta
                };

                index[item.OrganismoID] = org;
                result.Add(org);
            }

            foreach (var item in escalafones)
            {
                if (!index.TryGetValue(item.OrganismoID, out var parent))
                {
                    continue;
                }

                var child = new EscalafonesT
                {
                    EscalafonID = item.EscalafonID,
                    OrganismoID = item.OrganismoID,
                    Mnemonico = item.Mnemonico,
                    Nombre = item.Nombre
                };

                parent.Children.Add(child);
            }

            return result;
        }
    }
}
