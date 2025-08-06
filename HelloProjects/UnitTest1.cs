namespace HelloProjects;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int seed1 = 1, seed2 = 3;

        int answer = seed1 + seed2;
        int result = Sum(seed1, seed2);
        Assert.Equal(answer, result);
    }

    private int Sum(int a, int b)
        => a + b;
}