using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLobbyButton : MonoBehaviour
{
    public Slider SladerValue;
    public AudioSource musik;
    public float volume;

    public Dropdown checkScreen;
    public Dropdown FPScontrol;

    private int maxFPS = 60;

    private void Start()
    {
        Application.targetFrameRate = maxFPS;
        if (PlayerPrefs.HasKey("volume"))
        {
            volume = PlayerPrefs.GetFloat("volume");       
        }
        if(PlayerPrefs.HasKey("checkScreen"))
        {
            checkScreen.value = PlayerPrefs.GetInt("checkScreen");
        }
        if(PlayerPrefs.HasKey("FPScontrol"))
        {
            FPScontrol.value = PlayerPrefs.GetInt("FPScontrol");
        }
    }
    public void DropdownScreenchek()
    {
        if(checkScreen.value == 0)
        {
            Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
        }
        if(checkScreen.value == 1)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        }
        if(checkScreen.value == 2)
        {
            Screen.fullScreenMode = FullScreenMode.MaximizedWindow;
        }
        if(checkScreen.value == 3)
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
        
    }
    public void SetFPS()
    {
        if(FPScontrol.value == 0)
        {
            maxFPS = 30;
        }
        if (FPScontrol.value == 1)
        {
            maxFPS = 60;
        }
        if (FPScontrol.value == 2)
        {
            maxFPS = 120;
        }
        if (FPScontrol.value == 3)
        {
            maxFPS = 144;
        }

        Application.targetFrameRate = maxFPS;
    }
    public void SaveSetting()
    {
        PlayerPrefs.SetInt("FPScontrol", FPScontrol.value);
        PlayerPrefs.SetInt("checkScreen", checkScreen.value);
        PlayerPrefs.SetFloat("volume", volume);
    }
    
    private void Update()
    {
        musik.volume = SladerValue.value;
        volume = SladerValue.value;
        
    }
    public void Quit() => Application.Quit();
    public void Offline() => SceneManager.LoadScene(2);
    public void Online() => SceneManager.LoadScene(1);
}
