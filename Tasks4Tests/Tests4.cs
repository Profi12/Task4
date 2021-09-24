using NUnit.Framework;
using System;
using Task4_Library;

namespace Tasks4_Tests
{
    public class Tests
    {
        [TestCase(new int[] {504, 37, 94,282, 1 }, 1)]
        [TestCase(new int[] {245, 303, 14, 278, 912 }, 14)]
        [TestCase(new int[] {437, 3 }, 3)]
        [TestCase(new int[] { 456, 30, 499, 72, 561 }, 30)]
        [TestCase(new int[] {481 }, 481)]
        public void Min_WhenFilledArrayPassed_ShouldGetMinimumElementOfArray(
            int[] array, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.Min(array));
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Min_WhenIncorrectInput_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.Min(array);
            });
        }

        [TestCase(new int[] { 741, 35 }, 741)]
        [TestCase(new int[] { 58, 43, 4, 222, 151 }, 222)]
        [TestCase(new int[] { 381 }, 381)]
        [TestCase(new int[] { 25, 331, 114, 286, 901 }, 901)]
        [TestCase(new int[] { 405, 30, 149, 752, 61 }, 752)]
        public void Max_WhenFilledArrayPassed_ShouldGetMaximumElementOfArray(
            int[] array, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.Max(array));
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Max_WhenIncorrectInput_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.Max(array);
            });
        }

        [TestCase(new int[] { 5, 37, 45, 231, 13 }, 0)]
        [TestCase(new int[] { 459 }, 0)]
        [TestCase(new int[] { 725, 133, 164, 289, 291 }, 1)]
        [TestCase(new int[] { 294, 73 }, 1)]
        [TestCase(new int[] { 405, 730, 49, 472, 11 }, 4)]
        public void MinIndex_WhenFilledArrayPassed_ShouldGetIndexOfMinimumElementOfArray
            (int[] array, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.MinIndex(array));
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void MinIndex_WhenIncorrectInput_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.MinIndex(array);
            });
        }

        [TestCase(new int[] { 58, 43, 4, 222, 151 }, 3)]
        [TestCase(new int[] { 25, 331, 114, 286, 901 }, 4)]
        [TestCase(new int[] { 341 }, 0)]
        [TestCase(new int[] { 400, 33 }, 0)]
        [TestCase(new int[] { 405, 30, 149, 752, 61 }, 3)]
        public void MaxIndex_WhenFilledArrayPassed_ShouldGetIndexOfMaximumElementOfArray(
            int[] array, int expected)
        {
            Assert.AreEqual(expected, TaskHelper.MaxIndex(array));
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void MaxIndex_WhenIncorrectInput_ShouldThrowArgumentException(int[] array)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                TaskHelper.MaxIndex(array);
            });
        }
    }
}