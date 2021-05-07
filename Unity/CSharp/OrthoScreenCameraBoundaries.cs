    
    // Some examples of screen positions on an Orthographic camera
    
    private Camera cam;
    public float borderLimit;

    private void Awake()
    {
        cam = Camera.main;
    }

    // Ortho Screen Camera Boundaries - Center, TopLeft, TopRight, BottonLeft, BottonRight
    private void Ortho_ScreenCameraBoundaries()
    {
        // Set Brush Coordinates Boundaries
        center = cam.ScreenToWorldPoint(new Vector3(pixelX / 2, pixelY / 2, 0));
        topleft = cam.ScreenToWorldPoint(new Vector3(borderLimit, pixelY - borderLimit, 0));
        topRight = cam.ScreenToWorldPoint(new Vector3(pixelX - borderLimit, pixelY - borderLimit, 0));
        bottomLeft = cam.ScreenToWorldPoint(new Vector3(borderLimit, borderLimit, 0));
        bottomRight = cam.ScreenToWorldPoint(new Vector3(pixelX - borderLimit, borderLimit, 0));

        // Ex : Position gameoject at the center of the screen
        transform.position = center; 
    }
    
    
