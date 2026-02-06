namespace BlazorUIExperimental.Components.NestedTable
{
    public class Organismo
    {
        public long OrganismoID { get; set; }
        public string Mnemonico { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public DateTime FDesde { get; set; }
        public DateTime? FHasta { get; set; }
    }
}
