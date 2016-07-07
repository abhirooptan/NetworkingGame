using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class SwordDamage : NetworkBehaviour
{
    public GameObject blood;
    void Start()
    {
        Debug.Log("Sword Initialized");
    }

    public void OnTriggerEnter(Collider other)
    {
        var hit = other.gameObject;
        if (hit.gameObject == isLocalPlayer)
        {
            Debug.Log("Dont hit me i am the local one");
            // do nothing
        }
        else
        {
            Debug.Log("Trigger Damage: " + hit.name);
            var health = hit.GetComponent<Health>();
            if (health != null)
            {
                var bloodshed = Instantiate(blood, transform.position, transform.rotation);
                Destroy(bloodshed, 1.0f);
                health.TakeDamage(10);
            }
        }
    }
}