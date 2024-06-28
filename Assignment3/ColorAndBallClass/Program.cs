// See https://aka.ms/new-console-template for more information


using ColorAndBallClass;

Color redColor = new Color(255, 0, 0);
Color greenColor = new Color(0, 255, 0);
Color blueColor = new Color(0, 0, 255);

Ball redBall = new Ball(10, redColor);
Ball greenBall = new Ball(15, greenColor);
Ball blueBall = new Ball(20, blueColor);

redBall.Throw();
greenBall.Throw();
greenBall.Throw();
blueBall.Throw();

redBall.Pop();
redBall.Throw();

Console.WriteLine($"Red ball throw count: {redBall.GetThrowCount()}");
Console.WriteLine($"Green ball throw count: {greenBall.GetThrowCount()}");
Console.WriteLine($"Blue ball throw count: {blueBall.GetThrowCount()}");


