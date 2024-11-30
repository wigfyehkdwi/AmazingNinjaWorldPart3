using UnityEngine;

public class Music : MonoBehaviour
{
    void Awake()
    {
        // Check for duplicates
        Music[] others = Object.FindObjectsOfType<Music>();
        foreach (Music other in others) {
            if (other == this) continue;

            Music target = clipof(other) == clipof(this) ? this : other;
            Destroy(target.gameObject);
        }

        Object.DontDestroyOnLoad(gameObject);
    }

    private static AudioClip clipof(Music music)
    {
        return music.gameObject.GetComponent<AudioSource>().clip;
    }
}
