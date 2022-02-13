using System;

public static class Rescaler
{
    public static float RescaleFace(float initialScale, float firstContact, float secondContact)
    {
        float scale = Math.Abs(firstContact - secondContact);
        return scale > 0f ? scale : initialScale;
    }

    public static float FindCoordinate(float cooridnate, float scale, float rescaledFace)
    {
        if (cooridnate > 0)
            return cooridnate - (scale - rescaledFace) / 2;
        else
            return cooridnate + (scale - rescaledFace) / 2;
    }
}
