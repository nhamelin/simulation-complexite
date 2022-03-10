using SimulationComplexité.Simulation;

namespace SimulationComplexité.Notation
{
    internal interface IStratégieÉtalon : IStratégieQualité
    {
        public ushort Note { get; }
    }
}
