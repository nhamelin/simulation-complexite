namespace SimulationComplexité.Simulation
{
    internal interface IStratégieQualité
    {
        uint MontantInvestiEnQualité(
            uint valeurProduiteBrute, 
            uint complexitéAccidentelleActuelle,
            uint scoreProduitActuel,
            ushort coûtDUnDé);
    }
}
