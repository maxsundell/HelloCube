using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelNumber : MonoBehaviour {

    // Reference to the text script
    private TextMeshProUGUI levelNumberText;

	void Start () {

        // Finds the text script
        levelNumberText = gameObject.GetComponent<TextMeshProUGUI>();

        // Changes the text to the current build index of the current level
        levelNumberText.text = SceneManager.GetActiveScene().buildIndex.ToString();
	}

}
