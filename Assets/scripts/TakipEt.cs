using UnityEngine;

public class TakipEt : MonoBehaviour
{
    public GameObject takipObjesi;
    float y_uzakligi;
    void Start()
    {
        y_uzakligi = takipObjesi.transform.position.y + transform.position.y;
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(takipObjesi.transform.position.x, y_uzakligi, takipObjesi.transform.position.z);
    }
}
