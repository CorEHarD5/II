using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectB : MonoBehaviour {
  public delegate void MethodDelegateCollisionB();
  public static event MethodDelegateCollisionB eventCollisionWithB;

  public int strength = 0;

  void Start() {    
    ObjectA.eventCollisionWithA += sumCounterByCollisionPlayerWithA;
  }

  void OnCollisionEnter(Collision other) {
    if (other.gameObject.name == "Player" && eventCollisionWithB != null)
      eventCollisionWithB();
  }


  void sumCounterByCollisionPlayerWithA() {
    strength++;
    Debug.Log("Strength = " + strength);
  }

}