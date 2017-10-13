using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace Login_System
{
    class SearchSpeechRecognizer
    {
        private SpeechRecognitionEngine engine;
        private TextBox SearchTb;
        private DatabaseIO DBIO;

        public SearchSpeechRecognizer()
        {
            DBIO = new DatabaseIO();
            engine = new SpeechRecognitionEngine();
            engine.SetInputToDefaultAudioDevice();
            engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Speech_Recognized);
            engine.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(Hypothesis_Speech);
        }

        public void StartRecognition(TextBox Tb)
        {
            try
            {
                SearchTb = Tb;
                Grammar g = this.GetGrammar();
                engine.LoadGrammar(g);

                engine.RecognizeAsync(RecognizeMode.Single);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Wait");
            }
           
        }

        private Grammar GetGrammar()
        {
            List<string> Names = DBIO.GetVoiceSearchGrammar();
            string[] names = new string[Names.Count];
            for (int i = 0; i < names.Length; i++)
                names[i] = Names.ElementAt(i);

            Choices ch = new Choices(names);
            GrammarBuilder gb = new GrammarBuilder(ch);

            return new Grammar(gb);
        }

        private void Hypothesis_Speech(object sender, SpeechHypothesizedEventArgs e)
        {
            SearchTb.Text = e.Result.Text;
            Console.WriteLine(e.Result.Text);
        }

        private void Speech_Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            SearchTb.Text = e.Result.Text;
            Console.WriteLine(e.Result.Text);
        }
    }
}
