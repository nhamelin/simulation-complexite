using SimulationComplexité.Simulation.Stratégie;

namespace SimulationComplexité.Stratégies
{
    internal class VotreStratégie : IStratégieQualité
    {
        /// <inheritdoc />
        public uint MontantInvestiEnQualité(
            uint valeurProduiteBrute,
            uint complexitéAccidentelleActuelle,
            uint scoreProduitActuel,
            ushort coutDUnDé)
        {

            uint montantInvestiEnQUalité;
            uint valeurInvestissableEnProduit = valeurProduiteBrute - complexitéAccidentelleActuelle;


            if (complexitéAccidentelleActuelle < valeurProduiteBrute)
            {
                montantInvestiEnQUalité = complexitéAccidentelleActuelle + valeurInvestissableEnProduit / 2;

                return montantInvestiEnQUalité;
            }
            else
            {
                if (complexitéAccidentelleActuelle < scoreProduitActuel)
                {
                    if (complexitéAccidentelleActuelle < 5)
                    {
                        montantInvestiEnQUalité = valeurProduiteBrute;

                        return montantInvestiEnQUalité;
                    }
                    else
                    {
                        montantInvestiEnQUalité = valeurProduiteBrute / 2;

                        return montantInvestiEnQUalité;
                    }
                }
                else
                {
                    montantInvestiEnQUalité = valeurProduiteBrute / 2;

                    return montantInvestiEnQUalité;
                }

            }     
        }

        public IStratégieQualité Fork() => new VotreStratégie();
    }
}
