using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//1. Написать скрипт в котором будет только floorMaterial. Этот скрипт должен висеть на каждой поверхности с которой игрок будет сталкиваться СДЕЛАЛ 
//2. Написать скрипт для аудиосистемы. Этот скрипт должен иметь публичный метод для воспроизведения звука на основе материала поверхности, материал нужно передать через парамтры метода 
//3. Сделать проверку поверхности в двух случаях, Первое - это столкновение с землёй, когда он умирает (PlayerHealt.cs) 

public class FloorMaterialVoice : MonoBehaviour
{
    public FloorMaterial FloorMaterial;    
}


public enum FloorMaterial
{
    WoodFloor,
    GrassFloor,
    IronFloor,
}