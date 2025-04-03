using UnityEngine;
using UnityEngine.UI;

public class FacebookLoginPlaceholder : MonoBehaviour
{
	public Button loginButton;

	void Start()
	{
		loginButton.onClick.AddListener(OnLoginButtonClicked);
	}

	void OnLoginButtonClicked()
	{
		Debug.Log("Login button clicked (Placeholder)");
	}
}
