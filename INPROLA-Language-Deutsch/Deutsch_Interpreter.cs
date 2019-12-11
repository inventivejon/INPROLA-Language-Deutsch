using System;

namespace INPROLA_Language_Deutsch
{
    public class Deutsch_Interpreter
    {
        public enum Wortart
        {
            Verben,
            Artikel,
            Nomen,
            Pronomen,
            Numerale,
            Adjektive,
            Adverbien,
            Interjektionen,
            Konjunktionen,
            Praepositionen
        }

        public enum ArtikelType
        {
            Unbestimmt,
            Bestimmt
        }

        /// <summary>
        /// Bezüglich ihrer Verwendung unterscheiden wir in Vollverben, Hilfsverben und Modalverben.
        /// </summary>
        public enum VerbUsage
        {
            Vollverb,
            Hilfsverb,
            Modalverb
        }

        /// <summary>
        /// Sie untergliedern sich in starke (unregelmäßige) und schwache (regelmäßige) Verben, wobei es durchaus Mischformen gibt.
        /// </summary>
        public enum VerbType
        {
            Unregelmaessig,
            Regelmaessig
        }

        public class singleWordInformation
        {
            public string Word;
            public Wortart thisWortart;
            public bool Flektierbar;
            public VerbType thisVerbType;
            public ArtikelType thisArtikelType;
            public string ArtikelContent;
            public VerbUsage thisVerbUsage;

            public override string ToString()
            {
                return $"Wort: {Word} - Flektierbar: {Flektierbar}";
            }
        }

        private bool IsFlektierbar(Wortart singleWortart)
        {
            bool isFlektierbar; /* TRUE in case of ja */

            //Flektierbar meint, dass sich die Wortart deklinieren oder konjugieren lässt und sich somit an den Satz anpasst.

            //Verben, Artikel, Nomen, Pronomen, Numerale, Adjektive sind flektierbar;
            //Adverbien, Interjektionen, Konjunktionen, Präpositionen nicht.
            switch (singleWortart)
            {
                case Wortart.Verben:
                case Wortart.Artikel:
                case Wortart.Nomen:
                case Wortart.Pronomen:
                case Wortart.Numerale:
                case Wortart.Adjektive:
                default:
                    isFlektierbar = true;
                    break;

                case Wortart.Adverbien:
                case Wortart.Interjektionen:
                case Wortart.Konjunktionen:
                case Wortart.Praepositionen:
                    isFlektierbar = false;
                    break;
            }

            return isFlektierbar;
        }

        public Deutsch_Interpreter()
        {

        }

        public singleWordInformation Determine_Word(string word)
        {
            return new singleWordInformation
            {
                Word = word,
                thisWortart = Wortart.Verben,
                thisVerbType = VerbType.Regelmaessig,
                thisArtikelType = ArtikelType.Unbestimmt,
                thisVerbUsage = VerbUsage.Vollverb,
                Flektierbar = IsFlektierbar(Wortart.Verben)
            };
        }
    }
}
