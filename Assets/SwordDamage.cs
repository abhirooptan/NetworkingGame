using UnityEngine;
using System.Collections;

public class SwordDamage : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Sword Initialized");
    }

    void OnCollisioEnter(Collision collision)
    {
        var hit = collision.gameObject;
        Debug.Log("Damage: " + hit.name);
        var health = hit.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(10);
        }

        //Destroy(gameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        var hit = other.gameObject;
        Debug.Log("Trigger Damage: " + hit.name);
        var health = hit.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(10);
        }
    }
}