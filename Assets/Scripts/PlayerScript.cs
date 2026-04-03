using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f; // Inspector'dan ayarlayabilmen için zıplama gücü

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // İleri/Geri ve Sağ/Sol hareketleri (Sürekli uygulanan güçler)
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    // Bu kısmı FixedUpdate fonksiyonunun hemen altına (ama sınıfın dışına çıkmadan) yapıştır
    private void OnTriggerEnter(Collider other)
    {
        // Paraların Tag'ini Unity'de "PickUp" yaptıysan burası çalışır
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false); // Parayı yok et
            Debug.Log("Para toplandı!"); // Kontrol için konsola yazdır
        }
    }

    // Zıplama gibi anlık tuş basımlarını Update içinde kontrol etmek daha sağlıklıdır
    void Update()
    {
        // Space tuşuna basıldığı "o ilk kareyi" yakalar
        if (Input.GetButtonDown("Jump"))
        {
            // Vector3.up (0, 1, 0) yönünde, anlık bir patlama gücü (Impulse) uygular
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}