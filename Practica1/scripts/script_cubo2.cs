using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_cubo2 : MonoBehaviour {
    private const int ID = 2;
    int counter;
    // Start is called before the first frame update
    void Start() {
        counter = 0;
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("\t Nombre del objeto: " + gameObject.name
                    + "\t Tag: " + gameObject.tag 
                    + "\t Identificador: " + ID
                    + "\t Contador: " + counter
        );
        counter++;
    }
}