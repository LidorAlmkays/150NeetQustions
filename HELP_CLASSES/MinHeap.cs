using System;
using System.Collections.Generic;

public class MinHeap<T> where T : IComparable<T>
{
    private List<T> heap = new();

    public int Count => heap.Count;

    public void Insert(T val)
    {
        heap.Add(val);
        HeapifyUp(heap.Count - 1);
    }

    public T ExtractMin()
    {
        if (heap.Count == 0) throw new InvalidOperationException("Heap is empty");

        T min = heap[0];
        heap[0] = heap[^1];
        heap.RemoveAt(heap.Count - 1);
        HeapifyDown(0);
        return min;
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;
            if (heap[index].CompareTo(heap[parent]) >= 0)
                break;

            (heap[index], heap[parent]) = (heap[parent], heap[index]);
            index = parent;
        }
    }

    private void HeapifyDown(int index)
    {
        int lastIndex = heap.Count - 1;
        while (index < heap.Count)
        {
            int left = 2 * index + 1, right = 2 * index + 2;
            int smallest = index;

            if (left <= lastIndex && heap[left].CompareTo(heap[smallest]) < 0)
                smallest = left;
            if (right <= lastIndex && heap[right].CompareTo(heap[smallest]) < 0)
                smallest = right;

            if (smallest == index)
                break;

            (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
            index = smallest;
        }
    }
}