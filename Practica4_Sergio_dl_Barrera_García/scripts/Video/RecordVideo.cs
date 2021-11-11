using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordVideo : MonoBehaviour {
  public WebCamTexture cam;
  private Renderer render;

  void Start() {
    cam = new WebCamTexture();
    render = GetComponent<Renderer>();

    PlayVideo.eventPlayVideo += playVideo;
    PauseVideo.eventPauseVideo += pauseVideo;
    StopVideo.eventStopVideo += stopVideo;
  }

  void playVideo () {
    cam.Play();
    render.material.mainTexture = cam;
  }
    
  void pauseVideo () {
    cam.Pause();
  }

  void stopVideo () {
    cam.Stop();
  }
}