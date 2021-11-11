using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseVideo : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegatePauseVideo();
  public static event MethodDelegatePauseVideo eventPauseVideo;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (Pause);
  }

  void Pause() {
      eventPauseVideo();
  }
}