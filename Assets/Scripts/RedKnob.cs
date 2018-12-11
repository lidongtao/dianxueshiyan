// Rotator Track Grab Attach|GrabAttachMechanics|50090
namespace VRTK.Examples
{
    using UnityEngine;
    
    enum KnobType
    {
        left,
        mid,
        right
    }
    public class RedKnob : VRTK_InteractableObject
    {

        public float angel = 40;
        public int count = 0;
        public int countLevel = 3;
        
        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            count++;
            float rotateAngel = (-Mathf.Cos(Mathf.PI / (countLevel - 1) * count) + 1) * angel;
            Debug.Log(rotateAngel);
                transform.rotation = Quaternion.Euler(new Vector3(-133+rotateAngel, 0, 0));
            //-133为 初始角度  
            
        }


        //public override void StopUsing(VRTK_InteractUse usingObject)
        //{
        //    base.StopUsing(usingObject);
           
        //}
        protected void Start()
        {
            
        }
        protected override void Update()
        {
            base.Update();
        }
    }
}
