using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterScript : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Button SubmitButton; 

   public void VerifyInputs()
    {
        SubmitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }
}
