using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_coche : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Debug.Log("3. Objeto coche")
    }

    // Update is called once per frame
    void Update() {
        int z = z + 1;
        Debug.Log("Contador coche= " + z);
    }
}
