using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMicro : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegatePlayMicro();
  public static event MethodDelegatePlayMicro eventPlayMicro;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (playMicro);
  }

  void playMicro() {
    eventPlayMicro();
  }
}