using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace _07_Interfaces_and_Abstract_Classes
{
    #region Program

    internal class Program: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private int name;

        public int Name
        {
            get { return  Name; }
            set 
            { 
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }


        static void Main(string[] args)
        {
           Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 2 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 20 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });
            wallet.Add(new Money() { amount = 200 });

            foreach (Money money in wallet)
            {
                System.Diagnostics.Debug.WriteLine($"Bill: {money.amount}");
            }

            BaseClass childClass = new BaseClass();
            childClass.PrintMessages();
        }
    }

    #endregion

    #region IComparable
    /// <summary>
    /// IComparable interface
    /// </summary>
    public class Example2 : IComparable
    {
        public int exampleLength;
        Example2 example2 = new Example2() { exampleLength = 2};

        public int CompareTo(object? obj)
        {
            Example2 example = obj as Example2;
            if (example2.exampleLength == example.exampleLength) 
            {
                return 0;
            } else if (example2.exampleLength > example.exampleLength)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
    #endregion

    #region IComparer
    /// <summary>
    /// IComparer interface
    /// </summary>

    public class Empoyee
    {
        public int Id;
    }
    public class Example : IExample, IComparer
    {
        public int Compare(object x, object y)
        {
            Empoyee empoyee = x as Empoyee;
            Empoyee empoyee1 = y as Empoyee;
            return empoyee.Id.CompareTo(empoyee1.Id);
        }
    }
    #endregion

    #region IEquatable
    /// <summary>
    /// IEquatable interface
    /// </summary>
    public class Equatable : IEquatable<Equatable>
    {

        public string exampleData_;
        public bool Equals(Equatable other)
        {
            if (other == null)
            { return false; }

            //return exampleData_.GetHashCode() == other.exampleData_.GetHashCode();
            return exampleData_.GetHashCode().Equals(other.exampleData_.GetHashCode());
        }
    }
    #endregion

    #region Custom
    /// <summary>
    /// Custom interface
    /// </summary>
    interface IExample
    {
        void Example() { }
        void Example2(string main) { }

    }
    #endregion

    #region IEqualityComparer 
    /// <summary>
    /// IEqualityComparer interface
    /// </summary>
    public class Officer
    {       

        private Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
    }

    public class EqualityComparer : IEqualityComparer<Officer>
    {
        public bool Equals(Officer x, Officer y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Officer obj)
        {
            return obj.Id.GetHashCode();
        }
    }
    #endregion

    #region IEnumerable
    public class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;
        public Wallet()
        {
            bills = new Money[100];
        }

        public void Add(Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Money bill in bills)
            {
                if (bill == null)
                {
                    break;
                }

                yield return bill;
            }
        }
    }

    public class Money
    {
        public int amount;
    }
    #endregion

    #region IEnumerator
    /// <summary>
    /// How to use the IEnumerator interface.
    /// </summary>
    public class Enumerator : IEnumerator
    {
        List<object> items = new List<object>();
        int current;
        public object Current => items[current];

        public bool MoveNext()
        {
            if (items.Count == 0 || items.Count <= current)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            current = 0;
        }
    }
    #endregion

    #region ICollection
    /// <summary>
    /// The ICollection interface is implemented by all collections in .NET.
    /// </summary>
    public class Collection : ICollection
    {
        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region AbstractClass
    /// <summary>
    /// The abstract calls is mostly used as a base class.
    /// </summary>
    public abstract class Animal
    {
        public abstract void Run(int speed);
        
    }

    public class Dog : Animal
    {
        public override void Run(int speed)
        {
            System.Diagnostics.Debug.WriteLine($"The Dog is running at speed: {speed}");
        }
    }
    #endregion

    #region VirtualMethods

    public class BaseClass
    {
        public virtual void PrintMessages()
        {
            Debug.WriteLine("The World is yours");
        }
    }

    public class ChildClass : BaseClass
    {
        public  override void PrintMessages()
        {
            Debug.WriteLine("Yes it is");
            base.PrintMessages();
        }
    }
    #endregion
}