using System.Collections.Generic;
using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{

    [SerializeField] private List<FlyAt> projectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            return;
        }

        foreach (var projectile in projectiles)
        {
            projectile.Activate();
        }

        Destroy(gameObject);
    }

}
