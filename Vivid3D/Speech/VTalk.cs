using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Speech.Synthesis;
namespace Vivid.Speech
{
    public enum TalkType
    {
        Async,Block
    }
    public class VTalk
    {
        public SpeechSynthesizer SS;
        public VTalk()
        {
            SS = new SpeechSynthesizer();
        }
        public void Say(string t, TalkType typ = TalkType.Async)
        {
            return;
            if (typ == TalkType.Block)
            {
                SS.Speak(t);
            }
            else
            {
                SS.SpeakAsync(t);
            }
        }
    }
}
