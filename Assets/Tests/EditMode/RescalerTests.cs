using NUnit.Framework;

public class RescalerTests
{
    [Test]
    [TestCase(2, -1, 1, 2)]
    [TestCase(2, 0, 1, 1)]
    [TestCase(2, -1, 0, 1)]
    public void RescaleFaceMethodTests(float initialScale, float firstContact, float secondContact, float expectedResult)
    {
        float result = Rescaler.RescaleFace(initialScale, firstContact, secondContact);
        Assert.AreEqual(result, expectedResult);
    }
    
    [Test]
    [TestCase(0, 2, 2, 0)]
    [TestCase(1, 2, 1, 0.5f)]
    [TestCase(-1, 2, 1, -0.5f)]
    public void FindCoordinateMethodTests(float coordinate, float scale, float rescaledFace, float expectedResult)
    {
        float result = Rescaler.FindCoordinate(coordinate, scale, rescaledFace);
        Assert.AreEqual(result, expectedResult);
    }
}
