using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventsManager", menuName = "ScriptableObjects/Events Manager")]
public class EventsManager : ScriptableObject
{
    [SerializeField] public event Action onMenuPlay = default;
}
