using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour {

	public AudioMixer audioMixer;

	public Dropdown resolutionChange;

	Resolution[] resolutions;

	void Start()
	{
		resolutions = Screen.resolutions;

		resolutionChange.ClearOptions();

		List<string> options = new List<string>();

		int actualResolutionValue = 0;

		for(int i = 0; i < resolutions.Length; i++)
		{
			string option = resolutions[i].width + " x " + resolutions[i].height;

			options.Add(option);

			if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
			{
				actualResolutionValue = i;
			}
		}

		resolutionChange.AddOptions(options);

		resolutionChange.value = actualResolutionValue;

		resolutionChange.RefreshShownValue();
	}

	public void setResolution(int resolutionValue)

	{
		Resolution resolution = resolutions[resolutionValue];

		Screen.SetResolution(resolution.width,resolution.height, Screen.fullScreen);
	}

	public void setVolume(float volume)
	{
		audioMixer.SetFloat("Volume",volume);
	}

	public void setQuality(int qualityValue)
	{
		QualitySettings.SetQualityLevel(qualityValue);
	}

	public void fullscreenMode(bool fullscreen)
	{
		Screen.fullScreen = fullscreen;
	}
		
}
