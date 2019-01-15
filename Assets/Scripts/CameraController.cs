using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    //public Transform sphere;
    public float speed = 1.0f;

    private Transform center;
    private Vector3 offset;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
        transform.Rotate(Input.GetAxis("Mouse Y") * speed * 0, Input.GetAxis("Mouse X") * speed * 0, 0.0f);
        //center = new GameObject().transform;
        //center.parent = sphere;
        //center.position = Vector3.zero;
        //transform.parent = center;
    }

        // Update is called once per frame
        void LateUpdate () {
        transform.position = player.transform.position + offset;

        //center.position = sphere.position;
        if (Input.GetMouseButton(0))
            transform.Rotate(Input.GetAxis("Mouse Y") * speed * 0, Input.GetAxis("Mouse X") * speed, 0.0f);
    }
}

