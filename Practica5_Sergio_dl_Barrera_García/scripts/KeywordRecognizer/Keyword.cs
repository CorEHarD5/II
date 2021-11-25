using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Keyword : MonoBehaviour {
  private string[] m_Keywords;
  public KeywordRecognizer m_Recognizer;

  public string word1;
  public string word2;
  public string word3;

  void Start() {
    m_Keywords = new string[] {word1, word2, word3};
    m_Recognizer = new KeywordRecognizer(m_Keywords);
    m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
    
    StartKeyword.eventStartKeyword += startKeyword;
    StopKeyword.eventStopKeyword += stopKeyword;
    EndKeyword.eventEndKeyword += endKeyword;
  }

  private void OnPhraseRecognized(PhraseRecognizedEventArgs args) {
    StringBuilder builder = new StringBuilder();
    builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
    builder.AppendFormat("\tFecha: {0}{1}", args.phraseStartTime, Environment.NewLine);
    builder.AppendFormat("\tDuración: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
    Debug.Log(builder.ToString());
  }

  void startKeyword () {
    m_Recognizer.Start();
  }

  void stopKeyword () {
    m_Recognizer.Stop();
    Debug.LogFormat("Estado (True = Activo/False = Parado): {0}", m_Recognizer.IsRunning);
  }

  void endKeyword () {
    m_Recognizer.Dispose();
    Debug.LogFormat("Estado (True = Activo/False = Parado): {0}", m_Recognizer.IsRunning);
  }
}
