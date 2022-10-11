using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float dogTimer;
    private float delayDog = 0.8f;

    // Update is called once per frame
    void Update()
    {
        dogTimer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (dogTimer > delayDog))
        {
            //will spawn next dog  when time + spawnrate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogTimer = 0f;
        }
    }
}
