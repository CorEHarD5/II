using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderTypeB : MonoBehaviour
{
  // Start is called before the first frame update
  void Start() {
    CylinderTypeA.eventCloseA += changeColorCylinder;
  }

  void changeColorCylinder() {
    Renderer cylinderColor = GetComponent<Renderer>();
    cylinderColor.material.SetColor("_Color", Color.blue);   
  }
}
