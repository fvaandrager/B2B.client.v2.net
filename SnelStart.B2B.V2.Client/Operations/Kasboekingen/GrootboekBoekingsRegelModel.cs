namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// Container voor gegevens van een boeking met een grootboek
    /// </summary>
    public class GrootboekBoekingsRegelModel
    {        
        public string Omschrijving { get; set; }

        /// <summary>
        /// Verwijzing naar een grootboek
        /// </summary>
        public GrootboekIdentifierModel Grootboek { get; set; }

        /// <summary>
        /// Verwijzing naar een kostenplaats
        /// </summary>
        public KostenplaatsIdentifierModel Kostenplaats { get; set; }

        public decimal Debet { get; set; }

        public decimal Credit { get; set; }

        public BtwSoortModel? BtwSoort { get; set; }
    }
}