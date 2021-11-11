using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMicro : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateEndMicro();
  public static event MethodDelegateEndMicro eventEndMicro;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (endMicro);
  }

  void endMicro() {
    eventEndMicro();
  }
}