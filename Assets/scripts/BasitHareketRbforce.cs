using UnityEngine;

public class BasitHareketRbforce : MonoBehaviour
{
    public float hiz = 20;
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
        float x = Input.GetAxis("Horizontal");  // mouse x hareketi
        float y = Input.GetAxis("Vertical");    // mouse y hareketi

        // mouse x ve y değerimize hız ekliyoruz
        x = x * hiz;
        y = y * hiz;

        // delta time çarpımı
        x = x * Time.deltaTime;
        y = y * Time.deltaTime;

        // rigidbody'ye addForce ile Güç/Etki veriyoruz
        rb.AddForce(x, 0, y, force);
    }
}
