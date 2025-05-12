using UnityEngine;

public class Spinner : MonoBehaviour
{


    [SerializeField]
    private float xValue = 0f;
    [SerializeField]
    private float yValue = 0.5f;
    [SerializeField]
    private float zValue = 0f;
    void Start()
    {
        transform.position = new Vector3(7f, .35f, -.10f);
    }

    void Update()
    {
        // Rotate the object on the Y axis
        transform.Rotate(xValue, yValue, zValue);
    }
}
