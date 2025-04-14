using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
	[SerializeField] private VideoPlayer videoPlayer;
	[SerializeField] private string mainSceneName = "1. GameScene";
	[SerializeField] private bool canSkip = true;
    
	private bool isTransitioning = false;
    
	private void Start()
	{
		// Check if we should skip the intro based on player preferences
		if (PlayerPrefs.HasKey("SkipIntro") && PlayerPrefs.GetInt("SkipIntro") == 1)
		{
			LoadMainScene();
			return;
		}
        
		// Register for video completion event
		videoPlayer.loopPointReached += OnVideoFinished;
	}
    
	private void Update()
	{
		// Allow skipping with any key/button press if enabled
		if (canSkip && (Input.anyKeyDown || Input.GetButtonDown("Submit")) && !isTransitioning)
		{
			LoadMainScene();
		}
	}
    
	private void OnVideoFinished(VideoPlayer vp)
	{
		LoadMainScene();
	}
    
	private void LoadMainScene()
	{
		if (isTransitioning) return;
        
		isTransitioning = true;
        
		SceneManager.LoadScene(mainSceneName);
	}
}
