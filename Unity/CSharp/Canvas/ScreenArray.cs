// Get a Screen Array and illustrate with spheres on an Orthographic camera
// From TopLeft to BottomRight corner with borders
    
    private Camera cam;
    public float borderLimit;
    
    [SerializeField] private Vector3 center;
    [SerializeField] private Vector3 topleft;
    [SerializeField] private Vector3 topRight;
    [SerializeField] private Vector3 bottomLeft;
    [SerializeField] private Vector3 bottomRight;

    [SerializeField] private float pixelX;
    [SerializeField] private float pixelY;


    private void Awake()
    {
        cam = Camera.main;
        
        SetPosition(center);
        DrawArrayOnCanvas();
    }


    // Ortho Screen Camera Boundaries - Center, TopLeft, TopRight, BottomLeft, BottomRight
    private void Ortho_ScreenCameraBoundaries()
    {
      // Get pixel width and height 
        pixelX = cam.pixelWidth;
        pixelY = cam.pixelHeight;
        
        // Set Screen Coordinates Boundaries
        center = cam.ScreenToWorldPoint(new Vector3(pixelX / 2, pixelY / 2, 0));
        float x1 = borderLimit;
        float x2 = pixelX - borderLimit;
        float y1 = pixelY - borderLimit;
        float y2 = borderLimit;

        topleft = cam.ScreenToWorldPoint(new Vector3(x1, y1, 0));
        topRight = cam.ScreenToWorldPoint(new Vector3(x2, y1, 0));
        bottomLeft = cam.ScreenToWorldPoint(new Vector3(x1, y2, 0));
        bottomRight = cam.ScreenToWorldPoint(new Vector3(x2, y2, 0));
    }
    


    // Ex : Position gameoject at the center of the screen
    private void SetPosition (Vector3 position)
    {
        transform.position = topleft; 
    }
    


    // Draw an array of Spheres (TopLeft to BottomRight) 
    private void DrawArrayOnCanvas()
    {
        for (var j = topleft.y; j >= bottomLeft.y; j--)
        {
            for (var i = topleft.x; i < topRight.x; i++)
            {
                GameObject dot = GameObject.CreatePrimitive(PrimitiveType.Sphere); // Illustration of the array with spheres
                dot.transform.position = new Vector2(i, j);
            }
        }
    }
