using UnityEngine;

public class ObjeFirlat : MonoBehaviour
{
    public Vector3 hiz;
    public ForceMode force;
    Rigidbody rb;

    // Oyun objesi yüklendiğinde 1 kez çalışır
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Her kare (frame, FPS) çalışır
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(hiz, force);
        }
    }
}
