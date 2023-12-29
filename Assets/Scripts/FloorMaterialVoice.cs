using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//1. �������� ������ � ������� ����� ������ floorMaterial. ���� ������ ������ ������ �� ������ ����������� � ������� ����� ����� ������������ ������ 
//2. �������� ������ ��� ������������. ���� ������ ������ ����� ��������� ����� ��� ��������������� ����� �� ������ ��������� �����������, �������� ����� �������� ����� �������� ������ 
//3. ������� �������� ����������� � ���� �������, ������ - ��� ������������ � �����, ����� �� ������� (PlayerHealt.cs) 

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