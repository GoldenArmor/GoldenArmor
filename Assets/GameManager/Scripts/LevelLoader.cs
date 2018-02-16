﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    AudioPlayer audioPlayer; 

    public Mouse mouse;

    public CameraController cameraController;
    public CameraRotation cameraRotation; 
    public CameraZoom cameraZoom;

    public GameObject fogOfWar;

    [Header("Skills")]
    public Hero hero;
    public Mage mage;
    public Archer archer;
    public Paladin paladin;

    private void Start()
    {
        AudioManager.Initialize();
        audioPlayer.PlayMusic(0);
    }
}
