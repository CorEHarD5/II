using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class Dictation : MonoBehaviour {
  
  public DictationRecognizer m_DictationRecognizer;

  void Start() {
    m_DictationRecognizer = new DictationRecognizer();
    StartDictation.eventStartDictation += startDictation;
    StopDictation.eventStopDictation += stopDictation;
    EndDictation.eventEndDictation += endDictation;
  }

  void DictationRecognizer() {
    m_DictationRecognizer.DictationResult += (text, confidence) => {
      Debug.LogFormat("Resultado: {0}", text);
    };
    m_DictationRecognizer.DictationHypothesis += (text) => {
      Debug.LogFormat("Hypothesis: {0}", text);
    };
  }

  void startDictation () {
    m_DictationRecognizer.Start();
    DictationRecognizer();
  }

   void stopDictation () {
    m_DictationRecognizer.Stop();
    Debug.LogFormat("Estado: {0}", m_DictationRecognizer.Status);
  }

  void endDictation () {
    m_DictationRecognizer.Dispose();
    Debug.LogFormat("Estado: {0}", m_DictationRecognizer.Status);
  }
}