using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopDictation : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateStopDictation();
  public static event MethodDelegateStopDictation eventStopDictation;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (stopDictation);
  }

  void stopDictation() {
    eventStopDictation();
  }
}
