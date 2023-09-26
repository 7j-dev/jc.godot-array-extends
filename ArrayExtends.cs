using Godot;
using System.Runtime.CompilerServices;

namespace JC.Collections;

public static class ArrayExtends
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Assing<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr, Godot.Collections.Array<T> p_item)
    {
        p_arr.Clear();
        p_arr.AddRange(p_item);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Back<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr)
    {
        return p_arr[^1];
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T Front<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr) =>
        p_arr[0];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEmpty<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr) =>
        p_arr.Count == 0;


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T PopAt<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr, int position)
    {
        T element = p_arr[position];
        p_arr.RemoveAt(position);
        return element;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void PushFront<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr, T item)
    {
        p_arr.Insert(0, item);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void PushBack<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr, T item)
    {
        p_arr.Insert(p_arr.Count, item);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T PopFront<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr)
    {
        T firstElement = p_arr[0];
        p_arr.RemoveAt(0);

        return firstElement;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T PopBack<[MustBeVariant] T>(this Godot.Collections.Array<T> p_arr)
    {
        T element = p_arr[^1];
        p_arr.RemoveAt(p_arr.Count - 1);

        return element;
    }
}