using SimulationComplexité.Notation;

namespace SimulationComplexité.Stratégies.Prédéfinies
{
    internal class StratégieDavidGoodenough : IStratégieÉtalon
    {
        /// <inheritdoc />
        public uint MontantInvestiEnQualité(
            uint valeurProduiteBrute,
            uint complexitéAccidentelleActuelle,
            uint scoreProduitActuel,
            ushort coûtDUnDé)
            => 0;

        /// <inheritdoc />
        public ushort Note => 0;
    }
}
