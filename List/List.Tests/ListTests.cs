using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace List.Tests
{
    public class ListTests
    {
        [Fact]
        public void Get_ElementExist_ReturnCollectionElement()// MethodName_Condition_ExpectedResult()
        {
            //Arrange - variables, classes, mocks
            var collectionElements = new List<int>();
            collectionElements.Add(200);
            collectionElements.Add(201);
            collectionElements.Add(202);

            //Act
            var result = collectionElements.Get(2);

            //Assert
            result.Should().Be(202);
        }

        [Fact]
        public void Get_ListIsEmpty_OutOfRangeExeption1()
        {
            //Arrange - variables, classes, mocks
            var collectionElement = new List<int>();

            //Assert
            Assert.Throws<IndexOutOfRangeException>(() => collectionElement.Get(0));
        }

        [Fact]
        public void Get_ListIsEmpty_OutOfRangeExeption2()
        {
            //Arrange - variables, classes, mocks
            var collectionElement = new List<int>();

            //Assert
            Assert.Throws<IndexOutOfRangeException>(() => collectionElement.Get(-2));
        }

        [Fact]
        public void Add_IsAddedToTheEnd_EndElementEqualToInput()
        {
            var myList = new List<string>();
            myList.Add("lol");
            myList.Add("kek");
            myList.Add("chebureck");

            var result = myList.Get(2);

            result.Should().Be("chebureck");
        }

        [Fact]
        public void Add_AddedToFullList_Length()
        {
            var myList = new List<string>();
            myList.Add("lol");
            myList.Add("kek");
            myList.Add("chebureck");

            var result = myList.Length;

            result.Should().Be(3);
        }

        [Fact]
        public void Insert_IndexExist_OutOfRangeExeption()
        {
            var myList = new List<int>();

            Assert.Throws<IndexOutOfRangeException>(()=> myList.Insert(0, 1));
        }

        [Fact]
        public void Insert_EndElementLessThanLength_IncreasedArray()
        {
            var myList = new List<double>();

            myList.Add(1);
            myList.Add(2);
            myList.Insert(1.5, 2);

            var result = myList.Length;

            result.Should().Be(3);
        }


        [Fact]
        public void Insert_InsertData_ShiftData()
        {
            var myList = new List<double>();

            myList.Add(1);
            myList.Add(2);
            myList.Insert(1.5, 2);

            var result = myList[2];

            result.Should().Be(2);
        }

        //[Fact]
        //public void InsertAll_CollectionNull_ArgumentNullException()
        //{
        //    var myList = new List<int>();
        //    var myListNull = new List<Nullable>();

        //    Assert.Throws<ArgumentNullException>(()=>myList.InsertAll((IEnumerable<int>)myListNull));
        //}

        [Fact]
        public void InsertAll_CollectionSizeLessThanNeeded_IncreasedArray()
        {
            var myList = new List<int>();
            var myList2 = new List<int>();

            myList.Add(1);
            myList2.Add(6);
            myList2.Add(7);
            myList.InsertAll((IEnumerable<int>)myList2);

            var result = myList.Length;

            result.Should().Be(3);
        }

        [Fact]
        public void RemoveAt_IDontDuckinKnow_AnotherElementAtPosition()
        {
            var myList = new List<int>();

            myList.Add(1);
            myList.Add(6);
            myList.Add(-7);
            myList.Add(-10);
            myList.Add(0);
            myList.RemoveAt(2);

            myList[2].Should().Be(-10);
        }
    }
}
