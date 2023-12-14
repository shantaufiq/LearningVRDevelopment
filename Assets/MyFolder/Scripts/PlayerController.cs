
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; // Kecepatan gerakan karakter
    public CharacterController controller;

    void Start()
    {
        // Mendapatkan komponen Character Controller yang terpasang pada objek ini
        // controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Mengambil input dari keyboard
        float horizontal = Input.GetAxis("Horizontal"); // A dan D
        float vertical = Input.GetAxis("Vertical"); // W dan S

        // Membuat vektor pergerakan berdasarkan input
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        movement = Vector3.ClampMagnitude(movement, 1); // Memastikan kecepatan maksimal tetap konstan

        // Menerapkan pergerakan pada karakter
        controller.Move(movement * speed * Time.deltaTime);
    }
}
