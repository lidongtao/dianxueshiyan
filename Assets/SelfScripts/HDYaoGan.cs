using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDYaoGan : MonoBehaviour {
    Vector3 vector3;

    public GameObject g;
	void Start () {
       
       
    }
	
	// Update is called once per frame
	void Update () {
        vector3 = transform.rotation.eulerAngles;
        Vector3 b = g.transform.position;
        b.x= vector3.x;
       
        //print(vector3.x);
        print(b.x);
    }

}
