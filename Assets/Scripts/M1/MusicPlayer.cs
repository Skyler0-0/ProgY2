using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private string currentSong = "Dash By Nmixx";
    private bool isPlaying = false;
    private float volume = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MusicPlayer Started.");
        Debug.Log("P = Play, S = Stop, v = Change Volume.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("Dash");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SetVolume(Random.Range(0.0f, 1.0f));
        }
    }

     public void PlaySong(string songName)
    {
        currentSong = songName;
        isPlaying = true;
        Debug.Log("Playing now: " + songName);
    }

    public void StopSong()
    {
        if (isPlaying)
        {
            currentSong = "";
            isPlaying = false;
            Debug.Log("Stopped music");
        }
        else
        {
            Debug.Log("Music was already stopped");
        }
    }

    public void SetVolume(float volume)
    {
        volume = Mathf.Clamp01(volume);
        Debug.Log("Volume set on: " + volume);
    }

    public string GetCurrentSong()
    {
        Debug.Log("Current song: " + currentSong);
        return currentSong;
    }

    public bool IsPlaying()
    {
        Debug.Log("is Curently Playing? " + isPlaying);
        return isPlaying;
    }
}
