using UnityEngine;
using TMPro; // TextMeshPro (UI) kütüphanesini dahil ettik

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f; // Inspector'dan ayarlayabilmen için zıplama gücü

    private Rigidbody rb;

    // --- SKOR VE UI DEĞİŞKENLERİ ---
    private int score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Oyun başladığında skoru 0 yap ve ekrana yazdır
        score = 0;
        SetScoreText();
    }

    // İleri/Geri ve Sağ/Sol hareketleri (Sürekli uygulanan güçler)
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Paraların Tag'ini Unity'de "PickUp" yaptıysan burası çalışır
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false); // Parayı yok et

            // --- SKOR EKLEME BÖLÜMÜ ---
            score = score + 1; // Skoru 1 artır
            SetScoreText();    // UI ekranındaki metni güncelle

            Debug.Log("Para toplandı! Yeni Skor: " + score); // Kontrol için konsola yazdır
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

    // --- SKOR METNİNİ GÜNCELLEYEN YARDIMCI FONKSİYON ---
    void SetScoreText()
    {
        // Ekranda yazacak olan tam metni belirliyoruz
        scoreText.text = "Score: " + score.ToString();
    }
}