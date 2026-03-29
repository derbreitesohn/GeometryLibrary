# Geometry Library 
## About The Project
This project is a comprehensive 3D Geometry Library paired with a Computation Engine. It allows users to define, manipulate, and combine complex 3D shapes. The program demonstrates advanced C# concepts like operator overloading, custom indexers, and interface-based sorting.
### Built With:
- C#
- .NET 10

## Getting Started
Follow these instructions to get the library linked and the computation demo running on your local machine.
### Prerequisites
To run this project, you will need the .NET SDK installed.
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)

### Installation
1. Clone or Download the Repository
2. Link the Library: Since this is a multi-project solution, ensure the Computation project can see the library by running this in the Computation folder:
```bash
dotnet add reference ../GeometryLibrary/GeometryLibrary.csproj
```

### Usage
Run the demonstration program to see geometric calculations, shape combinations, and volume-based sorting:

Navigate to the computation directory:
```bash
cd Computation
``` 
Run the program:
```bash
dotnet run
```
## Roadmap
### Implemented Features
- Basic shapes: Sphere, Cube, Cylinder      
- Volume and surface area calculations for each shape
- Operator overloading for shape combination
- Custom indexers for shape properties
- Interface-based sorting by volume

### Future Enhancements
- Additional shapes (e.g., Cone, Torus)
- More complex shape combinations (e.g., unions, intersections)
- Graphical visualization of shapes

## Contributing
1. Fork the Repository
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License
Distributed under the MIT License. See `LICENSE` for more information.

## Contact
Flo Madner - [cc241045@ustp-students.at]
Project Link: [https://github.com/derbreitesohn/GeometryLibrary.git]

## Acknowledgements
[C# Programming](https://yun-vis.net/ustp-bcc-csharp/)
[.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
[Cross Product](https://en.wikipedia.org/wiki/Cross_product)
[Operator Overloading](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading)

