using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileApple : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 velocity = new Vector2(0.0f,0.0f);
    public int damage = 10;
    public GameObject turkey;
    public GameObject cowNPC;
    EnemyHealth cowHealth;
    public GameObject horseNPC;
    EnemyHealth horseHealth;
    public GameObject pigNPC;
    EnemyHealth pigHealth;
    public GameObject chickenNPC;
    EnemyHealth chickenHealth;
    public GameObject slimeNPC;
    EnemyHealth slimeHealth;

    void Update() {
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
        Vector2 newPosition = currentPosition + velocity * Time.deltaTime;

        RaycastHit2D[] hits = Physics2D.LinecastAll(currentPosition, newPosition);

        foreach (RaycastHit2D hit in hits)
        {
            GameObject other = hit.collider.gameObject;
            if (other != turkey)
            {
                //Debug.Log(hit.collider.gameObject);
                if (other == cowNPC)
                {
                    cowHealth = cowNPC.GetComponent<EnemyHealth>();
                    Debug.Log("Ouch!\n");
                    cowHealth.TakeDamage(damage);
                    Destroy(gameObject);
                }
                else if (other == horseNPC)
                {
                    horseHealth = horseNPC.GetComponent<EnemyHealth>();
                    horseHealth.TakeDamage(damage);
                    Destroy(gameObject);
                }
                else if (other == pigNPC)
                {
                    pigHealth = pigNPC.GetComponent<EnemyHealth>();
                    pigHealth.TakeDamage(damage);
                    Destroy(gameObject);
                }
                else if (other == chickenNPC)
                {
                    chickenHealth = chickenNPC.GetComponent<EnemyHealth>();
                    chickenHealth.TakeDamage(damage);
                    Destroy(gameObject);
                }
                else if (other == slimeNPC)
                {
                    slimeHealth = slimeNPC.GetComponent<EnemyHealth>();
                    slimeHealth.TakeDamage(damage);
                    Destroy(gameObject);
                }
            }
        }

        transform.position = newPosition;
        
    }
}
