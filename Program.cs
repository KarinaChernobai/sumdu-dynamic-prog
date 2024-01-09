namespace DynamicProg;

public class Program
{
	static void Main(string[] args)
	{
		double[] invOptions = { 0, 1, 2, 3, 4, 5 };
		double[,] samplesMx =
		{
			{ 0,   0,   0,  },
			{ 0.2, 1,   1.5 },
			{ 0.6, 1.5, 2.2 },
			{ 1.5, 2,   3.4 },
			{ 2.4, 3,   4   },
			{ 4.4, 4.9, 5.1 },
		};
		var invPlan = new int[samplesMx.GetLength(1)];
		BellmanEq.Solve(invOptions, samplesMx, invPlan, 5, new LogWriter(Console.Out));
		Console.Out.WriteLine();
	}
}
