// Solution to The Complex Lazy Evaluation Challenge

using System;
using System.Collections.Generic;

public class Complex
{
    public double Re { get; }
    public double Im { get; }

    public Complex(double re, double im)
    {
        Re = re;
        Im = im;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Re + b.Re, a.Im + b.Im);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Re * b.Re - a.Im * b.Im, a.Re * b.Im + a.Im * b.Re);
    }
}

public class ComplexStreamProcessor
{
    private IEnumerable<Complex> DataStream;

    public ComplexStreamProcessor(IEnumerable<Complex> dataStream)
    {
        DataStream = dataStream;
    }

    public IEnumerable<Complex> Take(int n)
    {
        int count = 0;
        foreach (Complex complex in DataStream)
        {
            if (count >= n)
            {
                yield break;
            }

            yield return complex;
            count++;
        }
    }

    public IEnumerable<Complex> Where(Func<Complex, bool> predicate)
    {
        foreach (Complex complex in DataStream)
        {
            if (predicate(complex))
            {
                yield return complex;
            }
        }
    }

    public IEnumerable<Complex> Select(Func<Complex, Complex> selector)
    {
        foreach (Complex complex in DataStream)
        {
            yield return selector(complex);
        }
    }

    public Complex Aggregate(Func<Complex, Complex, Complex> aggregationFunction)
    {
        Complex result = new Complex(0, 0);
        bool isFirstElement = true;

        foreach (Complex complex in DataStream)
        {
            if (isFirstElement)
            {
                result = complex;
                isFirstElement = false;
            }
            else
            {
                result = aggregationFunction(result, complex);
            }
        }

        return result;
    }
}
