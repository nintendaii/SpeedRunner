using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOptions : MonoBehaviour {
	public GameObject PausePanel;
    public GameObject MenuPanel;
    public GameObject LevelsPanel;
    public GameObject SettingsPanel;
    public GameObject ControllersCanvas;

    public void Play(){
        MenuPanel.SetActive(false);
        LevelsPanel.SetActive(true);
	}

	public void Pause(){
		Time.timeScale = 0;
		PausePanel.SetActive (true);
    ControllersCanvas.SetActive(false);
	}

	public void Resume(){
		Time.timeScale = 1;
		PausePanel.SetActive (false);
    ControllersCanvas.SetActive(true);
	}

	public void ExitToMainMenu(){
		Time.timeScale = 1;
		Application.LoadLevel ("Menu");
	}

	public void Exit(){
		Application.Quit ();
	}
	    public void Back()
    {
			LevelsPanel.SetActive(false);
			MenuPanel.SetActive(true);
    }

  public void Back2()
  {
    SettingsPanel.SetActive(false);
    MenuPanel.SetActive(true);
    LevelsPanel.SetActive(false);
  }

    public void Settings(){
      MenuPanel.SetActive(false);
      LevelsPanel.SetActive(false);
      SettingsPanel.SetActive(true);
    }

    public void SetLowQuality(){
        QualitySettings.SetQualityLevel(0);
    }
    public void SetMediumQuality(){
        QualitySettings.SetQualityLevel(2);
    }
    public void SetHighQuality(){
        QualitySettings.SetQualityLevel(3);
    }

  public void SetUltraQuality()
  {
    QualitySettings.SetQualityLevel(4);
  }

    public void Level1()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        Application.LoadLevel("Level1");
    }

  public void Level2()
  {
    if (Time.timeScale == 0)
    {
      Time.timeScale = 1;
    }
    Application.LoadLevel("Level2");
  }
}
