using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCylinder : MonoBehaviour {

  private GameObject player;
  public float distanceBetweenObjects = 3f;

  void Start() {
    player = GameObject.Find("Player");
  }

  void Update() {  
    float distance = Vector3.Distance(transform.position, player.transform.position);
    
    if (distance <= distanceBetweenObjects) {
      Vector3 direction = transform.position - player.transform.position;  
      transform.Translate(direction * distanceBetweenObjects * Time.deltaTime);    
    }
  }
}