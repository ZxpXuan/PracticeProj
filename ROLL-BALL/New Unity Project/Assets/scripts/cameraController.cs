using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
    public GameObject PPlayer;
    private Vector3 offset;
	// Use this for initialization
	void Start () {     
        offset = transform.position- PPlayer.transform.position;

	}
	
	// Update is called once per frame
	void LateUpdate () {

        transform.position = PPlayer.transform.position + offset;

    }
}
