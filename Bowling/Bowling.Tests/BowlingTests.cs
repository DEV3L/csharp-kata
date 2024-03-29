using System;

using NUnit.Framework;

/*
Z - Zero
O - One
M - Many
B - Boundary Behaviors
I - Interface Definition
E - Exercise Exceptional
S - Simple Scenarios, Simple Solutions
*/

/*
TDD : Test Driven Development

1. You are not allowed to write any production code unless it is to make
    a failing unit test pass.
2. You are not allowed to write any more of a unit test than is sufficient to fail;
    and compilation failures are failures.
3. You are not allowed to write any more production code than is sufficient to pass
    the one failing unit test.
*/

namespace Bowling.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var program = new Program();
            program.doNothing();

            // Assert.Pass();

            Console.WriteLine("Test Output");
        }
    }
}