using Practica_OOP.Class;

Estudiante estudiante = new Estudiante("Goku", 30, "Los mina", "Informática", "1234-5678");
estudiante.InformacionEstudiante();

Figura rectangulo = new Rectangulo(5, 10);
Figura circulo = new Circulo(7);
Figura triangulo = new Triangulo(6, 8);

Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());