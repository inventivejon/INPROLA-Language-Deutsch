using System;
using System.Collections.Generic;
using System.Text;

namespace INPROLA_Language_Deutsch
{
    public static class RegelmaessigesVerbBuilder
    {
        public static Verb_Konjugation generateRegelmaessigVerbKonjugation(string verbStamm)
        {
            Verb_Konjugation returnValue = null;
            string lastCharacterOfVerbStamm = verbStamm.Substring(verbStamm.Length - 1, 1);
            string last2CharactersOfVerbStamm = verbStamm.Substring(verbStamm.Length - 2, 2);
            string finalDecision = "default";

            switch (lastCharacterOfVerbStamm)
            {
                case "t":
                case "d":
                case "m":
                case "n":
                    finalDecision = "Konjugation-e";
                    break;

                case "s":
                case "ß":
                case "x":
                case "z":
                    finalDecision = "Konjugation-s";
                    break;

                case "l": //Nur relevant für Verben deren Infinitisimalform nicht mit en endet. Muss das hier nochmals geprüft werden?
                    finalDecision = "Konjugation+e_l";
                    break;

                case "r": //Nur relevant für Verben deren Infinitisimalform nicht mit en endet. Muss das hier nochmals geprüft werden?
                    finalDecision = "Konjugation+e_r";
                    break;

                default:
                    break;
            }

            switch (last2CharactersOfVerbStamm)
            {
                case "lm":
                case "ln":
                case "rm":
                case "rn":
                    finalDecision = "default";
                    break;

                default:
                    break;
            }

            switch (finalDecision)
            {
                case "Konjugation-e":
                    /* Default Konjugation regelmaessiges Verb */
                    returnValue = new Verb_Konjugation
                    {
                        Singular_1Person = verbStamm + "e",
                        Singular_2Person = verbStamm + "est",
                        Singular_3Person = verbStamm + "et",
                        Plural_1Person = verbStamm + "en",
                        Plural_2Person = verbStamm + "et",
                        Plural_3Person = verbStamm + "en"
                    };
                    break;

                case "Konjugation-s":
                    /* Default Konjugation regelmaessiges Verb */
                    returnValue = new Verb_Konjugation
                    {
                        Singular_1Person = verbStamm + "e",
                        Singular_2Person = verbStamm + "t",
                        Singular_3Person = verbStamm + "t",
                        Plural_1Person = verbStamm + "en",
                        Plural_2Person = verbStamm + "t",
                        Plural_3Person = verbStamm + "en"
                    };
                    break;

                case "Konjugation+e_l":
                    /* Default Konjugation regelmaessiges Verb */
                    returnValue = new Verb_Konjugation
                    {
                        Singular_1Person = verbStamm.Substring(0, verbStamm.Length - 2) + "le",
                        Singular_2Person = verbStamm + "st",
                        Singular_3Person = verbStamm + "t",
                        Plural_1Person = verbStamm + "n",
                        Plural_2Person = verbStamm + "t",
                        Plural_3Person = verbStamm + "n"
                    };
                    break;

                case "Konjugation+e_r":
                    /* Default Konjugation regelmaessiges Verb */
                    returnValue = new Verb_Konjugation
                    {
                        Singular_1Person = verbStamm + "e",
                        Singular_2Person = verbStamm + "st",
                        Singular_3Person = verbStamm + "t",
                        Plural_1Person = verbStamm + "n",
                        Plural_2Person = verbStamm + "t",
                        Plural_3Person = verbStamm + "n"
                    };
                    break;

                default:
                    /* Default Konjugation regelmaessiges Verb */
                    returnValue = new Verb_Konjugation
                    {
                        Singular_1Person = verbStamm + "e",
                        Singular_2Person = verbStamm + "st",
                        Singular_3Person = verbStamm + "t",
                        Plural_1Person = verbStamm + "en",
                        Plural_2Person = verbStamm + "t",
                        Plural_3Person = verbStamm + "en"
                    };
                    break;
            }

            return returnValue;
        }
    }
}
