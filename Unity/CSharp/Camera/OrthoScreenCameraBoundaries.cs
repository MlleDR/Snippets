    
    // Some examples of screen positions with borderlimits on an Orthographic camera
    
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
        
        // Get pixel width and height 
        pixelX = cam.pixelWidth;
        pixelY = cam.pixelHeight;
    }

    // Ortho Screen Camera Boundaries - Center, TopLeft, TopRight, BottonmLeft, BottomRight
    private void Ortho_ScreenCameraBoundaries()
    {
        // Set Brush Coordinates Boundaries
        center = cam.ScreenToWorldPoint(new Vector3(pixelX / 2, pixelY / 2, 0));
        float x1 = borderLimit;
        float x2 = pixelX - borderLimit;
        float y1 = pixelY - borderLimit;
        float y2 = borderLimit;

        topleft = cam.ScreenToWorldPoint(new Vector3(x1, y1, 0));
        topRight = cam.ScreenToWorldPoint(new Vector3(x2, y1, 0));
        bottomLeft = cam.ScreenToWorldPoint(new Vector3(x1, y2, 0));
        bottomRight = cam.ScreenToWorldPoint(new Vector3(x2, y2, 0))

        // Ex : Position gameoject at the center of the screen
        transform.position = topleft; 
    }

    
    
