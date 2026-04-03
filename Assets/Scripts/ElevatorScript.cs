using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed = 2.0f;
    private bool movingToEnd = true;

    void Start()
    {
        // Başlangıç pozisyonunu objenin şu anki yeri olarak ayarla
        startPosition = transform.position;
    }

    void Update()
    {
        // Hedef noktayı belirle
        Vector3 target = movingToEnd ? endPosition : startPosition;

        // Objeyi hedefe doğru yumuşakça hareket ettir
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Hedefe vardıysa yönü değiştir
        if (Vector3.Distance(transform.position, target) < 0.01f)
        {
            movingToEnd = !movingToEnd;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}