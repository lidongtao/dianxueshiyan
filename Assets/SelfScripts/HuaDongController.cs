using UnityEngine;

public class HuaDongController : MonoBehaviour

{
    public static HuaDongController _instance;
    private void Awake()
    {
        _instance = this;
    }
    public bool isZhuanDong;
    //public Vector3 lastPosition;
    public float oldRotation;
    public bool isZ;
    public float distance;
    public Transform slip;
    private float point;
    private float xi = 0.001f;
    float posY;
    float posZ;
    private void Start()
    {
        point_new = slip.localPosition.x;
        Debug.Log("point=" + point);
        posY= slip.localPosition.y;
        posZ= slip.localPosition.z;
    }
    private void Update()
    {
        //oldRotation = transform.localEulerAngles.x;
        if (isZhuanDong)
        {
            JiLu();
            Debug.Log("yes");
        }
        else
        {
            Debug.Log("no");
        }
    }
    float point_new;
    float tempRotation;
    private void JiLu()
    {

        tempRotation = transform.localEulerAngles.x;
        //distance = Vector3.Distance(tempPosition, oldPosition);
        distance = oldRotation - tempRotation;
        Debug.Log("distance="+distance);

        //point_new += distance * xi;
        point_new =  distance /360*0.4f;
        point_new = Mathf.Clamp(point_new, -0.157f, 0.187f);
        Debug.Log("point_new=" + point_new);
        slip.localPosition = new Vector3(point_new, posY, posZ);
        oldRotation = tempRotation;
    }
}
