﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RogueSharp.Algorithms;

namespace RogueSharp.Test.Algorithms
{
   [TestClass]
   public class IndexMinPriorityQueueTest
   {
      [TestMethod]
      public void IsEmpty_AfterConstructingNewQueue_WillBeTrue()
      {
         IndexMinPriorityQueue<double> queue = new IndexMinPriorityQueue<double>( 10 );

         Assert.IsTrue( queue.IsEmpty() );
      }

      [TestMethod]
      public void Size_AfterInserting1Key_WillBe1()
      {
         IndexMinPriorityQueue<double> queue = new IndexMinPriorityQueue<double>( 10 );
         queue.Insert( 4, 12.5 );

         Assert.AreEqual( 1, queue.Size );
      }

      [TestMethod]
      public void Contains_Index4AfterInsertingKeyAtIndex4_WillBeTrue()
      {
         IndexMinPriorityQueue<double> queue = new IndexMinPriorityQueue<double>( 10 );
         queue.Insert( 4, 12.5 );

         Assert.IsTrue( queue.Contains( 4 ) );
      }

      [TestMethod]
      public void MinIndex_WhenMultipleKeysAreInQueue_WillReturnIndexOfMinimumKey()
      {
         IndexMinPriorityQueue<double> queue = new IndexMinPriorityQueue<double>( 10 );
         queue.Insert( 4, 12.5 );
         queue.Insert( 3, 40.12 );
         queue.Insert( 7, 4.3 );
         queue.Insert( 2, 162.75 );

         int minIndex = queue.MinIndex();
         
         Assert.AreEqual( 7, minIndex );
      }

      [TestMethod]
      public void MinKey_WhenMultipleKeysAreInQueue_WillReturnMinimumKey()
      {
         IndexMinPriorityQueue<double> queue = new IndexMinPriorityQueue<double>( 10 );
         queue.Insert( 4, 12.5 );
         queue.Insert( 3, 40.12 );
         queue.Insert( 7, 4.3 );
         queue.Insert( 2, 162.75 );

         double minKey = queue.MinKey();

         Assert.AreEqual( 4.3, minKey );
      }
   }
}
