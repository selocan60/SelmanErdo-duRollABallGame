using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Dönüş hızını buradan ayarlayabiliriz
    public Vector3 rotationSpeed = new Vector3(15, 30, 45);

    void Update()
    {
        // Nesneyi her karede (frame) döndürür
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}