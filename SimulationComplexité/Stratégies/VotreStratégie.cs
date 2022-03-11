using SimulationComplexité.Simulation;

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
            if (complexitéAccidentelleActuelle < valeurProduiteBrute)
            {
                var valeurInvestissableEnProduit = valeurProduiteBrute - complexitéAccidentelleActuelle;

                return complexitéAccidentelleActuelle + valeurInvestissableEnProduit / 2;
            }
            else
            {
                if (complexitéAccidentelleActuelle < scoreProduitActuel)
                {
                    if (complexitéAccidentelleActuelle < 5)
                    {
                        return valeurProduiteBrute;
                    }
                    else
                    {
                        return valeurProduiteBrute / 2;
                    }
                }
                else
                {
                    return valeurProduiteBrute / 2;
                }

            }     
        }

        /// <inheritdoc />
        public ushort Note => 10;
    }
}
