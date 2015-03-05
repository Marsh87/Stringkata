﻿using System;
using Engine;
using Katarai.StringCalculator.Interfaces;
using NUnit.Framework;

/*
  BEFORE YOU START :
  This Kata is meant to teach TDD cadence, growing a solution using tests and speed. 
  It’s designed to be a bit long for the time you have when you start, and the idea 
  is to practice it until you can do it really fast, while rigorously practising TDD. 
  This will ingrain the cadence of TDD and the keyboard shortcuts and refactorings 
  you need to be fast. Remember, the only way to go fast is to go well. 
*/

/*
  RULES : 
  1.	Strictly practice TDD: Red, Green, Refactor
  2.	Clean Code is required:
    2.1.	Intention-revealing names
    2.2.	Verb/verb-phrase method names
    2.3.	Methods should do one thing and be short, with no side-effects
    2.4.	Methods should contain only one level of abstraction
    2.5.	Code should read like a top-down narrative
    2.6.	No unnecessary code
    2.7.	DRY
    2.8.	Unit tests that test pieces of the algorithm, not only acceptance level tests.
*/

/*
  GOALS : 
  +	Silver: 25 minutes
  +	Gold:   20 minutes
*/

/*
  THE KATA : 
  1.  Create a simple String calculator with a method int Add(string numbers) 
      1.1.	The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
      1.2.	Start with the simplest test case of an empty string and move to 1 and two numbers
      1.3.	Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
      1.4.	Remember to refactor after each passing test
  2.  Allow the Add method to handle an unknown amount of numbers
  3.  Allow the Add method to handle new lines between numbers (instead of commas). 
      3.1.	the following input is ok:  “1\n2,3”  (will equal 6)
      3.2.	the following input is NOT ok:  “1,\n” (not need to prove it - just clarifying)
  4.  Support different delimiters 
      4.1.	to change a delimiter, the beginning of the string will contain a separate line that looks like this:   “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ . 
      4.2.	the first line is optional. all existing scenarios should still be supported
  5.  Calling Add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed.if there are multiple negatives, show all of them in the exception message 
      If you can complete up to here within 30 minutes, then carry on. 
  6.  Numbers bigger than 1000 should be ignored, so adding 2 + 1001  = 2
  7.  Delimiters can be of any length with the following format:  “//[delimiter]\n” for example: “//[***]\n1***2***3” should return 6
  8.  Allow multiple delimiters like this:  “//[delim1][delim2]\n” for example “//[*][%]\n1*2%3” should return 6.
  9.  Make sure you can also handle multiple delimiters with length longer than one char
 */


namespace PlayerStringKata
{
    public class StringCalculatorTest : ITestPack<IStringCalculator>
    {
        public Func<IStringCalculator> CreateSUT { get; set; }

		[SetUp]
        public void SetupTest()
        {
            CreateSUT = () => new StringCalculator();
        }
		
        [Test]
        public void Construct_ShouldNotThrow()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => CreateSUT());
            //---------------Test Result -----------------------
        }
    }
}
