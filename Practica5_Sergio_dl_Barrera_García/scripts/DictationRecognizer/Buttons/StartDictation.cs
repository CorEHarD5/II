using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDictation : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateStartDictation();
  public static event MethodDelegateStartDictation eventStartDictation;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (startDictation);
  }

  void startDictation() {
    eventStartDictation();
  }
}