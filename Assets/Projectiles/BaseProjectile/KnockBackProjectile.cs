using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBackProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    private Collider projectileCollider;


    [SerializeField]
    private float lifeTime = 5.0f;

    private float currentLifeTime;

    void Start()
    {
        projectileCollider = GetComponent<Collider>();
        if (projectileCollider == null)
        {
            Debug.Log("Collider not found on the projectile");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collisionObject = collision.collider.gameObject;
        if (collisionObject.layer == 8)
        {
            Rigidbody collisionRgbd = collision.collider.attachedRigidbody;

            collisionRgbd.AddForce(transform.forward.normalized * 4);
        }
        else 
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentLifeTime += Time.deltaTime;
        if (currentLifeTime >= lifeTime) 
        {
            Destroy(gameObject);
        }
    }
}
