using UnityEngine;
using System.Collections;

public class SwordDamage : MonoBehaviour
{
    public GameObject bloodEffect;
    public GameObject playerDeathEffect;
    void Start()
    {
        Debug.Log("Sword Initialized");
    }

    public void OnTriggerEnter(Collider other)
    {
        var hit = other.gameObject;
        if (hit.gameObject.CompareTag("Player"))
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
                Vector3 positionToSpawn = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-1.0f, 1.0f), transform.position.z + Random.Range(-0.5f, 0.5f));
                var bloodshed = Instantiate(bloodEffect, positionToSpawn, transform.rotation);
                Destroy(bloodshed, 1.0f);
                health.TakeDamage(10);

                //if (health.currentHealth <= 0)
                //{
                //    Vector3 positionToSpawnPlayerDeath = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                //    var deathEffect = Instantiate(playerDeathEffect, positionToSpawnPlayerDeath, transform.rotation);
                //    Destroy(deathEffect, 1.0f);
                //}
            }
        }
    }
}