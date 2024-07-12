using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCharacter : MonoBehaviour
{
    private SpriteRenderer renderer;

    public void SwitchSprite(Sprite sprite)
    {
        renderer.sprite = sprite;
    }
}
