namespace HelloWorld {
    internal class Program
    {
        struct Volume
        {
            public string shape;
            public double side;
            public double length;
            public double width;
            public double height;
            public double diameter;


            public Volume(string shape, double side = 0, double length = 0, double width = 0 , double height = 0 , double diameter = 0)
            {
                this.shape = shape;
                this.length = length;
                this.width = width;
                this.height = height;
                this.side = side;
                this.diameter = diameter;
            } 
        }
        private static void Main(string[] args)
        {
           // Start
           Volume volume = GetShape();
           switch (volume.shape)
           {
            case "r" :
            {
                Console.WriteLine();
                Console.WriteLine($"The Volume Is : {volume.height * volume.length * volume.width} m3");
                Console.WriteLine();
                break;
            }
            case "s" :
            {
                Console.WriteLine();
                Console.WriteLine($"The Volume Is : {Math.Pow(volume.side, 3)} m3");
                Console.WriteLine();
                break;
            }
            default:
            {
                Console.WriteLine();
                Console.WriteLine($"The Volume Is : {string.Format("{0:0.00}",volume.height * Math.PI * Math.Pow(volume.diameter/2,2))} m3");
                Console.WriteLine();
                break;
            }
           }
        }

        static Volume GetShape()
        {
            string shape;
            do 
            {
                Console.WriteLine();
                Console.WriteLine($"Please Select A Shape : \n \"C\" --> Cube \n \"Cy\" --> Cylinder");
                Console.WriteLine();
                Console.Write("--> ");
                shape = Console.ReadLine().Trim().ToLower();
            } while(shape != "c" && shape != "cy");

            if (shape == "c")
            {
                bool success = true;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine($"Please Select The Type Of The Cube : \n \"R\" --> Rectangle \n \"S\" --> Square");
                    Console.WriteLine();
                    Console.Write("--> ");
                    shape = Console.ReadLine().Trim().ToLower();
                } while (shape != "s" && shape != "r");
                    
                if(shape == "r")
                {
                    double length, width, height;
                    do {
                        Console.WriteLine();
                        Console.Write($"Please Enter The Length : ");
                        success = double.TryParse(Console.ReadLine(), out length);
                        Console.Write($"Please Enter The Width : ");
                        success = double.TryParse(Console.ReadLine(), out width);
                        Console.Write($"Please Enter The Height : ");
                        success = double.TryParse(Console.ReadLine(), out height);
                    } while (!success);

                    return new Volume(shape,0,length, width, height);
                } else 
                {
                    double side;
                    do {
                        Console.WriteLine();
                        Console.Write($"Please Enter The Side : ");
                        success = double.TryParse(Console.ReadLine(), out side);
                    } while (!success);
                    return new Volume(shape, side);
                } 
            }else 
            {
                bool success = true;
                double height, diameter;
                do 
                {
                    Console.WriteLine();
                    Console.Write($"Please Enter The Height : ");
                    success = double.TryParse(Console.ReadLine(), out height);
                    Console.Write($"Please Enter The Diameter : ");
                    success = double.TryParse(Console.ReadLine(), out diameter);
                } while (!success);
                return new Volume(shape, 0, 0, 0, height, diameter);
            }
        }
    }
}