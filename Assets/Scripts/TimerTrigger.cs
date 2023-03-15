using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerTrigger : MonoBehaviour
{
    [SerializeField] Timer timer;
    public UnityEvent onEnter, onExit;
    public GameObject player1;
    public GameObject player2;

    private void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    private void OnTriggerEnter(Collider other)
    {
        onEnter.Invoke();
        if (other.gameObject == (player1 || player2))
        {
            timer.StartCountdown();
        }
    }
}
