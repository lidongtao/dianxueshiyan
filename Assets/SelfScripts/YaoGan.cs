namespace VRTK.Examples
{
    using UnityEngine;

    public class YaoGan : VRTK_InteractableObject
    {


        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
        }
        public override void Grabbed(VRTK_InteractGrab currentGrabbingObject = null)
        {
            base.Grabbed(currentGrabbingObject);
            //HuaDongController._instance.isZhuanDong = true;

        }
        public override void OnInteractableObjectGrabbed(InteractableObjectEventArgs e)
        {
            base.OnInteractableObjectGrabbed(e);
            HuaDongController._instance.isZhuanDong = true;

        }
        public override void OnInteractableObjectUngrabbed(InteractableObjectEventArgs e)
        {
            base.OnInteractableObjectUngrabbed(e);
            HuaDongController._instance.isZhuanDong = false;

        }
        protected void Start()
        {

        }

        protected override void Update()
        {
            base.Update();

        }



    }
}