using System;
using NUnit.Framework;

using FizzBuzzMain;

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

namespace FizzBuzzTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InitZeroReturnsFalse()
        {
            Console.WriteLine("Running test 1!");

            var fizzBuzz = new FizzBuzz();
            bool pf = fizzBuzz.init(0);
            Assert.AreEqual(false, pf);
        }

        [Test]
        public void InitGreaterThanZeroReturnsTrue()
        {
            Console.WriteLine("Running test 2!");

            var fizzBuzz = new FizzBuzz();
            bool pf = fizzBuzz.init(1);
            Assert.AreEqual(true, pf);
        }

        [Test]
        public void RunZero()
        {
            var fizzBuzz = new FizzBuzz();
            bool pf = fizzBuzz.init(0);

            try {
                fizzBuzz.run();
                Console.WriteLine("Should Fail");
            } catch (Exception e) {
                Assert.Pass();
                return;
            }

            Assert.Fail("Exception was not raised");
        }

        [Test]
        public void RunOneDoesNotError()
        {
            var fizzBuzz = new FizzBuzz();
            bool pf = fizzBuzz.init(1);

            try {
                fizzBuzz.run();
                Console.WriteLine("Should Not Fail");
            } catch (Exception e) {
                Assert.Fail();
            }

            Assert.Pass();
        }

        [Test]
        public void RunOne()
        {
            string[] expected = new string[1];
            expected[0] = "1";

            var fizzBuzz = new FizzBuzz();
            bool pf = fizzBuzz.init(1);

            var result = fizzBuzz.run();
            Console.WriteLine("Should Not Fail");

            Assert.AreEqual(result, expected);
        }

                [Test]
        public void RunTwo()
        {
            string[] expected = new string[2];
            expected[0] = "1";
            expected[1] = "2";

            var fizzBuzz = new FizzBuzz();
            bool pf = fizzBuzz.init(2);

            var result = fizzBuzz.run();

            Assert.AreEqual(result, expected);
        }

                [Test]
                public void RunThree()
        {
            string[] expected = new string[3];
            expected[0] = "1";
            expected[1] = "2";
            expected[2] = "Fizz";

            var fizzBuzz = new FizzBuzz();
            bool pf = fizzBuzz.init(3);

            var result = fizzBuzz.run();

            Assert.AreEqual(result, expected);
        }
    }
}