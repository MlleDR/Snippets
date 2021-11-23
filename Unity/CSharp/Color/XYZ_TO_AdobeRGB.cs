// Converts (x,y,z) to (r,g,b) with ligntness parameter
// Returns Adobe RGB as Vector3.
    public Vector3 XZY_to_RGB(float x, float y, float z, float lightness)
    {
        float _x = x / 100f;
        float _y = y / 100f;
        float _z = z / 100f;

        float _R = Mathf.Abs(_x * 2.04159f + _y * -0.56501f + _z * -0.34473f);
        float _G = Mathf.Abs(_x * -0.96924f + _y * 1.87597f + _z * 0.03342f);
        float _B = Mathf.Abs(_x * 0.01344f + _y * -0.11836f + _z * 1.34926f);

        float powerRGB = 1 / 2.19921875f;
        float _RR = Mathf.Round(Mathf.Pow(_R, powerRGB));
        float _GG = Mathf.Round(Mathf.Pow(_G, powerRGB));
        float _BB = Mathf.Round(Mathf.Pow(_B, powerRGB));

        float _AdobeR = _R * lightness;
        float _AdobeG = _G * lightness;
        float _AdobeB = _B * lightness;

        Vector3 RGB = new Vector3(_AdobeR, _AdobeG, _AdobeB);
        return RGB;
    }
