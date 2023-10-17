using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPointsUiController : MonoBehaviour
{
    public Text  textodepontuacao;
    private void OnEnable()
    {
        PlayerObserver.OnPointsChanged += UpdatePoints;
    }

    private void OnDisable()
    {
        PlayerObserver.OnPointsChanged -= UpdatePoints; 
    }

    private void Awake()
    {
        textodepontuacao = GetComponent<Text>();
    }

    private void UpdatePoints(int value )
    {
        textodepontuacao.text = value.ToString();
    }
}
