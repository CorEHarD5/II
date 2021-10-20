using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_cubo : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("1. Objeto cubo")
    }

    // Update is called once per frame
    void Update() {
        int x = x + 1;
        Debug.Log("Contador cubo= " + x);
    }
}
