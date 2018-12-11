namespace VRTK.Examples
{
   
    using UnityEngine;

    public class LightButtonRed : VRTK_InteractableObject
    {
        public GameObject Redlights;
        public GameObject Greenlights;
        // Use this for initialization
        protected void Start() {
            

        }

        // Update is called once per frame
        protected override void Update() {

        }
        public override void StartUsing(VRTK_InteractUse usingObject) {
            base.StartUsing(usingObject);
            Redlights.SetActive(true);
            Greenlights.SetActive(false);
         
        }
    }

}