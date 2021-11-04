using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

  private Transform transformObject;
  public float speed = 3f;
  public float speedRotation = 100f;


  void Start() {
    transformObject = GetComponent<Transform>();      
  }

  void Update() {

    if (Input.GetKey(KeyCode.W))
      transformObject.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
    
    if (Input.GetKey(KeyCode.S))
      transformObject.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;

    if (Input.GetKey(KeyCode.A))
      transformObject.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;

    if (Input.GetKey(KeyCode.D))
      transformObject.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;      
  }
}