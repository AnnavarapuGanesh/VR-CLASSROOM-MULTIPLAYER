using UnityEngine;
using TMPro;

public class UIscript : MonoBehaviour
{
    void Start() {
    Cursor.lockState = CursorLockMode.None; // Unlocks the cursor
    Cursor.visible = true; // Makes cursor visible
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI output;
    public TMP_InputField username;

    public void ButtonDemo()
    {
        output.text = username.text;
    }
}
