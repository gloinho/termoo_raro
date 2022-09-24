namespace Testes;

[TestClass]
public class TermooTest
{
    [TestMethod]
    public void TestIfPlayerGotRightInFirstAttempt()
    {
        Termoo game = new Termoo();
        List<string> actual = game.Play("venus");
        List<string> expected = new List<string> { "You won!" };
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestIfPlayerGotRightOneLetter()
    {
        Termoo game = new Termoo();
        List<string> actual = game.Play("virgo");
        List<string> expected = new List<string>
        {
            "Letter v is in the right position",
            "Word does not contains letter i",
            "Word does not contains letter r",
            "Word does not contains letter g",
            "Word does not contains letter o"
        };
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestIfPlayerWonInTheLastAttempt()
    {
        Termoo game = new Termoo();
        List<string> play1 = game.Play("virgo");
        List<string> expected1 = new List<string>
        {
            "Letter v is in the right position",
            "Word does not contains letter i",
            "Word does not contains letter r",
            "Word does not contains letter g",
            "Word does not contains letter o"
        };
        CollectionAssert.AreEqual(expected1, play1);
        List<string> play2 = game.Play("valha");
        List<string> expected2 = new List<string>
        {
            "Letter v is in the right position",
            "Word does not contains letter a",
            "Word does not contains letter l",
            "Word does not contains letter h",
            "Word does not contains letter a"
        };
        CollectionAssert.AreEqual(expected2, play2);
        List<string> play3 = game.Play("vulgo");
        List<string> expected3 = new List<string>
        {
            "Letter v is in the right position",
            "Letter u is not in the right position",
            "Word does not contains letter l",
            "Word does not contains letter g",
            "Word does not contains letter o"
        };
        CollectionAssert.AreEqual(expected3, play3);
        List<string> play4 = game.Play("valor");
        List<string> expected4 = new List<string>
        {
            "Letter v is in the right position",
            "Word does not contains letter a",
            "Word does not contains letter l",
            "Word does not contains letter o",
            "Word does not contains letter r"
        };
        CollectionAssert.AreEqual(expected4, play4);
        List<string> play5 = game.Play("venus");
        List<string> expected5 = new List<string> { "You won!" };
        CollectionAssert.AreEqual(expected5, play5);
    }

    [TestMethod]
    public void TestLettersRepeated()
    {
        Termoo game = new Termoo();
        List<string> actual = game.Play("uuuuu");
        List<string> expected = new List<string>
        {
            "Letter u is not in the right position",
            "Letter u is not in the right position",
            "Letter u is not in the right position",
            "Letter u is in the right position",
            "Letter u is not in the right position"
        };
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestIfPlayerLost()
    {
        Termoo game = new Termoo();
        game.Play("uuuuu");
        game.Play("uuuuu");
        game.Play("uuuuu");
        game.Play("uuuuu");
        List<string> actual = game.Play("uuuuu");
        List<string> expected = new List<string> { "You lost! The word was venus" };
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestInvalidWord()
    {
        Termoo game = new Termoo();
        List<string> actual = game.Play("anastacio");
        List<string> expected = new List<string> { "Invalid Word" };
        CollectionAssert.AreEqual(expected, actual);
    }
}
