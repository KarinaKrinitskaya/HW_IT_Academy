using CSharpOOP3;

#region Task_1

Ball ball001 = new Ball("Ball_Jack", 7);

ball001.GetVolume();
ball001.PrintShapeInf();

Pyramid pyramid001 = new Pyramid("Pyramid_Puk", 12, 6);

pyramid001.GetVolume();
pyramid001.PrintShapeInf();

Cylinder cylinder001 = new Cylinder("Cylinder_Mike", 3, 7);

cylinder001.GetVolume();
cylinder001.PrintShapeInf();

#endregion

#region Task_2

Student student001 = new Student("Kukushin", 20);
student001.PrintInfAboutStudent();

#endregion

Console.ReadLine();