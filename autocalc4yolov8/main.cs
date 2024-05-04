using System.Runtime.CompilerServices;

string filePath = "output.csv";
/// this initializes the program



bool loop = true;
void init()
{
    using (StreamWriter writer = new StreamWriter(filePath, append: true))
    {

        writer.WriteLine($"{"width"},{"height"},{"startvalueX"},{"startvalueY"},{"centerX"},{"centerY"},{"%width"},{"%height"},{"itemnr"},{"dataset-id"},{DateTime.Now.ToString()},{DateTime.Now.ToString("HH:mm:ss")}");
    }
    Console.WriteLine("Program initialized");
}

int inputWidth()
{
    int intTemp = Convert.ToInt32(Console.ReadLine());
    return intTemp;

}
int inputHeight()
{
    int intTemp = Convert.ToInt32(Console.ReadLine());
    return intTemp;
}
int inputStartX()
{
    int intTemp = Convert.ToInt32(Console.ReadLine());
    return intTemp;
}
int inputStartY()
{
    int intTemp = Convert.ToInt32(Console.ReadLine());
    return intTemp;
}
double calculateCenterX(int width, int selectionStartX)
{
    
    
    int imageWidth = 5472;

    int selectionEndX = selectionStartX + width;
    double centerX = (selectionStartX + selectionEndX) / 2.0;
    double centerXRelative = centerX / imageWidth;

    return centerXRelative;


}
double calculateCenterY(int height, int selectionStartY)
{


    int imageHeight = 3648;

    int selectionEndY = selectionStartY + height;
    double centerY = (selectionStartY + selectionEndY) / 2.0;
    double centerYRelative = centerY / imageHeight;

    return centerYRelative;


}
double divide(int x, int divisionfactor)
{
    double result = (double)x / divisionfactor;
    return result;
}


init();
while (loop == true)
{
    Console.WriteLine("Input data:  width, height, start value x, start value y, img number, dataset-id");
    int width = inputWidth();
    int height = inputHeight();
    int sX = inputStartX();
    int sY = inputStartY();
    int imgnr = Convert.ToInt32(Console.ReadLine());
    int dsetid = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(calculateCenterX(width, sX));
    Console.WriteLine(calculateCenterY(height, sY));
    Console.WriteLine(divide(width, 5472));
    Console.WriteLine(divide(height, 3648));

    // Open or create the file

    using (StreamWriter writer = new StreamWriter(filePath, append: true))
    {

        // Write variables to the file
        writer.WriteLine($"{width},{height},{sX},{sY},{calculateCenterX(width, sX)},{calculateCenterY(height, sY)},{divide(width, 5472)},{divide(height, 3648)},{imgnr},{dsetid}");
    }

    Console.WriteLine("press n to exit");
    string inputExit = Console.ReadLine();
    if (inputExit == "n")
    {
        loop = false;
    }
}


