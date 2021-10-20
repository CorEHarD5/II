using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_personaje : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("2. Objeto personaje")
    }

    // Update is called once per frame
    void Update() {
        int y = y + 1;
        Debug.Log("Contador personaje= " + y);
    }
}
