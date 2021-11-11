using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopVideo : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegateStopVideo();
  public static event MethodDelegateStopVideo eventStopVideo;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (Stop);
  }

  void Stop() {
      eventStopVideo();
  }
}