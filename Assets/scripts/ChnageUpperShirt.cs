using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChnageUpperShirt : MonoBehaviour
{
    public SkinnedMeshRenderer[]  allMeshRenderer;

    public SkinnedMeshRenderer  neededMeshRenderer; // the one to apper

    public void ButtonPressed()
    { //int length = allMeshRenderer.Length;

        for(int i=0; i<allMeshRenderer.Length;i++)
        {
            if(allMeshRenderer[i].enabled)
            {
                allMeshRenderer[i].enabled=false;
                neededMeshRenderer.enabled=true;
                break;

            }
        }

    }

    
}
