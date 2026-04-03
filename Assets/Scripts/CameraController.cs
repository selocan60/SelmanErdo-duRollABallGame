using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Takip edilecek objeyi (Top) editörden sürükleyip bırakmak için
    public Transform player;

    // Kamera ile top arasındaki başlangıç mesafesini tutacak değişken
    private Vector3 offset;

    void Start()
    {
        // Oyun başladığında kameranın konumu ile topun konumu arasındaki farkı hesaplayıp kaydediyoruz
        offset = transform.position - player.position;
    }

    // LateUpdate, diğer tüm Update işlemleri (topun hareketi vb.) bittikten sonra çalışır.
    // Kameranın titremesini (jittering) engellemek için kamera takiplerinde LateUpdate kullanılır.
    void LateUpdate()
    {
        // Kameranın yeni pozisyonunu, topun o anki pozisyonu + baştaki mesafe olarak güncelliyoruz
        transform.position = player.position + offset;
    }
}