using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource bgm;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        bgm.Play();
    }
}
