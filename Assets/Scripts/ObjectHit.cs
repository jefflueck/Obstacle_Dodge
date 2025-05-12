using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        //  if player hits an object, change the color of the object

        GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

    }

}
