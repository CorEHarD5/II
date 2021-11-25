using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDictation : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateEndDictation();
  public static event MethodDelegateEndDictation eventEndDictation;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (endDictationEndDictation);
  }

  void endDictationEndDictation() {
    eventEndDictation();
  }
}
