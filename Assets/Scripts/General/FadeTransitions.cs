using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class FadeTransitions 
{
    public static IEnumerator StartFade(ParticleSystem ps, float duration, float targetValue)
    {    var shape = ps.shape;
        float currentTime = 0;
        float start = shape.radius;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
           
            shape.radius = Mathf.Lerp(start, targetValue, currentTime / duration);
            
            yield return null;
        }
        yield break;
    }
    public static IEnumerator SpriteFade(SpriteRenderer sr, float duration, Color targetValue)
    {    
        float currentTime = 0;
        Color start = sr.color;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
           
           sr.color = Color.Lerp(start, targetValue, currentTime / duration);
            
            yield return null;
        }
        yield break;
    }
    public static IEnumerator CanvasFade(CanvasGroup _canvas, float duration, float targetValue)
    {    
        float currentTime = 0;
        float start = _canvas.alpha;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
           
           _canvas.alpha = Mathf.Lerp(start, targetValue, currentTime / duration);
            
            yield return null;
        }
        yield break;
    }
}
