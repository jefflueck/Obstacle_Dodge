using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField]
    private float timeToDrop = 3f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    void Start()
    {

        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
        transform.position = new UnityEngine.Vector3(-10.50f, 7f, -1.30f);
    }


    void Update()
    {
        // show current time as the game runs.
        if (Time.time > timeToDrop)
        {
            // Drop the object
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }


    }
}
