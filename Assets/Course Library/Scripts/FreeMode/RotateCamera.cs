using UnityEngine;
using UnityEngine.UIElements;

public class RotateCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float rotationSpeed;
    private float rotationDirection;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationDirection = Input.GetAxis("Horizontal");
        transform.Rotate(- Vector3.up * Time.deltaTime * rotationSpeed * rotationDirection);
    }
}
