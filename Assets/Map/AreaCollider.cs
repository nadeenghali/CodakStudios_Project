using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCollider : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Axe"))
        {
            MapListener.EnemiesCreate = true;
            Destroy(this.gameObject);
        }

    }
}
