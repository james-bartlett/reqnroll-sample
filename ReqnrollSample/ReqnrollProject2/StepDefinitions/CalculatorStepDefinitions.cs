
using ClassLibrary1;
using ReqnrollProject1.Drivers;

namespace ReqnrollProject2.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions(SampleDriverFromProject _driver) 
{
    // For additional details on Reqnroll step definitions see https://go.reqnroll.net/doc-stepdef
    int firstNumber;
    int secondNumber;
    int output;

    [Given("the first num is {int}")]
    public void GivenTheFirstNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.reqnroll.net/doc-sharingdata
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        firstNumber = number;
    }

    [Given("the second num is {int}")]
    public void GivenTheSecondNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic

        secondNumber = number;
    }

    [When("the two nums are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        //TODO: implement act (action) logic

        output = firstNumber + secondNumber;
    }

    [Then("the output should be {int}")]
    public void ThenTheResultShouldBe(int result)
    {
        //TODO: implement assert (verification) logic

        Assert.Equal(result, output);
    }
}
