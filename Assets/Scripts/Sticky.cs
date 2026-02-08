using UnityEngine;

public class Sticky : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Glorpable")
        {
            c.gameObject.transform.parent = transform;
            Destroy(c.gameObject.GetComponent<Rigidbody>());
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
