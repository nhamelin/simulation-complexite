using SimulationComplexité.Simulation.Stratégie;
using SimulationComplexité.Stratégies.Prédéfinies;

namespace SimulationComplexité.Stratégies
{
    internal class VotreStratégie : IStratégieQualité
    {
        private static readonly StratégieQuiVaChaptiVaLoin StratégiePrudente = new ();

        /// <inheritdoc />
        public uint MontantInvestiEnQualité(
            uint valeurProduiteBrute,
            uint complexitéAccidentelleActuelle,
            uint scoreProduitActuel,
            ushort coutDUnDé)
        {
<<<<<<< HEAD

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
                    else if(complexitéAccidentelleActuelle < 10)
                    {
                        montantInvestiEnQUalité = valeurProduiteBrute / 2;

                        return montantInvestiEnQUalité;
                    } else
                    {
                        montantInvestiEnQUalité = valeurProduiteBrute / 3;
                        return montantInvestiEnQUalité;
                    }
                }
                else
                {
                    montantInvestiEnQUalité = valeurProduiteBrute / 2;

                    return montantInvestiEnQUalité;
                }

            }     
/*
            var maximumInvestissable = StratégiePrudente.MontantInvestiEnQualité(
                valeurProduiteBrute, 
                complexitéAccidentelleActuelle, 
                scoreProduitActuel, 
                coutDUnDé);

            var complexitéTotaleInitale = scoreProduitActuel + complexitéAccidentelleActuelle;

            (uint InvestissementQualité, uint NombreDésEntropieProjeté, uint MontantProduit) meilleurInvestissement = 
                (0, (complexitéTotaleInitale + valeurProduiteBrute * 2) / coutDUnDé, valeurProduiteBrute);
            
            for (uint montantInvestiEnQualité = 1; montantInvestiEnQualité <= maximumInvestissable; montantInvestiEnQualité++)
            {
                var montantInvestiEnProduit = Convert.ToUInt32(valeurProduiteBrute - montantInvestiEnQualité);
                var complexitéProduite = montantInvestiEnProduit * 2;

                var complexitéTotaleProjetée =
                    Convert.ToUInt32(complexitéTotaleInitale + complexitéProduite - montantInvestiEnQualité);

                var nombreDésEntropieProjeté = complexitéTotaleProjetée / coutDUnDé;

                if (nombreDésEntropieProjeté < meilleurInvestissement.NombreDésEntropieProjeté
                    || nombreDésEntropieProjeté == meilleurInvestissement.NombreDésEntropieProjeté
                    && montantInvestiEnProduit > meilleurInvestissement.MontantProduit)
                    meilleurInvestissement = (montantInvestiEnQualité, nombreDésEntropieProjeté, montantInvestiEnProduit);
            }

            return meilleurInvestissement.InvestissementQualité;
*/
        }

        public IStratégieQualité Fork() => new VotreStratégie();
    }
}
