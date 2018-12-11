namespace VRTK.Examples
{
    using UnityEngine;

    public class RedButton : VRTK_InteractableObject
    {
        //public bool flipped = false;
        //public bool rotated = false;

        //private float sideFlip = -1;
        //private float side = -1;
        private float smooth = 270.0f;
        //private float doorOpenAngle = -20f;
        private bool open = false;

        private Vector3 defaultRotation;
        //private Vector3 openRotation;
        Quaternion targetAngels;
        float rotateSpeed = 50f;
        public GameObject redLight;
        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            //SetDoorRotation(usingObject.transform.position);
            //SetRotation();
            open = !open;
        }

        protected void Start()
        {
            targetAngels = Quaternion.Euler(-106, 90, -90);
            //transform.rotation = Quaternion.Euler(new Vector3(-90, 90, -90));
            defaultRotation = transform.eulerAngles;
            //SetRotation();
            //sideFlip = (flipped ? 1 : -1);
            redLight.SetActive(false);
        }

        protected override void Update()
        {
            base.Update();
            if (open)
            {
                //float x= Mathf.Clamp(transform.rotation.x,-106,-76);
                //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(openRotation), Time.deltaTime * smooth);
                //transform.Rotate(Vector3.down,30, Space.Self);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetAngels, rotateSpeed * Time.deltaTime);
                // 当初始角度跟目标角度小于1,将目标角度赋值给初始角度,让旋转角度是我们需要的角度
                if (Quaternion.Angle(targetAngels, transform.rotation) < 1)
                {
                    transform.rotation = targetAngels;
                }
                redLight.SetActive(true);
            }
            else
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(defaultRotation), Time.deltaTime * smooth);
                redLight.SetActive(false);
            }
        }

        //private void SetRotation()
        //{
        //    openRotation = new Vector3(defaultRotation.x + (doorOpenAngle * (sideFlip * side)), defaultRotation.y, defaultRotation.z);
        //}

        //private void SetDoorRotation(Vector3 interacterPosition)
        //{
        //    side = ((rotated == false && interacterPosition.z > transform.position.z) || (rotated == true && interacterPosition.x > transform.position.x) ? -1 : 1);
        //}
    }
}