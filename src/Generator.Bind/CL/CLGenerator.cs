namespace Bind.CL
{
    internal class CLGenerator : ES.ESGenerator
    {
        public CLGenerator(Settings settings)
            : base(settings)
        {
            glTypemap = null;

            Settings.WrappersFile = "CL.cs";

            Settings.FunctionPrefix = "cl";
            Settings.ConstantPrefix = "CL_";
            Settings.EnumPrefix = "Cl";

            Settings.OutputClass = "CL";

            //Settings.Compatibility &= ~Settings.Legacy.TurnVoidPointersToIntPtr;
            Settings.Compatibility |= Settings.Legacy.NoDebugHelpers;

            Settings.DefaultImportsFile = "CLCore.cs";
            Settings.DefaultDelegatesFile = "CLDelegates.cs";
            Settings.DefaultEnumsFile = "CLEnums.cs";
            Settings.DefaultWrappersFile = "CL.cs";
        }
    }
}
