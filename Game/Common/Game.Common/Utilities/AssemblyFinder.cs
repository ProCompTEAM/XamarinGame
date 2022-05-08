using System;
using System.Linq;
using System.Reflection;

namespace Game.Common.Utilities
{
    public static class AssemblyFinder
    {
        public static Assembly FormsUIAssembly => GetAssemblyByName("Game.Forms.UI");

        public static Assembly GetAssemblyByName(string name)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            return assemblies.SingleOrDefault(assembly => assembly.GetName().Name == name);
        }
    }
}
