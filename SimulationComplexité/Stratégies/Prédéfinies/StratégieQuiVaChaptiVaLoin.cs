using SimulationComplexité.Notation;

namespace SimulationComplexité.Stratégies.Prédéfinies
{
    internal class StratégieQuiVaChaptiVaLoin : IStratégieÉtalon
    {
        /// <inheritdoc />
        public uint MontantInvestiEnQualité(
            uint valeurProduiteBrute, 
            uint complexitéAccidentelleActuelle,
            uint scoreProduitActuel, 
            ushort coutDUnDé)
        {
            if (complexitéAccidentelleActuelle > valeurProduiteBrute) return valeurProduiteBrute;
            var valeurInvestissableEnProduit = valeurProduiteBrute - complexitéAccidentelleActuelle;

            return complexitéAccidentelleActuelle + valeurInvestissableEnProduit / 2;
        }

        /// <inheritdoc />
        public ushort Note => 10;
    }
}
