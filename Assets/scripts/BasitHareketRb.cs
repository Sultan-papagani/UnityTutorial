using Unity.Mathematics;
using UnityEngine;

public class BasitHareketRb : MonoBehaviour
{
    public float hiz = 20;
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

        // rigidbody'yi hareket ettiriyoruz 
        rb.MovePosition(transform.position + new Vector3(x, 0, y));
    }
}
