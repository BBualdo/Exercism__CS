using System;
using System.Collections.Generic;
using System.Linq;

public class CircularBuffer<T>(int capacity)
{
    private T[] _buffer { get; set; } = new T[capacity];
    private int _size;
    private int _nextBufferIndex;

    public T Read()
    {
        if (_size == 0) throw new InvalidOperationException();
        var item = _buffer.Where(t => !EqualityComparer<T>.Default.Equals(t, default)).Min();
        if (item is null) throw new InvalidOperationException();
        Remove(item);
        return item;
    }

    public void Write(T value)
    {
        if (_size == _buffer.Length) throw new InvalidOperationException();
        _buffer[_nextBufferIndex] = value;
        _size++;
        _nextBufferIndex++;
        if (_nextBufferIndex == _buffer.Length) _nextBufferIndex = 0;
    }

    public void Overwrite(T value)
    {
        _buffer[_nextBufferIndex] = value;
        if (_size != _buffer.Length) _size++;
        _nextBufferIndex++;
        if (_nextBufferIndex == _buffer.Length) _nextBufferIndex = 0;
    }

    public void Clear()
    {
        _buffer = new T[capacity];
        _size = 0;
        _nextBufferIndex = 0;
    }

    private void Remove(T value)
    {
        for (var i = 0; i < _buffer.Length; i++)
        {
            if (_buffer[i].Equals(value))
            {
                _buffer[i] = default;
                _size--;
                break;
            }
        }
    }
}