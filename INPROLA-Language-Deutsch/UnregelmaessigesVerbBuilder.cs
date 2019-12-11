using System;
using System.Collections.Generic;
using System.Text;

namespace INPROLA_Language_Deutsch
{
    public static class UnregelmaessigesVerbBuilder
    {
        public static Verb_Konjugation getUnregelmaessigVerbKonjugation(string VerbStamm)
        {
            Verb_Konjugation returnValue = null;

            switch(VerbStamm)
            {
                case "sein":
                    //Kann sowohl Vollverb als auch Hilfsverb sein
                    //Subjektgleichsetzungsfall kann hier vorkommen
                    //sein + Adjektiv
                    //sein + es (Nominativfunktion) + Dativ-Ergänzung
                    //sein + Nomen
                    //Material
                    //Situativ-Ergänzung
                    //Hinweise
                    //Zusammengesetzte Verben: auf sein, da sein, beisammen sein, dabei sein, los sein, zusammen sein
                    returnValue = new Verb_Konjugation
                    {
                        Singular_1Person = "bin",
                        Singular_2Person = "bist",
                        Singular_3Person = "ist",
                        Plural_1Person = "sind",
                        Plural_2Person = "seid",
                        Plural_3Person = "sind"
                    };
                    break;

                case "haben":
                    //Kann sowohl Vollverb als auch Hilfsverb sein
                    //Mit dem Hilfsverb wird das Perfekt gebildet
                    //Haben hat eine Nominativ und eine Akkusativ-Ergänzung
                    returnValue = new Verb_Konjugation
                    {
                        Singular_1Person = "habe",
                        Singular_2Person = "hast",
                        Singular_3Person = "hat",
                        Plural_1Person = "haben",
                        Plural_2Person = "habt",
                        Plural_3Person = "haben"
                    };
                    break;
            }

            return returnValue;
        }
    }
}
