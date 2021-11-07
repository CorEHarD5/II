using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderTypeA : MonoBehaviour
{
  public delegate void MethodDelegateCloseA();
  public static event MethodDelegateCloseA eventCloseA;
    

  public float minDistance = 3f;
  GameObject player; 
 
  // Start is called before the first frame update
  void Start() {
    player = GameObject.Find("Player");  
  }

  void Update() {
    float distanceWithPlayer = Vector3.Distance(transform.position, player.transform.position);

    if (distanceWithPlayer <= minDistance) {
      eventCloseA();
    }
  }
}
