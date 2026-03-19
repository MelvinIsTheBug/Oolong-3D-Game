using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
     public Slider VolumeSlider; // assign in inspector

    void Start()
    {
        if (VolumeSlider != null)
            VolumeSlider.value = AudioListener.volume;
    }

    // Called when Play button is clicked
    public void PlayGame()
    {
        SceneManager.LoadScene("test map"); // <-- change to your group scene name
    }

    // Called when Quit button is clicked
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit"); // only visible in editor
    }

    // Called when slider value changes
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
    }
}
