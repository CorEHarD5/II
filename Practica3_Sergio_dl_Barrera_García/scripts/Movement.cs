using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

  private Transform transformObject;
  public float speed = 3f;
  public float speedRotation = 100f;


  void Start() {
    transformObject = GetComponent<Transform>();
    SceneController.eventMooveW += getMooveToW;
    SceneController.eventMooveA += getMooveToA;
    SceneController.eventMooveS += getMooveToS;
    SceneController.eventMooveD += getMooveToD;
  }

  void getMooveToW() {
    transformObject.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
  }

  void getMooveToA() {
    transformObject.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
  } 

  void getMooveToS() {
    transformObject.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;
  }
  
  void getMooveToD() {
    transformObject.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;  
  }
          
}