namespace Builder
{
    internal interface ICarBuilder
    {
        void Reset();
        void BuildChassis();
        void BuildBody();
        void BuildEngine();
        void BuildElectronics();
        void BuildWindows();
    }
}
