using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopKeyword : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateStopKeyword();
  public static event MethodDelegateStopKeyword eventStopKeyword;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (stopKeyword);
  }

  void stopKeyword() {
    eventStopKeyword();
  }
}
