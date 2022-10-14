namespace TTD;

[TestFixture]

public class Tests
{
        Maths operation=null;

        Maths operation1=null;

        Maths operation3=null;

        
    [SetUp]
    public void Setup()
    {
       operation=new Maths();

       operation1=new Maths();

       operation3=new Maths();

    }

    [Test]
    public void Test1()
    {
        int result=operation.Addition(20,11);
        Assert.That(result,Is.EqualTo(31));
    }
    [TestCase (10,20,30)]
    [TestCase (1,2,3)]

    public void IsAdditionOk(int a,int b,int result)
    {
        int output=operation.Addition(a,b);
        Assert.AreEqual(output,result);
        int output1=operation.Addition(a,b);
        
    }

    [TestCase(1.2,2.1,3.29999999999798)]
    public void IsAdditionOk(double e,double f,double result )
    {
        double output=operation.Addition(e,f);
        {
            Assert.AreEqual(output,result);
        }
    }

    [TestCase ("Ravi","Chandran","RaviChandran")]
    public void IsAdditionOk(string a,string b,string result)
    {
        string output=operation.Addition(a,b);
        Assert.AreEqual(output,result);
    }
}