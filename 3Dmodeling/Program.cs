// initialize a Scene object
using Aspose.ThreeD;
using Aspose.ThreeD.Entities;

// Initialize scene object
Scene scene = new Scene();



// Initialize Node class object
Node cubeNode = new Node("box");

// ExStart:ConvertBoxPrimitivetoMesh
// Initialize object by Box class
IMeshConvertible convertible = new Box();
// Convert a Box to Mesh
Mesh mesh = convertible.ToMesh();
// ExEnd:ConvertBoxPrimitivetoMesh

// Point node to the Mesh geometry
cubeNode.Entity = mesh;

// Add Node to a scene
scene.RootNode.ChildNodes.Add(cubeNode);



var outputPath = Path.Combine(Directory.GetCurrentDirectory(), "output.obj");
scene.Save(outputPath, FileFormat.WavefrontOBJ);
Console.WriteLine($"Finished {outputPath}");