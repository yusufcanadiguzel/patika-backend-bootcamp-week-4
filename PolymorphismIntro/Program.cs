using PolymorphismIntro;

//nesne olusturma
Rectangle rectangle = new Rectangle(height: 3, width:5);
RightTriangle rightTriangle = new RightTriangle(height: 5, width: 3);
Square square = new Square(height: 3, width: 3);

//alan hesabi yapma
rectangle.CalculateArea();
rightTriangle.CalculateArea();
square.CalculateArea();