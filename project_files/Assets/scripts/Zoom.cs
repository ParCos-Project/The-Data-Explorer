using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class Zoom : MonoBehaviour {
 
 //variables for zoom
 public float zoomSpeed = 100;
 public float targetOrtho;
 public float smoothSpeed = 200f;
 public float minOrtho = 80f;
 public float maxOrtho = 400f;
 
 void Start() {
     targetOrtho = Camera.main.orthographicSize;
 }
 
 void Update () {
     
     //zoom code
     float scroll = Input.GetAxis ("Mouse ScrollWheel");
     if (scroll != 0.0f) {
         targetOrtho -= scroll * zoomSpeed;
         targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
     }
     
     Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
 }

 }
