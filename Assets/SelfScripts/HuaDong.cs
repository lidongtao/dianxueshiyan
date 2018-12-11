using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuaDong : MonoBehaviour {

    public GameObject huaKou;
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        
    }
    public void Move() {
        huaKou.transform.Translate(Vector3.back * Time.deltaTime, Space.World);
    }
}
