using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Заглушка для авторизації через Facebook.
/// Використовується для тестування інтерфейсу авторизації
/// до впровадження повноцінної інтеграції з Facebook SDK.
/// </summary>
public class FacebookLoginPlaceholder : MonoBehaviour
{
	/// <summary>
	/// Кнопка для авторизації через Facebook
	/// </summary>
	public Button loginButton;

	void Start()
	{
		loginButton.onClick.AddListener(OnLoginButtonClicked);
	}

	/// <summary>
	/// Обробник натискання кнопки авторизації
	/// </summary>
	void OnLoginButtonClicked()
	{
		Debug.Log("Натиснуто кнопку авторизації через Facebook (Заглушка)");
	}
}
