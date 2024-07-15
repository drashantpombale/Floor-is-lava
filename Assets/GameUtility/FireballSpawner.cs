using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    public GameObject Fireball;

    [SerializeField]
    private int fireballSpeed = 10;

    public void ShootFireball(Vector3 shootDirection) 
    {
        GameObject fireball = Instantiate(Fireball, transform.position, Quaternion.identity);
        fireball.transform.forward = new Vector3(shootDirection.x, 0, shootDirection.z).normalized;
        fireball.GetComponent<Rigidbody>().velocity = new Vector3(shootDirection.x-transform.position.x, 0, shootDirection.z-transform.position.z).normalized * fireballSpeed;
    }

}
