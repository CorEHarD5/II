using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLookAt : MonoBehaviour
{
  public Transform target;

  // Start is called before the first frame update
  void Start() {
    CylinderTypeA.eventCloseA += SphereLook;
  }

  void SphereLook() {
    transform.LookAt(target);
  }
}
