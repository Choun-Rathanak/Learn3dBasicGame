using UnityEngine;

public class RotateBall : MonoBehaviour
{
    public float rotationSpeed = 250f;
    public Color newColor = Color.red; 

    void Update()
    {
       
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
 
        if (other.CompareTag("ball"))
        {
            Debug.Log("Ball touched this object!");

            Renderer ballRenderer = other.GetComponent<Renderer>();

            if (ballRenderer != null)
            {
                ballRenderer.material.color = newColor;
            }
        }
    }
}
