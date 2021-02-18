using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using static UnityEngine.InputSystem.InputAction;

public class UIManager : MonoBehaviour
{
    private Canvas _targetCanvas;


    private List<Canvas> otherCanvas;
    #region property

    private bool CanvasNotNull => _targetCanvas != null;

    private bool CanvasEnable => _targetCanvas.enabled == true;

    public Canvas TargetCanvas => _targetCanvas;

    private List<Canvas> OtherCanvas
    {
        get
        {
            
            return otherCanvas;
        }
        set
        {
            //Find all other canvas to disable 
            Canvas[] canvasList = FindObjectsOfType<Canvas>();
            otherCanvas = canvasList.ToList();
            otherCanvas.Remove(_targetCanvas);
        }
    }


    #endregion

    public void Start()
    {
        _targetCanvas = GetComponent<Canvas>();
        if (CanvasNotNull)
        {
            SetObjectActive(false);
            SetCanvasEnable(false);
        }

    }

    public void TriggerCanvas()
    {
        Debug.Log("TriggerCanvas");
        if (! CanvasNotNull) return;
        SetObjectActive();
        SetCanvasEnable();
        Mute();
        if (CanvasEnable)
        {
            SetTimePause(true);
            return;
        }
        SetTimePause(false);
    }

    private void SetOtherDisable()
    {
        foreach (Canvas canvas in OtherCanvas)
        {
            canvas.enabled = false;
        }
    }

    private void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    private void SetCanvasEnable()
    {
        _targetCanvas.enabled = !_targetCanvas.enabled;
    }

    private void SetCanvasEnable(bool input)
    {
        _targetCanvas.enabled = input;
    }



    private void SetTimePause(bool input)
    {
        if (input)
        {
            Time.timeScale = 0; 
            return;
        }
        Time.timeScale = 1;
    }


    private void SetObjectActive()
    {
        _targetCanvas.gameObject.SetActive(!_targetCanvas.gameObject.activeSelf);
    }
    private void SetObjectActive(bool input)
    {
        _targetCanvas.gameObject.SetActive(input);
    }
    
    
}
