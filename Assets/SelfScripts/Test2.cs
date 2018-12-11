
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Test2 : MonoBehaviour
    {
        public float k = 1.0f;//speed
        private float deltaAngel = 0f;
        public Transform slip;
        private float point ;
            

        // Use this for initialization
        void Start() {
            point = slip.position.x;
        }
  void Update() {
         
            if (Input.GetKeyDown(KeyCode.Space)) {
                deltaAngel += Time.deltaTime * k;
                Debug.Log(deltaAngel);
            }
            else if (Input.GetKey(KeyCode.X)) {
                deltaAngel-= Time.deltaTime * k;

            }
            deltaAngel = Mathf.Clamp(deltaAngel,0f, 360f);
            Vector3 angel = new Vector3(deltaAngel, 0, 0);
        transform.rotation = Quaternion.Euler(angel);

            float point_new = point + deltaAngel / (360 * 0.35f);
            slip.position = new Vector3(point_new, slip.position.y, slip.position.z);

        }

        
    }
