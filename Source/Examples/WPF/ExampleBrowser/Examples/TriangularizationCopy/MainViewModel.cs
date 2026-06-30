using System;
using System.Collections.Generic;
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
        List<Point3D> triangleInXYPlane = new List<Point3D>();

        // Read mesh positions from CSV file
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string positionsFilePath = System.IO.Path.Combine(baseDirectory, "Examples", "TriangularizationCopy", "mesh_positions.csv");
        
        if (!System.IO.File.Exists(positionsFilePath))
        {
            throw new System.IO.FileNotFoundException(
                $"Required file not found. Expected at: {positionsFilePath}. " +
                "Ensure 'mesh_positions.csv' is set to 'Copy to Output Directory' in file properties.");
        }

        string[] lines = System.IO.File.ReadAllLines(positionsFilePath);
        foreach (string line in lines)
        {
            string[] values = line.Split(',');
            if (values.Length != 3) throw new InvalidOperationException("Found invalid data in the input file");
            double x = double.Parse(values[0], System.Globalization.CultureInfo.InvariantCulture);
            double y = double.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture);
            double z = double.Parse(values[2], System.Globalization.CultureInfo.InvariantCulture);
            triangleInXYPlane.Add(new Point3D(x, y, z));
        }

        foreach (Point3D point in triangleInXYPlane)
        {
            meshBuilder.Positions.Add(point.ToVector3());
        }

        // Read triangle indices from CSV file
        List<int> triangleIndices = new List<int>();
        string indicesFilePath = System.IO.Path.Combine(baseDirectory, "Examples", "TriangularizationCopy", "mesh_triangleIndices.csv");
        
        if (!System.IO.File.Exists(indicesFilePath))
        {
            throw new System.IO.FileNotFoundException(
                $"Required file not found. Expected at: {indicesFilePath}. " +
                "Ensure 'mesh_triangleIndices.csv' is set to 'Copy to Output Directory' in file properties.");
        }
        
        string[] indexLines = System.IO.File.ReadAllLines(indicesFilePath);
        foreach (string line in indexLines)
        {
            string[] values = line.Split(',');
            foreach (string value in values)
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    triangleIndices.Add(int.Parse(value.Trim(), System.Globalization.CultureInfo.InvariantCulture));
                }
            }
        }

        foreach (int index in triangleIndices)
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
