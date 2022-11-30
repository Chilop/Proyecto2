using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDropWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyTimer());
    }

    private IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
