using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour {
    public float speed;
    public float rotX = 15;
    public float rotY = 30;
    public float rotZ = 45;
	// Use this for initialization
	void Start () {
        speed = Random.Range(-5f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime * speed);
	}
}
