using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Login_System
{
    class MedicalAssistance
    {
        Label lbl;
        DatabaseIO DBIO;
        SpeechRecognitionEngine engine;
        SpeechSynthesizer synth;
        string word;
        public MedicalAssistance()
        {
            DBIO = new DatabaseIO();
            engine = new SpeechRecognitionEngine();
            engine.SetInputToDefaultAudioDevice();
            Grammar g = this.GetGrammer();
            engine.LoadGrammar(g);
            engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Speech_Recognized);
            engine.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(Recognition_Completed);
            engine.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(Hypothesis_Speech);

            synth = new SpeechSynthesizer();
            synth.Rate = -3;
            synth.Volume = 100;
            synth.SelectVoiceByHints(VoiceGender.Male);
            synth.SetOutputToDefaultAudioDevice();
        }

        private Grammar GetGrammer()
        {
            Choices ch = new Choices(new string[] { "fever", "asthma", "cough", "headache","gas" });
            GrammarBuilder gb = new GrammarBuilder(ch);
            return new Grammar(gb);
        }

        private void Hypothesis_Speech(object sender, SpeechHypothesizedEventArgs e)
        {
            word = e.Result.Text;
            Console.WriteLine(word);
        }

        private void Recognition_Completed(object sender, RecognizeCompletedEventArgs e)
        {
            string speech = "Medicines for "+word+ " are";
            List<string> names = DBIO.GetMedicalAssistantSpeech(word);

            if (names.Count == 0)
                synth.Speak("sorry no medicine found in inventory");
            else
            {
                foreach (string name in names)
                {
                    speech = speech +"  "+name;
                }
                
                synth.Speak(speech);
                lbl.Text = "Need Help?";
            }
        }

        private void Speech_Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            word = e.Result.Text;
            Console.WriteLine(word);
        }

        public void Start(Label lbl)
        {
            this.lbl = lbl;
            try
            {
                synth.Speak("welcome sir please tell the disease name");
                engine.RecognizeAsync(RecognizeMode.Single);
                lbl.Text = "Listening..";
            }
            catch (Exception)
            {
                synth.Speak("Sorry please wait");
            }
        }

    }
}
