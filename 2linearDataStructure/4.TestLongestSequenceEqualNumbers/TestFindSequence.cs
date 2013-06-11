using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;


[TestClass]
public class TestFindSequence
{
    [TestMethod]
    public void TestWithNoElements()
    {
        List<int> expected = new List<int>();
        List<int> actual = LongestSubsequence.FindTheLongestSequenceEqualNumbers(expected);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestWithOneElement()
    {
        List<int> expected = new List<int>() {1000 };
        List<int> actual = LongestSubsequence.FindTheLongestSequenceEqualNumbers(expected);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestWithEqualElements()
    {
        List<int> expected = new List<int>() { 1,1,1,1};
        List<int> actual = LongestSubsequence.FindTheLongestSequenceEqualNumbers(expected);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestWithDifferentElemetns()
    {
        List<int> expected = new List<int>() { 1, 1, 1, 1 };
        List<int> allItems = new List<int>() { 1,2,8, 1, 1,4, 1 };
        allItems.Sort();
        List<int> actual = LongestSubsequence.FindTheLongestSequenceEqualNumbers(allItems);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void TestWithEqualElementsAtTheEnd()
    {
        List<int> expected = new List<int>() { 1, 1, 1, 1 };
        List<int> allItems = new List<int>() { 2, 2, 8, 6, 7, 4, 1,1,1,1 };
        allItems.Sort();
        List<int> actual = LongestSubsequence.FindTheLongestSequenceEqualNumbers(allItems);
        CollectionAssert.AreEqual(expected, actual);
    }
}

