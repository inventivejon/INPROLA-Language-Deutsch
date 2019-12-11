using System;
using System.Collections.Generic;
using System.Text;

namespace INPROLA_Language_Deutsch
{
    public static class Verben
    {
        public static Verb_Konjugation getVerbKonjugation(string VerbStamm, bool regelmaessig)
        {
            return (regelmaessig) ? RegelmaessigesVerbBuilder.generateRegelmaessigVerbKonjugation(VerbStamm) : UnregelmaessigesVerbBuilder.getUnregelmaessigVerbKonjugation(VerbStamm);
        }
    }
}
