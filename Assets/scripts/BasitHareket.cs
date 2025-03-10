using Unity.VisualScripting;
using UnityEngine;

public class BasitHareket : MonoBehaviour
{

    public float hiz = 5;

    // Oyun objesi yüklendiğinde 1 kez çalışır
    void Start()
    {
        
    }

    // Her kare (frame, FPS) çalışır
    void Update()
    {
        // veri tipleri
        // float        kayan noktalı sayı      1.32, 1.3245, 0.00453, 3.14, 234.23543
        // int          tam sayı                1, 2, 3, 100, 847, 0

        float x = Input.GetAxis("Horizontal");  // mouse x hareketi
        float y = Input.GetAxis("Vertical");    // mouse y hareketi

        // mouse x ve y değerimize hız ekliyoruz
        x = x * hiz;
        y = y * hiz;

        // delta time çarpımı
        x = x * Time.deltaTime;
        y = y * Time.deltaTime;

        // mouse x ve y hareketini, 3 boyutlu dünyada x ve z aksisine geçiriyoruz.
        transform.Translate(x, 0, y);
    }
}
