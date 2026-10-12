using Delay.Core;

var engine = new DelayEngine(3);

float[] leftInput = {1f, 0f, 0f, 0f};
float[] rightInput = new float[leftInput.Length];

Console.WriteLine();

for (int i = 0; i < leftInput.Length; i++)
{
    Console.WriteLine(engine.ProcessSample(leftInput[i], rightInput[i]));
}