using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveTexture : MonoBehaviour
{
    public Material MayroCar;
    public Material LuggyCar;
    public Material JoshyCar;
    public Material MayroTexture;
    public Material LuggyTexture;
    public Material JoshyTexture;
    void Awake()
    {
        if(tag == "TexturePlayer")
        {
            TexturePlayer();
        }
        else if(tag == "TextureCar")
        {
            TextureCar();
        }
        else
        {
            return;
        }
    }

    void TextureCar()
    {
        switch(MainMenuButtons.character)
        {
            case 0: GetComponent<MeshRenderer>().material = MayroCar; break;
            case 1: GetComponent<MeshRenderer>().material = LuggyCar; break;
            case 2: GetComponent<MeshRenderer>().material = JoshyCar; break;

        }
    }

    void TexturePlayer()
    {
        switch (MainMenuButtons.character)
        {
            case 0: GetComponent<SkinnedMeshRenderer>().material = MayroTexture; break;
            case 1: GetComponent<SkinnedMeshRenderer>().material = LuggyTexture; break;
            case 2: GetComponent<SkinnedMeshRenderer>().material = JoshyTexture; break;

        }
    }
}
