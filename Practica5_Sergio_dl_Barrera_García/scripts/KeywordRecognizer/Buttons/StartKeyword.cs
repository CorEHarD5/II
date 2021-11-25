using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartKeyword : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateStartKeyword();
  public static event MethodDelegateStartKeyword eventStartKeyword;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (startKeyword);
  }

  void startKeyword() {
    eventStartKeyword();
  }
}