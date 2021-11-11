using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordMicro : MonoBehaviour {
  public AudioSource micro;

  void Start() {
    micro = GetComponent<AudioSource>();

    StartMicro.eventStartMicro += startMicro;
    PlayMicro.eventPlayMicro += playMicro;
    EndMicro.eventEndMicro += endMicro;
  }

  void startMicro () {
    micro.clip = Microphone.Start("", true, 8, 44100);
  }
  
  void playMicro () {
    micro.Play();
  }

  void endMicro () {
    Microphone.End("");
  }
}