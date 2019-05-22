# Linq Kata
The goal of this [code kata](https://en.wikipedia.org/wiki/Kata_(programming)) is to learn more about using [LINQ](https://en.wikipedia.org/wiki/Language_Integrated_Query) in C#. 

## Getting Started
This repo starts with a single unit test in `Test.cs` that always passes. That test as it exists does not help us learn more about LINQ, but it can help make sure our development environment is properly configured.

To start, try running `dotnet watch test` in the main directory of this repository. The code should compile, the single unit test should get executed, and that single test should pass. If this is the case for you then you are ready to continue to the rest of the kata.

## `GetAllEvens()` First Test
For the first part of this kata we will write a method named `GetAllEvens()` that takes a `List<int>` and returns a `List<int>` that contains only the even numbers from the original list.

For the first unit test, write a test that gets a list of integers from `DataHelper.GetIntList()`. Pass that list of integers to the code that you are writing. Check the list that your code returns to ensure that every integer in the returned list is even.

Do not use LINQ as part of your test code, but _do_ use LINQ as part of your implementation.

## `GetAllEvens()` Second Test (protection against evil)
Imagine for a moment that for this kata you are responsible for writing the unit tests and another person is writing the implementation. Now imagine that the other person is evil and wants to do whatever they can to _not_ implement their code the correct way.

Could someone write code that passes the tests we have written so far that doesn't actually do the thing we want it to? Yes, they could. What if the implementation of the `GetAllEvens()` method was simply `return new List<int> { 2 }`? Every integer in the list is even. But it is not actually the result we want.

For the second test, write a unit test that ensures that every even number in the original list is also in the result list.

Do not use LINQ as part of your code for this test.

## `GetAllEvens()` Third Test
We are going to add a requirement that the `GetAllEvens()` method should return its results ordered from smallest to largest. For the third unit test, write a test that ensures that the list that your code returns is in ascending order.

Do not use LINQ as part of your code for this test.

## In Space, Things are Bigger and Better
Performing operations on lists of integers is interesting, but a more complex example can better demonstrate some of the capabilities of LINQ. For the rest of the tests we will write in this kata we will use a list of planets that we will get by calling the `DataHelper.GetPlanets()` method.

We would like to write some code that takes a `List<Planet>` and returns just the names of the planets in a `List<string>`. Write a test that calls that code and then ensures that the name of every planet is contained in the returned list.

Do not use LINQ as part of your code for this test.

## Bringing Order to Chaos
Getting the names of planets is great, but just like our list of even integers, we would like the names of the planets to be in order. Write a test that ensures that returned planet names are in their correct ordinal order. The ordinal values start at 1 and are contiguous (i.e. no numbers are skipped).

Do not use LINQ as part of this test.

## Space is a Dangerous Place
Some planets can be inhabited by humans and some cannot. Write a method that takes a list of planets and returns true if any of the planets are habitable. In your test, ensure that when the list returned by `DataHelper.GetPlanets()` is passed to your method that it returns true.

Do not use LINQ as part of this test.

## More Evil in the Universe
Remember when we talked about imagining the person writing the implementation of your code is evil? Let's do that again. Right now, do we have any tests keeping that evil person from always returning `true` in the code that looks for habitable planets?

For this test, sort the planets returned by `DataHelper.GetPlanets()` in ascending ordinal order, then take the last three planets. Pass that list of three planets to your code that checks for habitable planets. Your test should ensure that the response in this case is `false`.

You _may_ use LINQ as part of this test.

## Bonus Mass
Write a method that takes a `List<Planet>` and returns the sum of their masses. In your test ensure that the returned mass is correct.

Do not use LINQ as part of this test.
