using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YiBiaoPan : MonoBehaviour
{

    public float angel = 57;
    public int count = 0;
    public int countLevel = 5;
    public Slider slider;
    float rotateSpeed=3f;
    private void Start()
    {

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {

            //count++;
            //float rotateAngel = (-Mathf.Cos(Mathf.PI / (countLevel - 1) * count) + 1) * angel;
            //Debug.Log(rotateAngel);

            //    transform.localEulerAngles = new Vector3(0, 0, 75 - rotateAngel);
            count++;
            float rotateAngel = count * angel;
            //if (transform.localEulerAngles.z >= 275)
            //{
            //    transform.localEulerAngles = new Vector3(0, 0, 75 - rotateAngel);
            //}
            //else
            //{
            //    transform.localEulerAngles = new Vector3(0, 0, 75 + rotateAngel);
            //}
            transform.localEulerAngles = new Vector3(0, 0, 75 - rotateAngel);
            Debug.Log(transform.localEulerAngles.z);
            //transform.localEulerAngles = new Vector3(0, 0, 75 - rotateAngel);
           
        }
        transform.localRotation = Quaternion.Slerp(transform.localRotation,
           Quaternion.Euler(Vector3.back * slider.value), rotateSpeed * Time.deltaTime);
    }
    
    void RotationFunction()
    {
    
        transform.localRotation = Quaternion.Slerp(transform.localRotation,
           Quaternion.Euler(Vector3.back * slider.value),rotateSpeed * Time.deltaTime);
    }
}
