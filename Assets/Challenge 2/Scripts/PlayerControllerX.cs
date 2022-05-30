using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTimer = 2.0f;
    private bool cooldown = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown == false)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("ResetCooldown", cooldownTimer);
            cooldown = true;
        }
    }
    void ResetCooldown()
    {
        cooldown = false;
    }
}

