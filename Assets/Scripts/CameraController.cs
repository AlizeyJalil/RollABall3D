using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        
        offset = transform.position - player.transform.position;
		
	}
	
	// LateUpdate called once per each frame, at the end when all other processes have been encountered with.
	void LateUpdate () {

        transform.position = player.transform.position + offset;
		
	}
}
