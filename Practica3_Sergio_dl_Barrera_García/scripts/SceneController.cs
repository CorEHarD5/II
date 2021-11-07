using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
  public delegate void mooveDelegate();
  public static event mooveDelegate eventMooveW;
  public static event mooveDelegate eventMooveA;
  public static event mooveDelegate eventMooveS;
  public static event mooveDelegate eventMooveD;

  void Update() {
    if (Input.GetKey(KeyCode.W)) {
      if (eventMooveW != null) 
        eventMooveW();
    }

    else if (Input.GetKey(KeyCode.A)) {
      if (eventMooveA != null) 
        eventMooveA();
    }

    else if (Input.GetKey(KeyCode.S)) {
      if (eventMooveS != null) 
        eventMooveS();
    }

    else if (Input.GetKey(KeyCode.D)) {
      if (eventMooveD != null) 
        eventMooveD();
    }
    
  }
}
