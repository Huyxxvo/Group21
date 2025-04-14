using UnityEngine;

public class create_object : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    public AudioSource spawnSound;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        if (spawnSound != null)
        {
            spawnSound.Play();
        }
    }
}
