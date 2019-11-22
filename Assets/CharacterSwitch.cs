using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

// temporary hack to switch playable characters, ideally should
// later become methods part of subclasses of ThirdPersonInput etc. 

public class CharacterSwitch : MonoBehaviour
{
    [SerializeField] private GameObject catBoy;
    [SerializeField] private GameObject catBoyCamera;
    [SerializeField] private Invector.CharacterController.vThirdPersonController catBoyController;
    [SerializeField] private Invector.CharacterController.vThirdPersonInput catBoyInput;

    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject catFormCamera;
    [SerializeField] private Invector.CharacterController.vThirdPersonController catFormController;
    [SerializeField] private Invector.CharacterController.vThirdPersonInput catFormInput;

    private GameObject activeCharacter;
    private GameObject activeCamera;
    private Invector.CharacterController.vThirdPersonController activeController;
    private Invector.CharacterController.vThirdPersonInput activeInput;

    private void Start()
    {
        Debug.Log("HIII");
        activeCharacter = catBoy;
        activeController = catBoyController;
        activeCamera = catBoyCamera;
        activeInput = catBoyInput;

        cat.SetActive(false);
        catFormController.enabled = false;
        catFormCamera.SetActive(false);
        catFormInput.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SwitchActiveCharacter();
        }
    }

    private void SwitchActiveCharacter()
    {
        SwitchCharacter();
        SwitchController();
        SwitchCamera();
        SwitchInput();
    }

    private void SwitchCharacter()
    {
        activeCharacter.SetActive(false);
        if (activeCharacter == catBoy)
        {
            activeCharacter = cat;
        }
        else
        {
            activeCharacter = catBoy;
        }
        activeCharacter.SetActive(true);
    }

    /// <summary>
    /// Disable old controller, switch active controller, and enable new controller
    /// </summary>
    private void SwitchController()
    {
        activeController.enabled = false;
        if (activeController == catBoyController)
        {
            activeController = catFormController;
        }
        else
        {
            activeController = catBoyController;
        }
        activeController.enabled = true;
    }

    /// <summary>
    /// Disable old camera, switch active camera, and enable new camera
    /// </summary>
    private void SwitchCamera()
    {
        activeCamera.SetActive(false);
        if (activeCamera == catBoyCamera)
        {
            activeCamera = catFormCamera;
        }
        else
        {
            activeCamera = catBoyCamera;
        }
        activeCamera.SetActive(true);
    }

    /// <summary>
    /// Disable old input, switch active input, and enable new input
    /// </summary>
    private void SwitchInput()
    {
        activeInput.enabled = false;
        if (activeInput == catBoyInput)
        {
            activeInput = catFormInput;
        }
        else
        {
            activeInput = catBoyInput;
        }
        activeInput.enabled = true;
    }

    // TODO: Make just-switched-to model oriented at same position and rotation
}
