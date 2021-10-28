using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementObject : MonoBehaviour {

  private Transform transformObject;
  public float speed = 3f;
  public float speedRotation = 100f;


  void Start() {
    transformObject = GetComponent<Transform>();      
  }

  void Update() {

    if (Input.GetKey(KeyCode.I))
      transformObject.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
    
    if (Input.GetKey(KeyCode.M))
      transformObject.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;

    if (Input.GetKey(KeyCode.J))
      transformObject.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;

    if (Input.GetKey(KeyCode.L))
      transformObject.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;    

    if (Input.GetKey(KeyCode.U))
      transformObject.Rotate(0, -1 * speedRotation * Time.deltaTime, 0);
    
    if (Input.GetKey(KeyCode.P))
      transformObject.Rotate(0, 1 * speedRotation * Time.deltaTime, 0);      
  }
}