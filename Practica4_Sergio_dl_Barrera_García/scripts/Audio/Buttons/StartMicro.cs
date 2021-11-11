using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMicro : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateStartMicro();
  public static event MethodDelegateStartMicro eventStartMicro;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (startMicro);
  }

  void startMicro() {
    eventStartMicro();
  }
}