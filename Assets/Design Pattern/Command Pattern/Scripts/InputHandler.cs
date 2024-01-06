using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    static InputHandler inputHandler;

    public Command[] commands;
    
    private Command buttonSpace;
    private Command buttonLeftShift;
    private Command buttonTab;
    private Command buttonLeftControl;

    private void Awake()
    {
        InitSystem();
    }

    private void Start()
    {
        Registerkey();
    }

    void Update()
    {
        HandleInput();
    }

    #region Inits
    void InitSystem()
    {
        inputHandler = GetComponent<InputHandler>();
    }
    #endregion

    #region Keys
    void Registerkey()
    {
        buttonSpace = new JumpCommand();
        buttonLeftShift = new FireGunCommand();
        buttonTab = new SwapWeaponCommand();
        buttonLeftControl = new RollCommand();
    }
    #endregion

    #region Inputs
    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) buttonSpace.Execute();
        else if (Input.GetKeyDown(KeyCode.LeftShift)) buttonLeftShift.Execute();
        else if (Input.GetKeyDown(KeyCode.Tab)) buttonTab.Execute();
        else if (Input.GetKeyDown(KeyCode.LeftControl)) buttonLeftControl.Execute();
    }
    #endregion

    #region Commands
    [System.Serializable]
    public class JumpCommand : Command
    {
        public override void Execute()
        {
            inputHandler.Jump();
        }
    }

    [System.Serializable]
    public class FireGunCommand : Command
    {
        public override void Execute()
        {
            inputHandler.FireGun();
        }
    }

    [System.Serializable]
    public class SwapWeaponCommand : Command
    {
        public override void Execute()
        {
            inputHandler.SwapWeapon();
        }
    }

    [System.Serializable]
    public class RollCommand : Command
    {
        public override void Execute()
        {
            inputHandler.Roll();
        }
    }
    #endregion

    #region Behaviors
    void Jump()
    {
        Debug.Log("Jump");
    }

    void FireGun()
    {
        Debug.Log("FireGun");
    }

    void SwapWeapon()
    {
        Debug.Log("SwapWeapon");
    }

    void Roll()
    {
        Debug.Log("Roll");
    }
    #endregion
}
