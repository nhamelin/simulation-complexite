using SimulationComplexité.Notation;

namespace SimulationComplexité.Stratégies.Prédéfinies
{
    internal class StratégiePrudente : IStratégieÉtalon
    {
        /// <inheritdoc />
        public uint MontantInvestiEnQualité(
            uint valeurProduiteBrute,
            uint complexitéAccidentelleActuelle,
            uint scoreProduitActuel,
            ushort coutDUnDé)
            => valeurProduiteBrute / 2;

        /// <inheritdoc />
        public ushort Note => 8;
    }
}
