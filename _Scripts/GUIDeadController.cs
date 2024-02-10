using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIDeadController : MonoBehaviour
{
    [SerializeField]
    private GameObject deadScreen;
    private Canvas canvas;
    [SerializeField]
    private TextMeshProUGUI reviveScoreTxt;
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void ToggleActive()
    {
        deadScreen.SetActive(!deadScreen.activeSelf);
    }

    public void ToggleActive(Camera camera)
    {
        deadScreen.SetActive(!deadScreen.activeSelf);
        canvas.worldCamera = camera;
    }

    public void UpdateReviveText(int valueToRevive)
    {
        reviveScoreTxt.text = "You need " + valueToRevive + " more points to revive.";
    }
}
