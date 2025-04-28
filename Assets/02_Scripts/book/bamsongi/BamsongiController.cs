using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shoot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void shoot(Vector3 vecter3)
    {
        GetComponent<Rigidbody>().AddForce (vecter3);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("object naem = " + collision.gameObject.name);
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
}
