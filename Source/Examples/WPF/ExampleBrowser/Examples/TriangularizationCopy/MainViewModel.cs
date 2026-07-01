using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;

namespace ExampleBrowser.Examples.TriangularizationCopy;

/// <summary>
/// Provides a ViewModel for the Main window.
/// </summary>
public sealed class MainViewModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MainViewModel"/> class.
    /// </summary>
    public MainViewModel()
    {
        // Create a model group
        Model3DGroup modelGroup = new();

        // Create a mesh builder and add a box to it
        MeshBuilder meshBuilder = new(false, false);
        CreateSimpleTriangulatedMesh(meshBuilder);

        // Create a mesh from the builder (and freeze it)
        MeshGeometry3D mesh = meshBuilder.ToMesh().ToWndMeshGeometry3D(true);

        // Create some materials
        Material blueMaterial = MaterialHelper.CreateMaterial(Colors.Blue);
        //Material insideMaterial = MaterialHelper.CreateMaterial(Colors.Yellow);

        modelGroup.Children.Add(new GeometryModel3D
        {
            Geometry = mesh,
            Material = blueMaterial,
            //BackMaterial = insideMaterial
        });

        Model = modelGroup;
    }

    private static void CreateSimpleTriangulatedMesh(MeshBuilder meshBuilder)
    {
        List<Vector2> triangleInPositiveOrientation = new List<Vector2>()
        {
            new Vector2(0f, 0f),
            new Vector2(9109.07f, 0f),
            new Vector2(9109.07f, 412.75f),
            new Vector2(9010.65f, 412.75f),
            new Vector2(9008.664f, 412.90637f),
            new Vector2(9006.726f, 413.37158f),
            new Vector2(9004.885f, 414.13422f),
            new Vector2(9003.186f, 415.1755f),
            new Vector2(9001.67f, 416.46976f),
            new Vector2(9000.376f, 417.98514f),
            new Vector2(8999.335f, 419.68433f),
            new Vector2(8998.572f, 421.52548f),
            new Vector2(8998.106f, 423.4633f),
            new Vector2(8997.95f, 425.45f),
            new Vector2(8997.95f, 457.2f),
            new Vector2(111.12f, 457.2f),
            new Vector2(111.12f, 425.45f),
            new Vector2(110.963646f, 423.4633f),
            new Vector2(110.49842f, 421.52548f),
            new Vector2(109.73579f, 419.68433f),
            new Vector2(108.69452f, 417.98514f),
            new Vector2(107.40026f, 416.46976f),
            new Vector2(105.88487f, 415.1755f),
            new Vector2(104.185684f, 414.13422f),
            new Vector2(102.34451f, 413.37158f),
            new Vector2(100.406715f, 412.90637f),
            new Vector2(98.42f, 412.75f),
            new Vector2(0f, 412.75f)
        };

        List<Vector2> hole1 = new List<Vector2>()
        {
            new Vector2(28.8f, 228.6f),
            new Vector2(28.856533f, 227.52127f),
            new Vector2(29.025517f, 226.45436f),
            new Vector2(29.305096f, 225.41095f),
            new Vector2(29.69221f, 224.40248f),
            new Vector2(30.182617f, 223.44f),
            new Vector2(30.770945f, 222.53406f),
            new Vector2(31.450745f, 221.69458f),
            new Vector2(32.214573f, 220.93076f),
            new Vector2(33.054054f, 220.25095f),
            new Vector2(33.96f, 219.66263f),
            new Vector2(34.922478f, 219.17221f),
            new Vector2(35.930943f, 218.78511f),
            new Vector2(36.97435f, 218.50552f),
            new Vector2(38.041264f, 218.33653f),
            new Vector2(39.12f, 218.28f),
            new Vector2(40.198734f, 218.33653f),
            new Vector2(41.265648f, 218.50552f),
            new Vector2(42.309055f, 218.78511f),
            new Vector2(43.31752f, 219.17221f),
            new Vector2(44.28f, 219.66263f),
            new Vector2(45.185944f, 220.25095f),
            new Vector2(46.02543f, 220.93076f),
            new Vector2(46.789253f, 221.69458f),
            new Vector2(47.469055f, 222.53406f),
            new Vector2(48.05738f, 223.44f),
            new Vector2(48.547787f, 224.40248f),
            new Vector2(48.934902f, 225.41095f),
            new Vector2(49.21448f, 226.45436f),
            new Vector2(49.383465f, 227.52127f),
            new Vector2(49.44f, 228.6f),
            new Vector2(49.383465f, 229.67874f),
            new Vector2(49.21448f, 230.74565f),
            new Vector2(48.934902f, 231.78906f),
            new Vector2(48.547787f, 232.79753f),
            new Vector2(48.05738f, 233.76001f),
            new Vector2(47.469055f, 234.66595f),
            new Vector2(46.789253f, 235.50543f),
            new Vector2(46.02543f, 236.26926f),
            new Vector2(45.185944f, 236.94907f),
            new Vector2(44.28f, 237.53738f),
            new Vector2(43.31752f, 238.0278f),
            new Vector2(42.309055f, 238.4149f),
            new Vector2(41.265648f, 238.69449f),
            new Vector2(40.198734f, 238.86348f),
            new Vector2(39.12f, 238.92001f),
            new Vector2(38.041264f, 238.86348f),
            new Vector2(36.97435f, 238.69449f),
            new Vector2(35.930943f, 238.4149f),
            new Vector2(34.922478f, 238.0278f),
            new Vector2(33.96f, 237.53738f),
            new Vector2(33.054054f, 236.94907f),
            new Vector2(32.214573f, 236.26926f),
            new Vector2(31.450745f, 235.50543f),
            new Vector2(30.770945f, 234.66595f),
            new Vector2(30.182617f, 233.76001f),
            new Vector2(29.69221f, 232.79753f),
            new Vector2(29.305096f, 231.78906f),
            new Vector2(29.025517f, 230.74565f),
            new Vector2(28.856533f, 229.67874f)
        };

        List<Vector2> hole2 = new List<Vector2>()
        {
            new Vector2(28.8f, 304.8f),
            new Vector2(28.856533f, 303.72125f),
            new Vector2(29.025517f, 302.65433f),
            new Vector2(29.305096f, 301.61093f),
            new Vector2(29.69221f, 300.60248f),
            new Vector2(30.182617f, 299.63998f),
            new Vector2(30.770945f, 298.73404f),
            new Vector2(31.450745f, 297.89456f),
            new Vector2(32.214573f, 297.13074f),
            new Vector2(33.054054f, 296.45093f),
            new Vector2(33.96f, 295.8626f),
            new Vector2(34.922478f, 295.3722f),
            new Vector2(35.930943f, 294.98508f),
            new Vector2(36.97435f, 294.7055f),
            new Vector2(38.041264f, 294.53653f),
            new Vector2(39.12f, 294.47998f),
            new Vector2(40.198734f, 294.53653f),
            new Vector2(41.265648f, 294.7055f),
            new Vector2(42.309055f, 294.98508f),
            new Vector2(43.31752f, 295.3722f),
            new Vector2(44.28f, 295.8626f),
            new Vector2(45.185944f, 296.45093f),
            new Vector2(46.02543f, 297.13074f),
            new Vector2(46.789253f, 297.89456f),
            new Vector2(47.469055f, 298.73404f),
            new Vector2(48.05738f, 299.63998f),
            new Vector2(48.547787f, 300.60248f),
            new Vector2(48.934902f, 301.61093f),
            new Vector2(49.21448f, 302.65433f),
            new Vector2(49.383465f, 303.72125f),
            new Vector2(49.44f, 304.8f),
            new Vector2(49.383465f, 305.87872f),
            new Vector2(49.21448f, 306.94565f),
            new Vector2(48.934902f, 307.98904f),
            new Vector2(48.547787f, 308.9975f),
            new Vector2(48.05738f, 309.96f),
            new Vector2(47.469055f, 310.86594f),
            new Vector2(46.789253f, 311.7054f),
            new Vector2(46.02543f, 312.46924f),
            new Vector2(45.185944f, 313.14905f),
            new Vector2(44.28f, 313.73737f),
            new Vector2(43.31752f, 314.22778f),
            new Vector2(42.309055f, 314.6149f),
            new Vector2(41.265648f, 314.89447f),
            new Vector2(40.198734f, 315.06345f),
            new Vector2(39.12f, 315.12f),
            new Vector2(38.041264f, 315.06345f),
            new Vector2(36.97435f, 314.89447f),
            new Vector2(35.930943f, 314.6149f),
            new Vector2(34.922478f, 314.22778f),
            new Vector2(33.96f, 313.73737f),
            new Vector2(33.054054f, 313.14905f),
            new Vector2(32.214573f, 312.46924f),
            new Vector2(31.450745f, 311.7054f),
            new Vector2(30.770945f, 310.86594f),
            new Vector2(30.182617f, 309.96f),
            new Vector2(29.69221f, 308.9975f),
            new Vector2(29.305096f, 307.98904f),
            new Vector2(29.025517f, 306.94565f),
            new Vector2(28.856533f, 305.87872f)
        };

        List<Vector2> hole3 = new List<Vector2>()
        {
            new Vector2(28.8f, 381f),
            new Vector2(28.856533f, 379.92126f),
            new Vector2(29.025517f, 378.85434f),
            new Vector2(29.305096f, 377.81094f),
            new Vector2(29.69221f, 376.8025f),
            new Vector2(30.182617f, 375.84f),
            new Vector2(30.770945f, 374.93405f),
            new Vector2(31.450745f, 374.09457f),
            new Vector2(32.214573f, 373.33075f),
            new Vector2(33.054054f, 372.65094f),
            new Vector2(33.96f, 372.06262f),
            new Vector2(34.922478f, 371.5722f),
            new Vector2(35.930943f, 371.1851f),
            new Vector2(36.97435f, 370.90552f),
            new Vector2(38.041264f, 370.73654f),
            new Vector2(39.12f, 370.68f),
            new Vector2(40.198734f, 370.73654f),
            new Vector2(41.265648f, 370.90552f),
            new Vector2(42.309055f, 371.1851f),
            new Vector2(43.31752f, 371.5722f),
            new Vector2(44.28f, 372.06262f),
            new Vector2(45.185944f, 372.65094f),
            new Vector2(46.02543f, 373.33075f),
            new Vector2(46.789253f, 374.09457f),
            new Vector2(47.469055f, 374.93405f),
            new Vector2(48.05738f, 375.84f),
            new Vector2(48.547787f, 376.8025f),
            new Vector2(48.934902f, 377.81094f),
            new Vector2(49.21448f, 378.85434f),
            new Vector2(49.383465f, 379.92126f),
            new Vector2(49.44f, 381f),
            new Vector2(49.383465f, 382.07874f),
            new Vector2(49.21448f, 383.14566f),
            new Vector2(48.934902f, 384.18906f),
            new Vector2(48.547787f, 385.1975f),
            new Vector2(48.05738f, 386.16f),
            new Vector2(47.469055f, 387.06595f),
            new Vector2(46.789253f, 387.90543f),
            new Vector2(46.02543f, 388.66925f),
            new Vector2(45.185944f, 389.34906f),
            new Vector2(44.28f, 389.93738f),
            new Vector2(43.31752f, 390.4278f),
            new Vector2(42.309055f, 390.8149f),
            new Vector2(41.265648f, 391.09448f),
            new Vector2(40.198734f, 391.26346f),
            new Vector2(39.12f, 391.32f),
            new Vector2(38.041264f, 391.26346f),
            new Vector2(36.97435f, 391.09448f),
            new Vector2(35.930943f, 390.8149f),
            new Vector2(34.922478f, 390.4278f),
            new Vector2(33.96f, 389.93738f),
            new Vector2(33.054054f, 389.34906f),
            new Vector2(32.214573f, 388.66925f),
            new Vector2(31.450745f, 387.90543f),
            new Vector2(30.770945f, 387.06595f),
            new Vector2(30.182617f, 386.16f),
            new Vector2(29.69221f, 385.1975f),
            new Vector2(29.305096f, 384.18906f),
            new Vector2(29.025517f, 383.14566f),
            new Vector2(28.856533f, 382.07874f)
        };

        List<Vector2> hole4 = new List<Vector2>()
        {
            new Vector2(9059.64f, 228.6f),
            new Vector2(9059.696f, 227.52127f),
            new Vector2(9059.865f, 226.45436f),
            new Vector2(9060.1455f, 225.41095f),
            new Vector2(9060.532f, 224.40248f),
            new Vector2(9061.022f, 223.44f),
            new Vector2(9061.611f, 222.53406f),
            new Vector2(9062.291f, 221.69458f),
            new Vector2(9063.055f, 220.93076f),
            new Vector2(9063.894f, 220.25095f),
            new Vector2(9064.8f, 219.66263f),
            new Vector2(9065.763f, 219.17221f),
            new Vector2(9066.7705f, 218.78511f),
            new Vector2(9067.814f, 218.50552f),
            new Vector2(9068.881f, 218.33653f),
            new Vector2(9069.96f, 218.28f),
            new Vector2(9071.039f, 218.33653f),
            new Vector2(9072.105f, 218.50552f),
            new Vector2(9073.149f, 218.78511f),
            new Vector2(9074.157f, 219.17221f),
            new Vector2(9075.12f, 219.66263f),
            new Vector2(9076.026f, 220.25095f),
            new Vector2(9076.865f, 220.93076f),
            new Vector2(9077.629f, 221.69458f),
            new Vector2(9078.309f, 222.53406f),
            new Vector2(9078.897f, 223.44f),
            new Vector2(9079.388f, 224.40248f),
            new Vector2(9079.774f, 225.41095f),
            new Vector2(9080.055f, 226.45436f),
            new Vector2(9080.224f, 227.52127f),
            new Vector2(9080.28f, 228.6f),
            new Vector2(9080.224f, 229.67874f),
            new Vector2(9080.055f, 230.74565f),
            new Vector2(9079.774f, 231.78906f),
            new Vector2(9079.388f, 232.79753f),
            new Vector2(9078.897f, 233.76001f),
            new Vector2(9078.309f, 234.66595f),
            new Vector2(9077.629f, 235.50543f),
            new Vector2(9076.865f, 236.26926f),
            new Vector2(9076.026f, 236.94907f),
            new Vector2(9075.12f, 237.53738f),
            new Vector2(9074.157f, 238.0278f),
            new Vector2(9073.149f, 238.4149f),
            new Vector2(9072.105f, 238.69449f),
            new Vector2(9071.039f, 238.86348f),
            new Vector2(9069.96f, 238.92001f),
            new Vector2(9068.881f, 238.86348f),
            new Vector2(9067.814f, 238.69449f),
            new Vector2(9066.7705f, 238.4149f),
            new Vector2(9065.763f, 238.0278f),
            new Vector2(9064.8f, 237.53738f),
            new Vector2(9063.894f, 236.94907f),
            new Vector2(9063.055f, 236.26926f),
            new Vector2(9062.291f, 235.50543f),
            new Vector2(9061.611f, 234.66595f),
            new Vector2(9061.022f, 233.76001f),
            new Vector2(9060.532f, 232.79753f),
            new Vector2(9060.1455f, 231.78906f),
            new Vector2(9059.865f, 230.74565f),
            new Vector2(9059.696f, 229.67874f)
        };

        List<Vector2> hole5 = new List<Vector2>()
        {
            new Vector2(9059.64f, 304.8f),
            new Vector2(9059.696f, 303.72125f),
            new Vector2(9059.865f, 302.65433f),
            new Vector2(9060.1455f, 301.61093f),
            new Vector2(9060.532f, 300.60248f),
            new Vector2(9061.022f, 299.63998f),
            new Vector2(9061.611f, 298.73404f),
            new Vector2(9062.291f, 297.89456f),
            new Vector2(9063.055f, 297.13074f),
            new Vector2(9063.894f, 296.45093f),
            new Vector2(9064.8f, 295.8626f),
            new Vector2(9065.763f, 295.3722f),
            new Vector2(9066.7705f, 294.98508f),
            new Vector2(9067.814f, 294.7055f),
            new Vector2(9068.881f, 294.53653f),
            new Vector2(9069.96f, 294.47998f),
            new Vector2(9071.039f, 294.53653f),
            new Vector2(9072.105f, 294.7055f),
            new Vector2(9073.149f, 294.98508f),
            new Vector2(9074.157f, 295.3722f),
            new Vector2(9075.12f, 295.8626f),
            new Vector2(9076.026f, 296.45093f),
            new Vector2(9076.865f, 297.13074f),
            new Vector2(9077.629f, 297.89456f),
            new Vector2(9078.309f, 298.73404f),
            new Vector2(9078.897f, 299.63998f),
            new Vector2(9079.388f, 300.60248f),
            new Vector2(9079.774f, 301.61093f),
            new Vector2(9080.055f, 302.65433f),
            new Vector2(9080.224f, 303.72125f),
            new Vector2(9080.28f, 304.8f),
            new Vector2(9080.224f, 305.87872f),
            new Vector2(9080.055f, 306.94565f),
            new Vector2(9079.774f, 307.98904f),
            new Vector2(9079.388f, 308.9975f),
            new Vector2(9078.897f, 309.96f),
            new Vector2(9078.309f, 310.86594f),
            new Vector2(9077.629f, 311.7054f),
            new Vector2(9076.865f, 312.46924f),
            new Vector2(9076.026f, 313.14905f),
            new Vector2(9075.12f, 313.73737f),
            new Vector2(9074.157f, 314.22778f),
            new Vector2(9073.149f, 314.6149f),
            new Vector2(9072.105f, 314.89447f),
            new Vector2(9071.039f, 315.06345f),
            new Vector2(9069.96f, 315.12f),
            new Vector2(9068.881f, 315.06345f),
            new Vector2(9067.814f, 314.89447f),
            new Vector2(9066.7705f, 314.6149f),
            new Vector2(9065.763f, 314.22778f),
            new Vector2(9064.8f, 313.73737f),
            new Vector2(9063.894f, 313.14905f),
            new Vector2(9063.055f, 312.46924f),
            new Vector2(9062.291f, 311.7054f),
            new Vector2(9061.611f, 310.86594f),
            new Vector2(9061.022f, 309.96f),
            new Vector2(9060.532f, 308.9975f),
            new Vector2(9060.1455f, 307.98904f),
            new Vector2(9059.865f, 306.94565f),
            new Vector2(9059.696f, 305.87872f)
        };

        List<Vector2> hole6 = new List<Vector2>()
        {
            new Vector2(9059.64f, 381f),
            new Vector2(9059.696f, 379.92126f),
            new Vector2(9059.865f, 378.85434f),
            new Vector2(9060.1455f, 377.81094f),
            new Vector2(9060.532f, 376.8025f),
            new Vector2(9061.022f, 375.84f),
            new Vector2(9061.611f, 374.93405f),
            new Vector2(9062.291f, 374.09457f),
            new Vector2(9063.055f, 373.33075f),
            new Vector2(9063.894f, 372.65094f),
            new Vector2(9064.8f, 372.06262f),
            new Vector2(9065.763f, 371.5722f),
            new Vector2(9066.7705f, 371.1851f),
            new Vector2(9067.814f, 370.90552f),
            new Vector2(9068.881f, 370.73654f),
            new Vector2(9069.96f, 370.68f),
            new Vector2(9071.039f, 370.73654f),
            new Vector2(9072.105f, 370.90552f),
            new Vector2(9073.149f, 371.1851f),
            new Vector2(9074.157f, 371.5722f),
            new Vector2(9075.12f, 372.06262f),
            new Vector2(9076.026f, 372.65094f),
            new Vector2(9076.865f, 373.33075f),
            new Vector2(9077.629f, 374.09457f),
            new Vector2(9078.309f, 374.93405f),
            new Vector2(9078.897f, 375.84f),
            new Vector2(9079.388f, 376.8025f),
            new Vector2(9079.774f, 377.81094f),
            new Vector2(9080.055f, 378.85434f),
            new Vector2(9080.224f, 379.92126f),
            new Vector2(9080.28f, 381f),
            new Vector2(9080.224f, 382.07874f),
            new Vector2(9080.055f, 383.14566f),
            new Vector2(9079.774f, 384.18906f),
            new Vector2(9079.388f, 385.1975f),
            new Vector2(9078.897f, 386.16f),
            new Vector2(9078.309f, 387.06595f),
            new Vector2(9077.629f, 387.90543f),
            new Vector2(9076.865f, 388.66925f),
            new Vector2(9076.026f, 389.34906f),
            new Vector2(9075.12f, 389.93738f),
            new Vector2(9074.157f, 390.4278f),
            new Vector2(9073.149f, 390.8149f),
            new Vector2(9072.105f, 391.09448f),
            new Vector2(9071.039f, 391.26346f),
            new Vector2(9069.96f, 391.32f),
            new Vector2(9068.881f, 391.26346f),
            new Vector2(9067.814f, 391.09448f),
            new Vector2(9066.7705f, 390.8149f),
            new Vector2(9065.763f, 390.4278f),
            new Vector2(9064.8f, 389.93738f),
            new Vector2(9063.894f, 389.34906f),
            new Vector2(9063.055f, 388.66925f),
            new Vector2(9062.291f, 387.90543f),
            new Vector2(9061.611f, 387.06595f),
            new Vector2(9061.022f, 386.16f),
            new Vector2(9060.532f, 385.1975f),
            new Vector2(9060.1455f, 384.18906f),
            new Vector2(9059.865f, 383.14566f),
            new Vector2(9059.696f, 382.07874f)
        };

        List<List<Vector2>> allHoles = new List<List<Vector2>>()
        {
            hole1, hole2, hole3, hole4, hole5, hole6
        };

        List<int>? indices = SweepLinePolygonTriangulator.Triangulate(
            triangleInPositiveOrientation,
            allHoles);

        List<Vector2> allPositions = triangleInPositiveOrientation.Concat(allHoles.SelectMany(x => x)).ToList();
        //it's up to the user how to map 2D points to 3D, in this case we simply add a z-coordinate to the points:
        IEnumerable<Vector3> allVector2s3D = allPositions.Select(p => new Vector3(p.X, p.Y, 0f));
        foreach (Vector3 point in allVector2s3D)
            meshBuilder.Positions.Add(new Vector3((float)point.X, (float)point.Y, (float)point.Z));

        foreach (int index in indices!)
        {
            meshBuilder.TriangleIndices.Add(index);
        }
    }

    /// <summary>
    /// Gets or sets the model.
    /// </summary>
    /// <value>The model.</value>
    public Model3D Model { get; set; }
}
