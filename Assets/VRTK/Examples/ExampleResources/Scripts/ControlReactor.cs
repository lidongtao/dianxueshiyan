namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEventHelper;

    public class ControlReactor : MonoBehaviour
    {
        public TextMesh go;

        private VRTK_Control_UnityEvents controlEvents;
        public  Transform huaPian;
        float biLi;
        float pianYi;
        float posY;
        float posZ;
        public float maxValue;
        private void Start()
        {
            posY = huaPian.localPosition.y;
            posZ = huaPian.localPosition.z;
            controlEvents = GetComponent<VRTK_Control_UnityEvents>();
            if (controlEvents == null)
            {
                controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
            }

            controlEvents.OnValueChanged.AddListener(HandleChange);     
        }
     
        private void HandleChange(object sender, Control3DEventArgs e)
        {
            go.text = e.value.ToString() + " Ω"; // normalizedValue: 百分数 20  value 2

            biLi = e.normalizedValue / maxValue;
            pianYi = biLi /** 0.4f*/;
            pianYi = Mathf.Clamp(pianYi, 0, 0.4F);
            huaPian.localPosition = new Vector3(pianYi, posY, posZ);
        }

    }
}