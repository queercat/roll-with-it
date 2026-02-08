using UnityEngine;

public class Sticky : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Glorp(GameObject glorpable)
    {
        glorpable.transform.parent = transform;
        Destroy(glorpable.GetComponent<Rigidbody>());
        EventManager.Instance.OnGlorp();
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Glorpable")
        {
            Glorp(c.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
