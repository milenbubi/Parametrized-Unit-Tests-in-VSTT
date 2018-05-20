using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]

namespace Utilities
{
    public class ClassContainingPrivateAndInternalMembers
    {
        internal string InternalProperty
        {
            get { return "Internal property"; }
        }

        internal string InternalMethod()
        {
            return "Internal method";
        }

        private string PrivateMethod()
        {
            return "Private method";
        }
    }
}