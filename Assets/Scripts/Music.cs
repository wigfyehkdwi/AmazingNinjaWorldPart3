using UnityEngine;

public class Music : MonoBehaviour
{
    void Awake()
    {
        // Check for duplicates
        Music[] others = Object.FindObjectsOfType<Music>();
        if (others.Length > 1) {
            Destroy(gameObject);
            return;
        }

        Object.DontDestroyOnLoad(gameObject);
    }
}
