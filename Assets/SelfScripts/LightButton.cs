namespace VRTK.Examples
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class LightButton : VRTK_InteractableObject
    {
        public GameObject Greenlights;
        public GameObject Redlights;
        // Use this for initialization
        protected void Start() {
            Greenlights.SetActive(false);
            Redlights.SetActive(true);
        }

        // Update is called once per frame
        protected override void Update() {

        }
        public override void StartUsing(VRTK_InteractUse usingObject) {
            base.StartUsing(usingObject);
            Greenlights.SetActive(true);
            Redlights.SetActive(false);
            print("绿灯亮，红灯灭");
        }
    }

}
