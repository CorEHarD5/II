using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
        
  }

  // Update is called once per frame
  void Update() {
      
  }
  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "Player") {
      if (gameObject.tag == "cylinder") 
        other.transform.localScale *= 1.005f;        
    }
  }
  // private void OnCollisionEnter(Collision other) {
  //   if (other.gameObject.tag == "Player") {
  //     Renderer cylinderColor = GetComponent<Renderer>();
  //     if (gameObject.tag == "cylinder") 
  //      cylinderColor.material.SetColor("_Color", Color.green);          
  //   }
  // }

  // GameObject player;
  // GameObject[] spheres;

  // void Start() {
  //   player  = GameObject.FindWithTag("Player");
  //   spheres = GameObject.FindGameObjectsWithTag("sphere");        
  // }

  // void Update() {
  //   foreach (GameObject sphere in spheres) {
  //     if (Vector3.Distance(sphere.transform.position, transform.position) < 3f) {
  //       if (transform.localScale.x < 3f) 
  //         transform.localScale *= 1.005f; 
  //     }
  //   }

  //   if (Vector3.Distance(transform.position, player.transform.position) < 3f) {
  //     if (transform.localScale.x >= 1f) 
  //       transform.localScale *= 0.5f;
  //   }
  // }
}