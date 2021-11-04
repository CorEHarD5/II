using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectA : MonoBehaviour {
  public delegate void MethodDelegateCollisionA();
  public static event MethodDelegateCollisionA eventCollisionWithA;
  
  void Start() {
    ObjectB.eventCollisionWithB += MessageCollision;
  }

  void MessageCollision() {    
    Debug.Log("Soy el objeto tipo A, el jugador ha colisionado con B");
  }

  // Colisión de jugador con A
  void OnCollisionEnter(Collision other) {
    if (other.gameObject.name == "Player" && eventCollisionWithA != null)
      eventCollisionWithA();
  }
}