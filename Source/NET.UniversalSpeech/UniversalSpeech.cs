// You need to download the Quentin C's UniversalSpeech from http://www.quentinc.net/UniversalSpeech website.
// Only the UniversalSpeech bynaries are included here.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NET.UniversalSpeech
{
    /// <summary>
    ///  UniversalSpeech class
    /// </summary>
    public class UniversalSpeech
    {
        // Exports from the UniversalSpeech.dll
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Unicode)]
        private static extern int speechSay(string strMessage, int nInterruption);
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Ansi)]
        private static extern int speechSayA(string strMessage, int nInterruption);
        // An ANSI version of the function above
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Unicode)]
        private static extern int brailleDisplay(string strMessage);
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Ansi)]
        private static extern int brailleDisplayA(string strMessage);
        // An ANSI version of the function above
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Unicode)]
        private static extern int speechGetValue(int nParameter);
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Unicode)]
        private static extern string speechGetString(int nParameter);
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Ansi)]
        private static extern string speechGetStringA(int nParameter);
        // An ANSI version of the function above
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Unicode)]
        private static extern int speechSetValue(int nParameter, int nValue);
                [DllImport("UniversalSpeech.dll", CharSet = CharSet.Unicode)]
private static extern int speechSetString(int nParameter, string strValue);
        [DllImport ("UniversalSpeech.dll", CharSet = CharSet.Ansi)]
                private static extern int speechSetStringA(int nParameter, string strValue);
        // An ANSI version of the function above
        [DllImport("UniversalSpeech.dll", CharSet = CharSet.Unicode)]
        private static extern int speechStop();


        // Speech parameters enumeration
        public enum SpeechParameters
        {
            /** The following few values are in groupes of 4 parameters. 
            + First one is used to get or set the current value for this parameter
            + Second and third one are used to retriev the minimum and the maximum values allowed for the parameter
            + Last one is used to query if the currently active engine, subengine, language and voice supports the parameter. If 0 is returned, then the parameter isn't supported. Any other value different than 0 means that the parameter is supported and thus can be get or set. A supported parameter may be read only and thus refuse any attend to change the value.
            */

            /** Speech volume. smaller values usually means quieter, and bigger values mean louder. Often, 0 means completely silent.   */
            SP_VOLUME, SP_VOLUME_MAX, SP_VOLUME_MIN, SP_VOLUME_SUPPORTED,

            /** Speech rate, a.k.a speed. Small valuers usually mean slower, and bigger values mean faster. No unit such as words per minute is enforced. */
            SP_RATE, SP_RATE_MAX, SP_RATE_MIN, SP_RATE_SUPPORTED,

            /** Voice pitch. Usually small values stands for lower pitch, bigger values for higher pitch.  */
            SP_PITCH, SP_PITCH_MAX, SP_PITCH_MIN, SP_PITCH_SUPPORTED,

            /** Voice inflexion, a.k.a pitch fluctuation or emotivity. Smaller values usually means a monotone speech like a robot, while bigger values means a voice which seems excited and which exagerate pitch elevation when interpreting punctuation. . */
            SP_INFLEXION, SP_INFLEXION_MAX, SP_INFLEXION_MIN, SP_INFLEXION_SUPPORTED,

            /** Pausing the speech while it is in progress. 0 means off, and any value different than 0 means on. */
            SP_PAUSED, SP_PAUSE_SUPPORTED,

            /** Querying if a speech is currently in progress (read only parameter). 0 means no, any other value means yes. */
            SP_BUSY, SP_BUSY_SUPPORTED,

            /** Wait for the speech to finish. Use speechGetValue with this parameter to wait indefinitely for the current speech to finish. Use speechSetValue with a number of milliseconds to wait at most the specified time for the current speech to finish. */
            SP_WAIT, SP_WAIT_SUPPORTED,

            /** Enable or disable specific OS speech engines that can in principle never fail, such as SAPI5 on windows. 0 means disabled, any other value means enabled. This parameter is disabled by default. */
            SP_ENABLE_NATIVE_SPEECH = 0xFFFF,

            /** Voice specific to the current engine.
            Some engines supports different voices. Screen readers usually do not provite that in their API, but multiple voices can be installed into OS specific engines such as SAPI5. This parameter is used to get or set the current voice (0-based index), or to query for voices names.
            + use speechGetValue with this parameter to query the currently selected voice, as a 0-based index
            + Use speechSetValue with this parameter to set the current voice, as a 0-based index
            + use speechGetString with this parameter + n to retriev the voice name of the nth 0-based index voice, i.e. speechGetString(SP_VOICE+5) to retriev the name of the 6th voice. You can iterate starting at 0 until you get NULL to discover how many voices the current engine has.
            */
            SP_VOICE = 0x10000,

            /** Same principle as voices but for languages. Some engines allow to change dynamically the speech language. Note that the list of available voices may change following a language change, depending on how the engine works. */
            SP_LANGUAGE = 0x20000,

            /** Same principle as voices and languages but for sub-engines. Some engines are in fact wrappers that can handle a collection of engines, such as speech dispatcher on linux. This parameter allow to select an engine out of an engine wrapper. In general, languages and voices available changes following a sub-engine change. */
            SP_SUBENGINE = 0x30000,

            /** Always the same principle, but this time for top-level engines. Being present on the list does not necessarily mean that the engine is available and working. Generally, you will let the user select one of the supported ones. 
            By default, the system automatically select the first available and working engine, and switch automatically to another engine when the current one become unavailable.
            When querying, it returns the actual current engine used as 0-based index. A return value of -1 means that the system didn't find any suitable engine to work with.
            By setting the engine to a positive value, you force the system to use this engine, even if it is in fact inoperant.
            You can restore the default behavior by setting the engine to -1.
            */
            SP_ENGINE = 0x40000,

            /** Engine availability
            Still the same principle, but for engine availability. Query for example the parameter SP_ENGINE_AVAILABLE+3 to determine if 4th engine is currently available and working if you select it.
            0 means unavailable, any other value mean available. 
            Normally, if you loop for names with SP_ENGINE+n, you will get all engines names supported by universal speech, not necessarily those which are really ready to be used. Querying for actual availability allow you to filter the list presented to the user.
            */
            SP_ENGINE_AVAILABLE = 0x50000,

            /** Query if default automatic detection is used or not */
            SP_AUTO_ENGINE = 0xFFFE,

            /** Some engines or subengines may give access to additionnal specific parameters
            Engine wrapper devloppers shouldn't use a parameter identifier below this value, to ensure that there wont be any conflict with a standard parameter (one of the above)
            */
            SP_USER_PARAM = 0x1000000
        };

        
        // Constructor
        /// <summary>
        ///  Creates an instance of the UniversalSpeech class.
        /// </summary>
        public UniversalSpeech()
                {
                    // This is constructor only to get the documentation when instancing this class.
                }
        // UniversalSpeech .NET functions

        /// <summary>
        ///  Sends a Unicode text message to the speech engine.
        /// </summary>
        /// <param name="strMessage">A Unicode text string sent to the speech engine</param>
        /// <param name="nInterruption">An integer number which represents the speaking interruption. If 0, the previous message will be spoken. If greater, the previously spoken message will be interrupted.</param>
        /// <returns></returns>
        public int SpeechSay(string strMessage, int nInterruption)
        {
            // Returns speechSay
            return speechSay(strMessage, nInterruption);
        }
        /// <summary>
        ///  Sends an ANSI text message to the speech engine.
        /// </summary>
        /// <param name="strMessage">An ANSI text string sent to the speech engine</param>
        /// <param name="nInterruption">An integer number which represents the speaking interruption. If 0, the previous message will be spoken. If greater, the previously spoken message will be interrupted.</param>
        /// <returns></returns>
        public int SpeechSayA(string strMessage, int nInterruption)
        {
            // Returns speechSayA
            return speechSayA(strMessage, nInterruption);
        }
        /// <summary>
        ///  Sends a Unicode text message to the Braille display.
        /// </summary>
        /// <param name="strMessage">A Unicode text string sent to the Braille display</param>
        /// <returns></returns>
        public int BrailleDisplay(string strMessage)
        {
            // Returns brailleDisplay
            return brailleDisplay(strMessage);
        }
        /// <summary>
        ///  Sends an ANSI text message to the Braille display.
        /// </summary>
        /// <param name="strMessage">An ANSI text string sent to the Braille display</param>
        /// <returns></returns>
        public int BrailleDisplayA(string strMessage)
        {
            // Returns brailleDisplayA
            return brailleDisplayA(strMessage);
        }
        /// <summary>
        ///  Gets the integer value for the speech parameter from the enum SpeechParameters.
        /// </summary>
        /// <param name="nParameter">A given parameter from the enum SpeechParameters. This parameter should be int.</param>
        /// <returns>Returns an integer value</returns>
        public int SpeechGetValue(int nParameter)
        {
            // Returns speechGetValue for the given parameter
            return speechGetValue(nParameter);
        }
        /// <summary>
        ///  Sets a new integer value for the speech parameter from the enum SpeechParameters.
        /// </summary>
        /// <param name="nParameter">A given parameter from the enum SpeechParameters. This parameter should be int.</param>
        /// <param name="nValue">A new value for the given parameter from the enum SpeechParameters. This parameter should be int.</param>
        /// <returns></returns>
        public int SpeechSetValue(int nParameter, int nValue)
        {
            // Returns speechSetValue where the nParameter is the given parameter, and nValue is a new value for that parameter.
            return speechSetValue(nParameter, nValue);
        }
        /// <summary>
        ///  Gets the Unicode text string value for the speech parameter from the enum SpeechParameters.
        /// </summary>
        /// <param name="nParameter">A given parameter from the enum SpeechParameters. This parameter should be int.</param>
        /// <returns>Returns a Unicode text string value</returns>
        public string SpeechGetString(int nParameter)
        {
            // Returns speechGetString for the given parameter
            return speechGetString(nParameter);
        }
        /// <summary>
        ///  Gets the ANSI text string value for the speech parameter from the enum SpeechParameters.
        /// </summary>
        /// <param name="nParameter">A given parameter from the enum SpeechParameters. This parameter should be int.</param>
        /// <returns>Returns an ANSI text string value</returns>
        public string SpeechGetStringA(int nParameter)
        {
            // Returns an ANSI version of speechGetString
            return speechGetStringA(nParameter);
        }
        /// <summary>
        ///  Sets a new Unicode text string value for the speech parameter from the enum SpeechParameters.
        /// </summary>
        /// <param name="nParameter">A given parameter from the enum SpeechParameters. This parameter should be int.</param>
        /// <param name="nValue">A new value for the given parameter from the enum SpeechParameters. This parameter should be a Unicode text string.</param>
        /// <returns></returns>
        public int SpeechSetString(int nParameter, string strValue)
        {
// Returns speechSetString
            return speechSetString(nParameter, strValue);
        }
        /// <summary>
        ///  Sets a new ANSI text string value for the speech parameter from the enum SpeechParameters.
        /// </summary>
        /// <param name="nParameter">A given parameter from the enum SpeechParameters. This parameter should be int.</param>
        /// <param name="nValue">A new value for the given parameter from the enum SpeechParameters. This parameter should be an ANSI text string.</param>
        /// <returns></returns>
        public int SpeechSetStringA(int nParameter, string strValue)
        {
            // Returns an ANSI version of speechSetString
            return speechSetStringA(nParameter, strValue);
        }
        /// <summary>
        ///  Immediately stops speaking.
        /// </summary>
        /// <returns></returns>
public int SpeechStop()
{
    // Returns speechStop
    return speechStop();
}
    }
}
