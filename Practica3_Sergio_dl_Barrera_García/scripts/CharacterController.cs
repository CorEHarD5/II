using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
  private Transform transformObject;
  public float speed = 3f;
  public float speedRotation = 10f;
  // Start is called before the first frame update
  void Start() {
    transformObject = GetComponent<Transform>();
  }

  // Update is called once per frame
  void Update() {
    float xDirection = Input.GetAxis("Horizontal");
    float zDirection = Input.GetAxis("Vertical");

    Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
    transformObject.position += moveDirection * speed * Time.deltaTime;

    if (Input.GetKey(KeyCode.Q))
        transformObject.Rotate(0, -1 * speedRotation * Time.deltaTime, 0);
    if (Input.GetKey(KeyCode.E))
        transformObject.Rotate(0, 1 * speedRotation * Time.deltaTime, 0);
  }


}