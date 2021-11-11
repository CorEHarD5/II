using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {
  Button btn;
  public delegate void MethodDelegatePlayVideo();
  public static event MethodDelegatePlayVideo eventPlayVideo;

  void Start() {
    btn = GetComponent<Button>();
    btn.onClick.AddListener (Play);
  }

  void Play() {
      eventPlayVideo();
  }
}