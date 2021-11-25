using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndKeyword : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateEndKeyword();
  public static event MethodDelegateEndKeyword eventEndKeyword;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (endKeyword);
  }

  void endKeyword() {
    eventEndKeyword();
  }
}