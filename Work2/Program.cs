using Work2;

Buildings[] height = new Buildings[5];
Random rand = new Random();

for (int i = 0; i < height.Length; i++)
{
    height[i] = new Buildings(rand.Next(15, 300), rand.Next(15, 300), rand.Next(15, 300));
    Console.WriteLine(height[i]);
}